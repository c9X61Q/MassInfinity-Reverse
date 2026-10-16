// MassDumper — 全量强制 JIT + MethodDesc 键表
//
// 背景：DNGuard HVM 把每个受保护方法的 IL 落盘替换为
//       `ldstr "Error, DNGuard Runtime library not loaded!"; newobj Exception; throw`
//       （MassRecon 静态清单：52,948 个方法中 52,159 个是这种桩）。
//       真实 IL 只在 JIT 编译该方法时由保护器在现场解密并交给真正的 clrjit，
//       所以覆盖率完全取决于「有多少方法被编译过」——这正是上一阶段只有
//       11,902 条（22.5%）的原因。
//
// 两件事：
//   ① 强制 JIT：直接对全部方法调 RuntimeHelpers.PrepareMethod，不依赖 UI 交互。
//   ② 身份键表：compileMethod 只给 MethodDesc*，没有名字/token。
//      托管侧 `MethodBase.MethodHandle.Value` 返回的就是同一个 MethodDesc*，
//      于是可以离线建一张 `md → (mvid, token, 类型, 方法, 签名)` 的表，
//      Frida 只负责抓 `(ftn, IL 字节)`，两者用 MethodDesc 做主键 join ——
//      运行期互不通信、无顺序依赖，多线程并发 JIT / tiering / 重复编译都不影响。
//
// 用法（需在交互式桌面会话中运行，见 run-dumper.bat）：
//   MassDumper.exe <目标目录> <输出目录>
using System.Diagnostics;
using System.Reflection;
using System.Reflection.Emit;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace MassDumper;

internal static class Program
{
    private static string _outDir = ".";
    private static StreamWriter _map;
    private static readonly HashSet<long> SeenMd = new();
    private static readonly Dictionary<string, int> FailKinds = new();
    private static int _total, _ok, _fail, _skip, _mapped;
    private static long _t0;

    private static int Main(string[] args)
    {
        string targetDir = args.Length > 0 ? args[0] : @"C:\mass\dumper";
        _outDir = args.Length > 1 ? args[1] : targetDir;
        Directory.CreateDirectory(_outDir);

        _map = new StreamWriter(Path.Combine(_outDir, "map.txt"), false, new UTF8Encoding(false));
        _map.WriteLine("#md_hex|mvid|token|type|method|sig");

        Log($"[{DateTime.Now:HH:mm:ss}] MassDumper 启动 pid={Environment.ProcessId}");
        Log($"运行时 {Environment.Version} / {RuntimeInformation.FrameworkDescription}");
        Log($"GC={System.Runtime.GCSettings.IsServerGC}  64bit={Environment.Is64BitProcess}");

        // ---- 0. 预热：本工具自身 + 循环用到的框架路径全部预 JIT（顺序无关，仅为提速）----
        Warmup();

        // ---- 1. 等 Frida hook 就位（保证不漏编译事件）----
        var readyFile = Path.Combine(_outDir, "hook.ready");
        Log("等待 hook.ready …");
        for (int i = 0; i < 2400 && !File.Exists(readyFile); i++) Thread.Sleep(50);
        Log(File.Exists(readyFile) ? "hook 已就位" : "警告：hook.ready 未出现（Frida 侧可能没装上）");

        // ---- 2. 加载 Mass.*.dll（只喂托管 PE；原生 DLL 交给 LoadFrom 会 c0000005）----
        var cands = Directory.GetFiles(targetDir, "Mass.*.dll")
                    .Concat(Directory.GetFiles(targetDir, "Mass.*.dll.real"))
                    .OrderByDescending(x => Path.GetFileName(x).StartsWith("Mass.WinUI", StringComparison.OrdinalIgnoreCase))
                    .ThenBy(x => x, StringComparer.Ordinal)
                    .ToList();

        var asms = new List<Assembly>();
        foreach (var f in cands)
        {
            var n = Path.GetFileName(f);
            if (!IsManaged(f)) { Log($"跳过非托管 {n}"); continue; }
            try
            {
                var a = Assembly.LoadFrom(f);
                if (a.GetName().Name == "MassDumper") { Log($"跳过自身 {n}"); continue; }
                asms.Add(a);
                Log($"载入 {n}  身份={a.GetName().Name}  类型={SafeTypeCount(a)}  MVID={a.ManifestModule.ModuleVersionId:N}");
            }
            catch (Exception e) { Log($"载入失败 {n}: {e.GetType().Name} {e.Message}"); }
        }
        Log($"共加载 {asms.Count} 个程序集");

        // ---- 3. 强制执行每个模块的 <Module>.cctor ----
        // 保护器的 JIT 劫持是在模块初始化器里装的；LoadFrom + GetTypes() 都不会触发它。
        // 不跑这一步，PrepareMethod 编出来的只是落盘的抛错桩。
        foreach (var a in asms)
        {
            try { RuntimeHelpers.RunModuleConstructor(a.ManifestModule.ModuleHandle); Log($"模块初始化完成 {a.GetName().Name}"); }
            catch (Exception e) { Log($"模块初始化异常 {a.GetName().Name}: {e.GetType().Name} {e.Message}"); }
        }
        Log($"保护器运行时已载入 = {ProtectionLoaded()}");

        // ---- 4. 全量：建键表 + 强制 JIT ----
        _t0 = Stopwatch.GetTimestamp();
        var sw = Stopwatch.StartNew();
        foreach (var a in asms)
        {
            Log($"--- {a.GetName().Name} ---");
            foreach (var t in GetTypes(a)) WalkType(t, 0);
            _map.Flush();
            Log($"    累计 total={_total} 建表={_mapped} ok={_ok} fail={_fail} skip={_skip}  ({sw.Elapsed.TotalSeconds:F1}s)");
        }
        _map.Flush();
        _map.Dispose();

        Log($"===== 完成 total={_total} 建表={_mapped} ok={_ok} fail={_fail} skip={_skip} 用时 {sw.Elapsed.TotalSeconds:F1}s =====");
        foreach (var kv in FailKinds.OrderByDescending(k => k.Value).Take(15))
            Log($"   失败×{kv.Value,6}  {kv.Key}");
        File.WriteAllText(Path.Combine(_outDir, "done.txt"),
            $"total={_total}\nmapped={_mapped}\nok={_ok}\nfail={_fail}\nskip={_skip}\nseconds={sw.Elapsed.TotalSeconds:F1}\n");

        Thread.Sleep(2500);
        return 0;
    }

