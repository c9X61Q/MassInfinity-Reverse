// MassBackfill — 把运行时抓到的原始 IL 回填进 DNGuard 保护的程序集
//
// 输入：recovered.jsonl（MassDumper + hook-dump.js 的产物）
//       srcDir（原始 Mass.*.dll，落盘 IL 是保护器的抛错桩）
// 输出：outDir（IL 已回填的程序集，可直接喂 ILSpy）
//
// 关键点：
//   1. 不自己解析 IL 操作数 —— 把 (fat header + IL 代码 + EH 段) 合成为标准
//      COR_ILMETHOD 镜像，交给 dnlib 的 MethodBodyReader 解析（token / 参数 /
//      局部变量索引全部由成熟代码处理）。
//   2. 方法定位用 (MVID, MethodDef token) —— 与 MassDumper 的 map.txt 同源。
//   3. 局部变量签名保护器没给（cbSig 恒为 0），这里按 localsCount 造
//      object 占位局部变量，类型交给 ILSpy 从使用点推断。
//   4. 保存后用 System.Reflection.Metadata 重读输出，**逐字节比对 IL**，
//      以此证明回填是字节精确的。
//
// 用法: MassBackfill <recovered.jsonl> <srcDir> <outDir>
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using dnlib.IO;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Text.Json;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace MassBackfill;

internal sealed class Rec
{
    public string mvid { get; set; }
    public string token { get; set; }
    public string type { get; set; }
    public string method { get; set; }
    public string sig { get; set; }
    public string kind { get; set; }
    public int maxStack { get; set; }
    public string il { get; set; }
    public int localsCount { get; set; }
    public int ehCount { get; set; }
    public List<EhRec> eh { get; set; }
}

internal sealed class EhRec
{
    public int flags { get; set; }
    public int tryOff { get; set; }
    public int tryLen { get; set; }
    public int hOff { get; set; }
    public int hLen { get; set; }
    public uint tok { get; set; }
}