    // ------------------------------------------------------------------ 遍历

    private static void WalkType(Type t, int depth)
    {
        if (t == null || depth > 8) return;

        // 泛型类型定义 → 构造一个可用实例化体（约束求解），否则它的方法拿不到 MethodDesc 实例
        if (t.IsGenericTypeDefinition)
        {
            var inst = TryInstantiate(t);
            if (inst == null) { _skip++; return; }
            t = inst;
        }

        const BindingFlags F = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance
                             | BindingFlags.Static | BindingFlags.DeclaredOnly;
        MethodBase[] methods;
        try { methods = t.GetMethods(F).Cast<MethodBase>().Concat(t.GetConstructors(F)).ToArray(); }
        catch { methods = Array.Empty<MethodBase>(); }

        foreach (var m in methods) Handle(m);

        Type[] nested;
        try { nested = t.GetNestedTypes(BindingFlags.Public | BindingFlags.NonPublic); }
        catch { nested = Array.Empty<Type>(); }
        foreach (var n in nested) WalkType(n, depth + 1);
    }

    private static void Handle(MethodBase m)
    {
        _total++;

        // 泛型方法定义 → 约束求解后实例化；实例化体的 MethodHandle 才是 compileMethod 看到的那个
        MethodBase target = m;
        if (m.ContainsGenericParameters && m is MethodInfo mi && mi.IsGenericMethodDefinition)
        {
            var inst = TryInstantiateMethod(mi);
            if (inst == null) { _skip++; return; }
            target = inst;
        }

        // ---- 建键表：MethodHandle.Value == MethodDesc* ----
        long md;
        try { md = target.MethodHandle.Value.ToInt64(); }
        catch (Exception e) { Note("handle:" + e.GetType().Name); _skip++; return; }

        if (md != 0 && SeenMd.Add(md))
        {
            try
            {
                _map.WriteLine($"{md:x}|{target.Module.ModuleVersionId:N}|{target.MetadataToken:x8}|{target.DeclaringType?.FullName ?? "<global>"}|{target.Name}|{Describe(target)}");
                _mapped++;
            }
            catch (Exception e) { Note("map:" + e.GetType().Name); }
        }

        // ---- 强制 JIT ----
        try { RuntimeHelpers.PrepareMethod(target.MethodHandle); _ok++; }
        catch (Exception e) { Note(e); _fail++; }
    }