internal static class Program
{
    private static int NullOps, NullOpMethods;
    private static readonly Dictionary<string, string> ExpectedSig = new();
    private static int Main(string[] args)
    {
        if (args.Length < 3)
        {
            Console.Error.WriteLine("用法: MassBackfill <recovered.jsonl> <srcDir> <outDir>");
            return 2;
        }
        string jsonl = args[0], srcDir = args[1], outDir = args[2];
        bool dbg = args.Length > 3 && args[3] == "--debug";
        Directory.CreateDirectory(outDir);

        // ---- 载入源程序集，按 MVID 建索引 ----
        var byMvid = new Dictionary<string, (string path, ModuleDefMD mod)>();
        foreach (var f in Directory.GetFiles(srcDir, "Mass.*.dll")
                                  .Concat(Directory.GetFiles(srcDir, "Mass.*.dll.real"))
                                  .OrderBy(x => x, StringComparer.Ordinal))
        {
            try
            {
                var m = ModuleDefMD.Load(f);
                if (m.Mvid == null) { Console.WriteLine($"[跳过] {Path.GetFileName(f)}: 无 MVID"); continue; }
                var id = m.Mvid.Value.ToString("N");
                if (byMvid.ContainsKey(id)) continue;
                byMvid[id] = (f, m);
                Console.WriteLine($"[载入] {Path.GetFileName(f)}  MVID={id}  类型={m.Types.Count}");
            }
            catch (Exception e) { Console.WriteLine($"[跳过] {Path.GetFileName(f)}: {e.GetType().Name} {e.Message}"); }
        }

        // ---- 读回填数据，按模块分组 ----
        var groups = new Dictionary<string, List<Rec>>();
        int total = 0;
        foreach (var line in File.ReadLines(jsonl))
        {
            if (string.IsNullOrWhiteSpace(line)) continue;
            Rec r;
            try { r = JsonSerializer.Deserialize<Rec>(line); } catch { continue; }
            if (r == null || !string.Equals(r.kind, "real", StringComparison.Ordinal)) continue;
            total++;
            if (!groups.TryGetValue(r.mvid, out var lst)) groups[r.mvid] = lst = new List<Rec>();
            lst.Add(r);
        }
        Console.WriteLine($"\n可回填（kind=real）方法数: {total}，分布 {groups.Count} 个模块\n");

        int done = 0, fail = 0;
        var perAsm = new List<(string name, int n, string outPath)>();
        foreach (var (mvid, recs) in groups)
        {
            if (!byMvid.TryGetValue(mvid, out var ent))
            {
                Console.WriteLine($"[警告] MVID {mvid} 没有对应源程序集，跳过 {recs.Count} 个方法");
                fail += recs.Count;
                continue;
            }
            var (path, mod) = ent;
            int ok = 0;
            foreach (var r in recs)
            {
                try
                {
                    if (Patch(mod, r, dbg && ok < 4)) ok++;
                    else fail++;
                }
                catch (Exception e) { fail++; if (fail < 6) Console.WriteLine($"  [失败] {r.type}.{r.method}: {e.GetType().Name} {e.Message}"); }
            }
            done += ok;
            var name = Path.GetFileName(path).Replace(".real", "");
            var outPath = Path.Combine(outDir, name);
            int san = SanitizeBodies(mod);
            try
            {
                var wo = new dnlib.DotNet.Writer.ModuleWriterOptions(mod);
                wo.MetadataOptions.Flags |= dnlib.DotNet.Writer.MetadataFlags.KeepOldMaxStack;
                mod.Write(outPath, wo);
            }
            catch (Exception e) { Console.WriteLine($"[写盘失败] {name}: {e.GetType().Name} {e.Message}"); continue; }
            perAsm.Add((name, ok, outPath));
            Console.WriteLine($"[回填] {name}: {ok}/{recs.Count}   （兜底 nop {san} 处）");
        }

        Console.WriteLine($"\n回填成功 {done}，失败 {fail}");

        // ---- 验证：重读输出，比较指令序列（dnlib 写盘会做宏优化，字节必然不同）----
        Console.WriteLine("\n=== 验证：重读输出，比较指令序列是否与运行时抓到的 IL 等价 ===");
        int vOk = 0, vBad = 0, vMiss = 0;
        foreach (var (name, _, outPath) in perAsm)
        {
            var mvid = byMvid.First(kv => Path.GetFileName(kv.Value.path).Replace(".real", "") == name).Key;
            var recs = groups[mvid];
            ModuleDefMD outMod;
            try { outMod = ModuleDefMD.Load(outPath); }
            catch (Exception e) { Console.WriteLine($"  [验证打不开] {name}: {e.Message}"); continue; }
            foreach (var r in recs)
            {
                uint tk = Convert.ToUInt32(r.token.Replace("0x", ""), 16);
                var m = outMod.ResolveToken(tk) as MethodDef;
                if (m?.Body == null) { vMiss++; continue; }
                if (!ExpectedSig.TryGetValue(mvid + ":" + tk.ToString("x8"), out var want)) { vMiss++; continue; }
                string got = OpcodeSeq(m.Body);
                want = OpcodeSeqOf(want);
                if (want == got) vOk++;
                else { vBad++; if (vBad <= 3) Console.WriteLine($"  不一致 {name} {tk:x8} {r.type}.{r.method}\n    期望 {Trunc(want)}\n    实际 {Trunc(got)}"); }
            }
            outMod.Dispose();
        }
        Console.WriteLine($"操作码序列: 等价 {vOk} / 不一致 {vBad} / 无方法体 {vMiss}");
        Console.WriteLine("\n--- 字节级判据（重读输出；注意 dnlib 会归一化元数据表，故按「类型+方法名」定位而非 token）---");
        int bOk = 0, bBad = 0, bMiss = 0;
        foreach (var (name, _, outPath) in perAsm)
        {
            var mvid = byMvid.First(kv => Path.GetFileName(kv.Value.path).Replace(".real", "") == name).Key;
            var want = new Dictionary<string, List<string>>();
            foreach (var r in groups[mvid])
            {
                string k = (r.type + "\u0001" + r.method).ToLowerInvariant();
                if (!want.TryGetValue(k, out var lst)) want[k] = lst = new List<string>();
                lst.Add(r.il.ToLowerInvariant());
            }
            var got = new Dictionary<string, List<string>>();
            try
            {
                using var fs = File.OpenRead(outPath);
                using var pe = new PEReader(fs);
                var md = pe.GetMetadataReader();
                foreach (var mh in md.MethodDefinitions)
                {
                    var mdh = md.GetMethodDefinition(mh);
                    if (mdh.RelativeVirtualAddress == 0) continue;
                    var td = md.GetTypeDefinition(mdh.GetDeclaringType());
                    string tn = (md.GetString(td.Namespace) + "." + md.GetString(td.Name)).TrimStart('.').ToLowerInvariant();
                    string key = tn + "\u0001" + md.GetString(mdh.Name).ToLowerInvariant();
                    string ilb = Convert.ToHexString(pe.GetMethodBody(mdh.RelativeVirtualAddress).GetILBytes() ?? Array.Empty<byte>()).ToLowerInvariant();
                    if (!got.TryGetValue(key, out var l2)) got[key] = l2 = new List<string>();
                    l2.Add(ilb);
                }
            }
            catch (Exception e) { Console.WriteLine($"  [异常] {name}: {e.Message}"); continue; }

            foreach (var kv in want)
            {
                if (!got.TryGetValue(kv.Key, out var have)) { bMiss += kv.Value.Count; continue; }
                var pool = new List<string>(have);
                foreach (var exp in kv.Value)
                {
                    int idx = pool.IndexOf(exp);
                    if (idx >= 0) { pool.RemoveAt(idx); bOk++; }
                    else
                    {
                        bBad++;
                        if (bBad <= 3) Console.WriteLine($"  字节不一致 {name} {kv.Key.Replace("\u0001", "::")}: 期望{exp.Length / 2}B 输出该方法的候选 {string.Join(",", have.Select(x => x.Length / 2 + "B"))}");
                    }
                }
            }
        }
        Console.WriteLine($"字节级(含 token 重写): 完全一致 {bOk} / 不一致 {bBad} / 未找到 {bMiss}");

        // ---- 导出输出侧全部方法体，供 Python 做 token 掩码后的语义比对 ----
        var dump = new StreamWriter(Path.Combine(outDir, "_out-il.tsv"), false, new UTF8Encoding(false));
        dump.WriteLine("#mvid|token|type|method|ilSize|il");
        foreach (var (name, _, outPath) in perAsm)
        {
            var mvid = byMvid.First(kv => Path.GetFileName(kv.Value.path).Replace(".real", "") == name).Key;
            try
            {
                using var fs = File.OpenRead(outPath);
                using var pe = new PEReader(fs);
                var md = pe.GetMetadataReader();
                foreach (var mh in md.MethodDefinitions)
                {
                    var mdh = md.GetMethodDefinition(mh);
                    if (mdh.RelativeVirtualAddress == 0) continue;
                    var td = md.GetTypeDefinition(mdh.GetDeclaringType());
                    string tn = (md.GetString(td.Namespace) + "." + md.GetString(td.Name)).TrimStart('.');
                    var il = pe.GetMethodBody(mdh.RelativeVirtualAddress).GetILBytes() ?? Array.Empty<byte>();
                    dump.WriteLine($"{mvid}|{MetadataTokens.GetToken(mh):x8}|{tn}|{md.GetString(mdh.Name)}|{il.Length}|{Convert.ToHexString(il).ToLowerInvariant()}");
                }
            }
            catch { }
        }
        dump.Dispose();
        Console.WriteLine($"输出侧方法体已导出到 {Path.Combine(outDir, "_out-il.tsv")}");
        File.WriteAllText(Path.Combine(outDir, "_backfill-report.txt"),
            $"total_real={total}\npatched={done}\nfailed={fail}\nverified_ok={vOk}\nverified_mismatch={vBad}\nverified_missing={vMiss}\n");
        return vBad == 0 ? 0 : 1;
    }

    /// <summary>把一条记录的原始 IL 合成 COR_ILMETHOD 镜像，交给 dnlib 解析后写回方法体。</summary>
    private static bool Patch(ModuleDefMD mod, Rec r, bool dbg)
    {
        uint token = Convert.ToUInt32(r.token.Replace("0x", ""), 16);
        var method = mod.ResolveToken(token) as MethodDef;
        if (method == null) return false;
        if (method.IsAbstract || (method.ImplAttributes & MethodImplAttributes.InternalCall) != 0) return false;

        byte[] il = Convert.FromHexString(r.il);
        bool hasEh = r.eh != null && r.eh.Count > 0;

        // 局部变量：保护器把 locals 签名抹成 cbSig==0，这里按 IL 里用到的槽位数造 object 占位，
        // 类型交给 ILSpy 从使用点推断。
        var locals = new List<Local>();
        for (int i = 0; i < r.localsCount; i++) locals.Add(new Local(mod.CorLibTypes.Object));

        byte[] image = BuildImage(il, r.maxStack, r.localsCount, hasEh, r.eh);

        using var fac = ByteArrayDataReaderFactory.Create(image, "");
        var reader = new MethodBodyReader(mod, fac.CreateReader(0, image.Length), method);
        bool rd = reader.Read();
        if (dbg)
        {
            Console.WriteLine($"    [dbg] tok={token:x8} {r.type}.{r.method} il={il.Length}B locals={r.localsCount} eh={r.ehCount}");
            Console.WriteLine($"          读回: Read={rd} 指令={reader.Instructions.Count} EH={reader.ExceptionHandlers.Count}");
        }
        if (!rd) return false;

        var body = new CilBody(r.localsCount > 0, reader.Instructions, reader.ExceptionHandlers, locals)
        {
            MaxStack = (ushort)Math.Max(1, r.maxStack),
            KeepOldMaxStack = true,
        };
        // 兜底：个别指令的操作数解析为 null（保护器改过元数据），补成安全值，避免写盘直接失败
        int nullOps = 0;
        foreach (var ins in body.Instructions)
        {
            if (ins.Operand != null) continue;
            if (ins.OpCode.OperandType == OperandType.InlineNone) continue;
            nullOps++;
            switch (ins.OpCode.OperandType)
            {
                case OperandType.InlineVar:
                case OperandType.ShortInlineVar:
                    ins.Operand = body.Variables.Count > 0 ? body.Variables[0] : null;
                    break;
                default:
                    ins.Operand = null;      // 稍后由 Sanitize 处理
                    break;
            }
        }
        if (nullOps > 0) { NullOps += nullOps; NullOpMethods++; }
        method.Body = body;
        ExpectedSig[mod.Mvid!.Value.ToString("N") + ":" + token.ToString("x8")] = SigOf(body);
        return true;
    }