    // ------------------------------------------------------------------ 泛型约束求解

    /// <summary>给泛型参数挑一组满足约束的类型实参；失败返回 null。</summary>
    private static Type[]? SolveArgs(Type[] gps)
    {
        var cands = new List<Type>[gps.Length];
        for (int i = 0; i < gps.Length; i++)
        {
            var gp = gps[i];
            var list = new List<Type>();
            if (gp.GenericParameterAttributes.HasFlag(GenericParameterAttributes.NotNullableValueTypeConstraint))
            {
                list.Add(typeof(int));          // struct 约束
            }
            else
            {
                Type[] cs;
                try { cs = gp.GetGenericParameterConstraints(); } catch { cs = Array.Empty<Type>(); }
                foreach (var c in cs)
                {
                    if (c.IsGenericParameter) continue;
                    if (!c.IsInterface && c != typeof(ValueType) && c != typeof(Enum))
                        list.Add(c);             // 具体基类约束最省事
                }
                if (gp.GenericParameterAttributes.HasFlag(GenericParameterAttributes.ReferenceTypeConstraint))
                    list.Add(typeof(object));
                list.Add(typeof(object));         // 兜底
                list.Add(typeof(string));
                list.Add(typeof(int));
                // 接口约束：常见实现类兜底
                foreach (var c in cs)
                    if (c.IsInterface)
                    {
                        if (c == typeof(IDisposable)) list.Add(typeof(System.IO.MemoryStream));
                        else if (c == typeof(System.Collections.IEnumerable)) list.Add(typeof(int[]));
                        else if (c == typeof(IComparable)) list.Add(typeof(string));
                        else if (c == typeof(IEquatable<>).MakeGenericType(gp)) list.Add(typeof(string));
                    }
            }
            if (gp.GenericParameterAttributes.HasFlag(GenericParameterAttributes.DefaultConstructorConstraint))
                list.Insert(0, typeof(object));
            cands[i] = list.Distinct().ToList();
        }

        // 笛卡尔积，最多试 64 组
        var cur = new Type[gps.Length];
        return Search(cands, cur, 0, new int[1] { 64 });
    }

    private static Type[]? Search(List<Type>[] cands, Type[] cur, int i, int[] budget)
    {
        if (budget[0]-- <= 0) return null;
        if (i == cands.Length) return (Type[])cur.Clone();
        foreach (var c in cands[i])
        {
            cur[i] = c;
            var r = Search(cands, cur, i + 1, budget);
            if (r != null) return r;
        }
        return null;
    }

    private static Type? TryInstantiate(Type t)
    {
        var gps = t.GetGenericArguments();
        var args = SolveArgs(gps);
        if (args == null) return null;
        try { return t.MakeGenericType(args); } catch { }

        // 再退一步：全 object / 全 int
        foreach (var fallback in new[] { Enumerable.Repeat(typeof(object), gps.Length).ToArray(),
                                         Enumerable.Repeat(typeof(int), gps.Length).ToArray() })
        {
            try { return t.MakeGenericType(fallback); } catch { }
        }
        return null;
    }

    private static MethodInfo? TryInstantiateMethod(MethodInfo mi)
    {
        var gps = mi.GetGenericArguments();
        var args = SolveArgs(gps);
        if (args != null) { try { return mi.MakeGenericMethod(args); } catch { } }
        foreach (var fallback in new[] { Enumerable.Repeat(typeof(object), gps.Length).ToArray(),
                                         Enumerable.Repeat(typeof(int), gps.Length).ToArray() })
        {
            try { return mi.MakeGenericMethod(fallback); } catch { }
        }
        return null;
    }

    // ------------------------------------------------------------------ 预热

    private static void Warmup()
    {
        try
        {
            foreach (var t in GetTypes(typeof(Program).Assembly))
                foreach (var m in t.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance | BindingFlags.DeclaredOnly))
                    try { RuntimeHelpers.PrepareMethod(m.MethodHandle); } catch { }
        }
        catch { }