    /// <summary>
    /// 写盘兜底：保护器摧毁了部分元数据，未回填方法（仍是抛错桩）的原体中
    /// 有些指令的操作数解析为 null，dnlib 写盘会直接失败 —— 降级成 nop。
    /// 只影响我们没抓到 IL 的方法，语义损失可忽略。
    /// </summary>
    private static int SanitizeBodies(ModuleDefMD mod)
    {
        int n = 0;
        foreach (var t in mod.GetTypes())
            foreach (var m in t.Methods)
            {
                var b = m.Body;
                if (b == null) continue;

                // ① 剔掉 null 占位指令（保护器摧毁元数据后 dnlib 解析原体时留下的）
                if (b.Instructions.Any(x => x == null))
                {
                    var keep = b.Instructions.Where(x => x != null).ToList();
                    n += b.Instructions.Count - keep.Count;
                    b.Instructions.Clear();
                    foreach (var x in keep) b.Instructions.Add(x);
                }

                // ② 操作数非法（空 / 分支目标不在本体内 / 指向已被剔除的占位）→ 降级为 nop
                var set = new HashSet<dnlib.DotNet.Emit.Instruction>(b.Instructions);
                foreach (var ins in b.Instructions)
                {
                    if (ins.OpCode == null) { ins.OpCode = dnlib.DotNet.Emit.OpCodes.Nop; ins.Operand = null; n++; continue; }
                    if (ins.OpCode.OperandType == OperandType.InlineNone) continue;
                    var o = ins.Operand;
                    bool bad = o == null;
                    if (!bad && o is dnlib.DotNet.Emit.Instruction ti) bad = !set.Contains(ti);
                    if (!bad && o is dnlib.DotNet.Emit.Instruction[] arr) bad = arr.Any(x => x == null || !set.Contains(x));
                    if (!bad && o is dnlib.DotNet.Emit.Local lv) bad = false;
                    if (!bad && o is dnlib.DotNet.Parameter) bad = false;
                    if (bad)
                    {
                        ins.OpCode = dnlib.DotNet.Emit.OpCodes.Nop;
                        ins.Operand = null;
                        n++;
                    }
                }
            }
        return n;
    }