        try
        {
            var ab = AssemblyBuilder.DefineDynamicAssembly(new AssemblyName("WarmupDummy"), AssemblyBuilderAccess.Run);
            var mb = ab.DefineDynamicModule("WarmupDummy");
            for (int i = 0; i < 16; i++)
            {
                var tb = mb.DefineType("Warmup.T" + i, TypeAttributes.Public | TypeAttributes.Class);
                tb.DefineGenericParameters("T0", "T1");
                for (int j = 0; j < 8; j++)
                {
                    var m = tb.DefineMethod("M" + j, MethodAttributes.Public | MethodAttributes.Static, typeof(int), new[] { typeof(int), typeof(string) });
                    var il = m.GetILGenerator();
                    if (j % 4 == 0)
                    {
                        il.BeginExceptionBlock();
                        il.Emit(OpCodes.Ldarg_0); il.Emit(OpCodes.Conv_I8); il.Emit(OpCodes.Ldc_I4_1);
                        il.Emit(OpCodes.Add); il.Emit(OpCodes.Conv_I4); il.Emit(OpCodes.Pop);
                        il.BeginCatchBlock(typeof(Exception)); il.Emit(OpCodes.Pop); il.EndExceptionBlock();
                    }
                    il.Emit(OpCodes.Ldarg_0); il.Emit(OpCodes.Ret);
                }
                tb.CreateType();
            }
            foreach (var t in ab.GetTypes()) { try { WalkDry(t, 0); } catch { } }
        }
        catch { }
        GC.Collect(); GC.WaitForPendingFinalizers(); GC.Collect();
    }

    private static void WalkDry(Type t, int d)
    {
        if (t == null || d > 6) return;
        if (t.IsGenericTypeDefinition) { var i = TryInstantiate(t); if (i == null) return; t = i; }
        const BindingFlags F = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
        foreach (var m in t.GetMethods(F)) { try { RuntimeHelpers.PrepareMethod(m.MethodHandle); } catch { } }
        foreach (var n in t.GetNestedTypes(BindingFlags.Public | BindingFlags.NonPublic)) WalkDry(n, d + 1);
    }

    // ------------------------------------------------------------------ 工具

    private static bool ProtectionLoaded()
    {
        try
        {
            return Process.GetCurrentProcess().Modules.Cast<ProcessModule>()
                .Any(m => m.ModuleName.Contains("Mass.Runtime", StringComparison.OrdinalIgnoreCase));
        }
        catch { return false; }
    }

    private static bool IsManaged(string path)
    {
        try { using var fs = File.OpenRead(path); using var pe = new PEReader(fs); return pe.HasMetadata; }
        catch { return false; }
    }

    private static string Describe(MethodBase m)
    {
        try
        {
            if (m is MethodInfo mi)
                return mi.ReturnType.Name + " " + m.Name + "(" + string.Join(",", mi.GetParameters().Select(p => p.ParameterType.Name)) + ")";
            var ci = (ConstructorInfo)m;
            return "void .ctor(" + string.Join(",", ci.GetParameters().Select(p => p.ParameterType.Name)) + ")";
        }
        catch { return m.Name; }
    }

    private static IEnumerable<Type> GetTypes(Assembly a)
    {
        Type[] ts;
        try { ts = a.GetTypes(); }
        catch (ReflectionTypeLoadException e) { ts = e.Types.Where(x => x != null).ToArray()!; }
        catch { return Array.Empty<Type>(); }
        return ts;
    }

    private static int SafeTypeCount(Assembly a) { try { return a.GetTypes().Length; } catch { return -1; } }

    private static void Note(Exception e)
    {
        var k = e.GetType().Name + ": " + (e.Message ?? "");
        if (k.Length > 90) k = k.Substring(0, 90);
        FailKinds.TryGetValue(k, out var c);
        FailKinds[k] = c + 1;
    }

    private static void Note(string k) { FailKinds.TryGetValue(k, out var c); FailKinds[k] = c + 1; }

    private static void Log(string msg)
    {
        Console.WriteLine(msg);
        try { File.AppendAllText(Path.Combine(_outDir, "dumper.log"), msg + Environment.NewLine); } catch { }
    }
}