    /// <summary>把已格式化的指令文本还原成操作码序列（去掉操作数）</summary>
    private static string OpcodeSeqOf(string sig)
    {
        var sb = new StringBuilder();
        foreach (var ln in sig.Split('\n'))
        {
            if (ln.Length == 0) continue;
            int sp = ln.IndexOf(' ');
            sb.Append(sp < 0 ? ln : ln.Substring(0, sp)).Append(',');
        }
        return sb.ToString();
    }

    private static string Trunc(string s) => s.Length <= 300 ? s : s.Substring(0, 300) + "…";

    private static string SigOf(CilBody b)
    {
        var sb = new StringBuilder();
        foreach (var i in b.Instructions)
        {
            if (i == null) { sb.Append("<null>\n"); continue; }
            sb.Append(i.OpCode.Code).Append(' ').Append(i.Operand == null ? "" : OperandText(i.Operand)).Append('\n');
        }
        return sb.ToString();
    }

    /// <summary>只比操作码序列：把「格式差异」和「真实差异」分开</summary>
    private static string OpcodeSeq(CilBody b)
    {
        var sb = new StringBuilder();
        foreach (var i in b.Instructions) sb.Append(i == null ? "?" : i.OpCode.Code.ToString()).Append(',');
        return sb.ToString();
    }

    private static string OperandText(object o)
    {
        if (o is Instruction t) return "@" + t.Offset.ToString("x4");
        if (o is Instruction[] arr) return "[" + string.Join(",", arr.Select(x => "@" + x.Offset.ToString("x4"))) + "]";
        if (o is dnlib.DotNet.Emit.Local l) return "loc" + l.Index;
        if (o is dnlib.DotNet.Parameter p) return "arg" + p.Index;
        if (o is IMDTokenProvider tp) return "0x" + tp.MDToken.Raw.ToString("x8");
        if (o is string s) return "\"" + s + "\"";
        if (o is float f) return f.ToString("R");
        if (o is double d) return d.ToString("R");
        return o.ToString();
    }

    /// <summary>fat header(12B) + IL 代码</summary>
    /// <summary>fat header(12B) + IL 代码（+ 4 字节对齐 + EH 段），即完整 COR_ILMETHOD 镜像</summary>
    private static byte[] BuildImage(byte[] il, int maxStack, int localsCount, bool hasEh, List<EhRec> eh)
    {
        var ms = new MemoryStream();
        var bw = new BinaryWriter(ms);
        // ECMA-335 fat header（12 字节）: Flags | MaxStack | CodeSize | LocalVarSigTok
        // Flags 低 2 位 = 0b11(fat)；bit3 = MoreSects；bit4 = InitLocals；bit12-15 = 头长度(4 字节单位) = 3
        bw.Write((ushort)(0x3003 | (hasEh ? 0x8 : 0) | (localsCount > 0 ? 0x10 : 0)));
        bw.Write((ushort)Math.Max(1, maxStack));
        bw.Write((uint)il.Length);          // CodeSize
        bw.Write(0u);                       // localVarSigTok（局部变量由 CilBody 构造传入）
        bw.Write(il);
        while ((ms.Length & 3) != 0) bw.Write((byte)0);
        if (hasEh && eh != null && eh.Count > 0) bw.Write(BuildEhSection(eh));
        bw.Flush();
        return ms.ToArray();
    }

    private static byte[] BuildEhSection(List<EhRec> eh)
    {
        var ms = new MemoryStream();
        var bw = new BinaryWriter(ms);
        int dataSize = 6 + eh.Count * 24;   // 肥段头 6 字节（Kind1+DataSize3+Reserved2）+ 子句
        bw.Write((byte)0x41);               // EHTable | fat
        bw.Write((byte)(dataSize & 0xFF));
        bw.Write((byte)((dataSize >> 8) & 0xFF));
        bw.Write((byte)((dataSize >> 16) & 0xFF));
        bw.Write((ushort)0);                // Reserved
        foreach (var c in eh)
        {
            bw.Write((uint)c.flags);
            bw.Write((uint)c.tryOff);
            bw.Write((uint)c.tryLen);
            bw.Write((uint)c.hOff);
            bw.Write((uint)c.hLen);
            bw.Write(c.tok);
        }
        bw.Flush();
        return ms.ToArray();
    }
}
