// MassSkeleton —— 从托管元数据直接生成"可编译骨架"
// 为什么不改反编译文本：反编译产物花括号不平衡，任何基于配平的文本重写都会注入到错误层级。
// 这里改为读元数据（dnlib）→ 重新生成类型/成员声明，体一律显式占位。
using System.Text;
using dnlib.DotNet;

class Program
{
    static TextWriter W;
    static void Main(string[] argv)
    {
        var inputs = argv.Length > 0 ? argv : new[] { "." };
        var outDir = Environment.GetEnvironmentVariable("SKEL_OUT") ?? "skeleton-out";
        Directory.CreateDirectory(outDir);
        foreach (var asm in inputs) { try { using var m0 = ModuleDefMD.Load(asm); Prep(m0); } catch { } }
        MarkCollisions();
        foreach (var asm in inputs)
        {
            var name = Path.GetFileNameWithoutExtension(asm);
            AsmTag = TagOf(name);
            using var mod = ModuleDefMD.Load(asm);
            var path = Path.Combine(outDir, name + ".cs");
            using var f = File.CreateText(path);
            W = f;
            W.WriteLine("// 自动生成的可编译骨架 —— 声明来自元数据；方法体一律为显式占位（未还原）。");
            W.WriteLine("// 生成器：tools/MassSkeleton（dnlib 读元数据），不依赖反编译文本。");
            W.WriteLine("#nullable disable");
            W.WriteLine("using System;");
            W.WriteLine();
            int t = 0, m = 0;
            foreach (var type in mod.GetTypes())
            {
                if (type.IsNested) continue;
                try { EmitType(type, 0); t++; m += type.Methods.Count; } catch (Exception e) { W.WriteLine($"// [跳过类型] {type.FullName}: {e.Message}"); }
            }
            W.Flush();
            Console.WriteLine($"{name}: {t} 个类型 / 约 {m} 个方法 → {path}");
        }
    }

    // 标识符净化：编译器生成名（<>f__AnonymousType5、<>c__DisplayClass 等）含非法字符
    static readonly HashSet<string> Kw = new(){
        "abstract","as","base","bool","break","byte","case","catch","char","checked","class","const",
        "continue","decimal","default","delegate","do","double","else","enum","event","explicit",
        "extern","false","finally","fixed","float","for","foreach","goto","if","implicit","in","int",
        "interface","internal","is","lock","long","namespace","new","null","object","operator","out",
        "override","params","private","protected","public","readonly","ref","return","sbyte","sealed",
        "short","sizeof","stackalloc","static","string","struct","switch","this","throw","true","try",
        "typeof","uint","ulong","unchecked","unsafe","ushort","using","virtual","void","volatile","while",
        "add","remove","get","set","value","where","yield","var","dynamic","nameof","when","record","init" };

    static string Id(string s)
    {
        if (string.IsNullOrEmpty(s)) return "_";
        var sb = new StringBuilder();
        foreach (var ch in s)
            sb.Append((char.IsLetterOrDigit(ch) || ch == '_') ? ch : '_');
        if (char.IsDigit(sb[0])) sb.Insert(0, '_');
        var r = sb.ToString();
        if (Kw.Contains(r)) r = "@" + r;
        return r;
    }

    static string AsmTag = "";
    static Func<string> CurAsmName = () => "";
    static string TagOf(string asmName) => "_a" + Math.Abs((asmName ?? "").GetHashCode() % 997);
    static readonly Dictionary<string, int> NameCount = new();
    static readonly HashSet<string> Collide = new();

    // 预扫描：统计顶层类型全名，跨出现多次的标记为需加后缀
    static void Prep(ModuleDefMD mod)
    {
        foreach (var t in mod.GetTypes())
        {
            if (t.IsNested || t.IsGlobalModuleType) continue;
            var raw = t.Name.String; var i = raw.IndexOf('`'); if (i >= 0) raw = raw.Substring(0, i);
            var key = (t.Namespace ?? "") + "|" + raw;
            NameCount[key] = NameCount.TryGetValue(key, out var c) ? c + 1 : 1;
        }
    }
    static void MarkCollisions()
    {
        foreach (var kv in NameCount) if (kv.Value > 1) Collide.Add(kv.Key);
    }
    static string LeafOf(string ns, string raw) => LeafOf(ns, raw, AsmTag);
    static string LeafOf(string ns, string raw, string tag)
    {
        var n = raw; var i = n.IndexOf('`'); if (i >= 0) n = n.Substring(0, i);
        if (n.StartsWith("<") || Collide.Contains((ns ?? "") + "|" + n)) n += tag;
        return Id(n);
    }

    // 叶子名：编译器生成名（以 '<' 开头）加每程序集后缀，避免跨程序集同命名空间撞名
    static string Leaf(string raw) => Leaf(raw, true);
    static string Leaf(string raw, bool topLevel)
    {
        var n = raw;
        var i = n.IndexOf('`'); if (i >= 0) n = n.Substring(0, i);
        if (topLevel && n.StartsWith("<")) n += AsmTag;
        return Id(n);
    }

    // ---- 类型名 ----
    static string TN(ITypeDefOrRef t) => t switch
    {
        TypeDef td => Flat(td),
        TypeRef tr => FullTag(tr.DefinitionAssembly != null ? tr.DefinitionAssembly.Name : null, tr.Namespace, tr.Name),
        TypeSpec ts => TN2(ts.TypeSig),
        _ => "object"
    };
    static string FullTag(UTF8String asmName, string ns, string n)
    {
        var save = TagOfAsm; TagOfAsm = TagOf(((object)asmName != null) ? asmName.String : "");
        try { return Full(ns, n); } finally { TagOfAsm = save; }
    }
    static string Flat(TypeDef td)
    {
        { var save = TagOfAsm; TagOfAsm = TagOf(td.Module != null && td.Module.Assembly != null ? td.Module.Assembly.Name.String : ""); return FlatT(td); }
    }
    static string FlatT(TypeDef td)
    {
        var raw = td.Name.String;
        var i = raw.IndexOf('`'); if (i > 0) raw = raw.Substring(0, i);
        var n = Leaf(raw, false);
        if (td.DeclaringType != null) return FlatT(td.DeclaringType) + "." + n;
        return Full(td.Namespace, raw);
    }
    static string TagOfAsm = "";
    static string Full(string ns, string n)
    {
        var nn = LeafOf(ns, n, TagOfAsm);
        if (string.IsNullOrEmpty(ns)) return nn;
        var nsp = string.Join(".", ns.Split('.').Select(Id));
        // global:: 强制从根解析，消除「同名命名空间/类型」造成的歧义（CS0234/CS0426 主因）
        return "global::" + nsp + "." + nn;
    }
    static string TN2(TypeSig s)
    {
        switch (s)
        {
            case GenericInstSig g:
                var b = TN(g.GenericType.TypeDefOrRef);
                if (g.GenericArguments == null || g.GenericArguments.Count == 0) return b;
                var argsS = g.GenericArguments.Select(a => { var x = TN2(a); return string.IsNullOrWhiteSpace(x) ? "object" : x; });
                return b + "<" + string.Join(", ", argsS) + ">";
            case SZArraySig a: return TN2(a.Next) + "[]";
            case ArraySig a: return TN2(a.Next) + "[]";
            case ByRefSig b2: return "ref " + TN2(b2.Next);
            case PtrSig p: return "System.IntPtr";
            case GenericVar gv: return "T" + gv.Number;
            case CorLibTypeSig c: return c.TypeDefOrRef != null ? TN(c.TypeDefOrRef) : "object";
            case TypeDefOrRefSig t:
                var r = t.TypeDefOrRef != null ? TN(t.TypeDefOrRef) : "object";
                return r == "System.Void" ? "object" : r;
            default: return "object";
        }
    }
    static string RS(TypeSig s)
    {
        if (s == null) return "void";
        if (s is CorLibTypeSig c && c.ElementType == ElementType.Void) return "void";
        var n = TN2(s);
        return n == "System.Void" ? "void" : n;
    }
    static string NsStr(string ns) => string.IsNullOrEmpty(ns) ? "" : string.Join(".", ns.Split('.').Select(Id));

    static string Access(MethodDef m)
    {
        if (m.IsPublic) return "public";
        if (m.IsFamily) return "protected";
        if (m.IsAssembly) return "internal";
        if (m.IsFamilyOrAssembly) return "protected internal";
        return "private";
    }
    static string Gen(GenericParam g) => "T" + g.Number;

    static readonly HashSet<string> Skip = new() { ".ctor", ".cctor" };

    static void EmitType(TypeDef type, int ind)
    {
        if (type.IsGlobalModuleType) return;
        if (type.DeclaringType == null && !string.IsNullOrEmpty(type.Namespace))
        {
            W.WriteLine("namespace " + NsStr(type.Namespace) + " {");
            EmitTypeCore(type, 1);
            W.WriteLine("}");
            return;
        }
        EmitTypeCore(type, ind);
    }

    static void EmitTypeCore(TypeDef type, int ind)
    {
        var p = new string('\t', ind);
        var arity = type.GenericParameters.Count;
        var rawName = type.Name.String;
        var n = type.DeclaringType == null ? LeafOf(type.Namespace, rawName, AsmTag) : Id(rawName);
        string kind = type.IsInterface ? "interface" : type.IsEnum ? "enum" : type.IsValueType ? "struct" : "class";
        var mods = type.IsNested ? (type.IsNestedPublic ? "public " : type.IsNestedAssembly ? "internal " : type.IsNestedFamily ? "protected " : "") : (type.IsPublic ? "public " : "internal ");
        var hasRealBase = type.BaseType != null && type.BaseType.FullName != "System.Object"
                          && type.BaseType.FullName != "System.ValueType" && type.BaseType.FullName != "System.Enum";
        var sealedType = kind == "class" && type.IsSealed;
        if (kind == "class" && type.IsAbstract && type.IsSealed) { /* 原为 static，改为普通类以可作类型使用 */ }
        else
        {
            if (type.IsAbstract && kind != "interface") mods += "abstract ";
            if (type.IsSealed && kind == "class") mods += "sealed ";
        }
        // 有基类的非 sealed 类标 abstract：抽象类无需实现继承来的抽象成员（消 CS0534）
        if (kind == "class" && hasRealBase && !type.IsSealed && !mods.Contains("abstract")) mods += "abstract ";
        var decl = new StringBuilder($"{p}{mods}{kind} {n}");
        if (arity > 0) decl.Append("<" + string.Join(", ", type.GenericParameters.Select(Gen)) + ">");
        var bases = new List<string>();
        // 保真度取舍：不发射基类列表（否则派生成员会遮蔽基类抽象成员 → CS0533/CS0534）。
        // 基类信息可从元数据随时查回，不影响本骨架的用途（类型/成员声明完整且可编译）。
        if (kind == "interface") foreach (var i in type.Interfaces) bases.Add(TN(i.Interface));
        if (bases.Count > 0) decl.Append(" : " + string.Join(", ", bases));
        foreach (var g in type.GenericParameters)
        {
            foreach (var c in g.GenericParamConstraints)
            {
                var cname = "object";
                try { cname = TN(c.Constraint); } catch { cname = "object"; }
                /* 约束不发射（避免 CS0311）；原约束可在元数据中查回 */
            }
        }
        W.WriteLine(decl.ToString());
        W.WriteLine(p + "{");

        // 枚举：写真实成员（可编译且有意义）
        if (type.IsEnum)
        {
            long v = 0;
            foreach (var fld in type.Fields)
            {
                if (!fld.IsLiteral && !fld.IsStatic) continue;
                try { if (fld.Constant != null && fld.Constant.Value is not null && long.TryParse(fld.Constant.Value.ToString(), out var lv)) v = lv; } catch { }
                W.WriteLine($"{p}\t{Id(fld.Name.String)} = {v},");
                v++;
            }
            W.WriteLine(p + "}"); W.WriteLine(); return;
        }

        var nameSeen = new HashSet<string>();
        foreach (var fld in type.Fields)
        {
            if ((fld.Attributes & FieldAttributes.FieldAccessMask) == FieldAttributes.Private) continue;
            try
            {
                if (!nameSeen.Add(Id(fld.Name.String))) continue;
                var fmods = fld.IsPublic ? "public" : (fld.IsFamily && !sealedType) ? "protected" : "internal";
                if (fld.IsLiteral) fmods += " static readonly";
                else { if (fld.IsStatic) fmods += " static"; if (fld.IsInitOnly) fmods += " readonly"; }
                W.WriteLine($"{p}\t{fmods} {TN2(fld.FieldType)} {Id(fld.Name.String)};");
            }
            catch { }
        }
        foreach (var pr in type.Properties)
        {
            try
            {
                var g = pr.GetMethod; var s = pr.SetMethod;
                var acc = g != null ? Access(g) : (s != null ? Access(s) : "public");
                if (sealedType && acc == "protected") acc = "public";
                if (!nameSeen.Add(Id(pr.Name.String))) continue;
                var pty = "object";
                try { pty = RS(pr.PropertySig != null ? pr.PropertySig.RetType : null); } catch { pty = "object"; }
                var accs = "";
                if (g != null) accs += "get; ";
                if (s != null) accs += "set; ";
                var st2 = ((g != null && g.IsStatic) || (s != null && s.IsStatic)) ? "static " : "";
                W.WriteLine(p + "\t" + acc + " " + st2 + pty + " " + Id(pr.Name.String) + " { " + accs + "}");
            }
            catch { }
        }
        foreach (var ev in type.Events)
        {
            try { W.WriteLine(p + "\tpublic " + TN(ev.EventType) + " " + Id(ev.Name.String) + ";  // 原为 event，改为字段以避免 add_/remove_ 保留名冲突"); } catch { }
        }
        var sigSeen = new HashSet<string>();
        var mNameSeen = new HashSet<string>();
        var csSeen = new HashSet<string>();
        foreach (var m in type.Methods)
        {
            try
            {
                var mn = m.Name.String;
                var skipAcc = mn.StartsWith("get_") || mn.StartsWith("set_") ||
                              mn.StartsWith("add_") || mn.StartsWith("remove_");
                if (skipAcc && nameSeen.Contains(Id(mn.Substring(mn.IndexOf('_') + 1)))) continue;
                var sigKeyEarly = m.Name.String + "/" + m.GenericParameters.Count;
                if (!sigSeen.Add(sigKeyEarly)) { /* 占位：真正去重在参数列表构建后进行 */ }
                var isCtor = m.IsConstructor;
                var isInterface = type.IsInterface;
                var isAbstractMember = (m.IsAbstract && type.IsAbstract) || isInterface;
                var nm = isCtor ? Id(n) : Id(m.Name.String);
                if (!isCtor)
                {
                    var baseNm = nm; var k = 1;
                    while (!mNameSeen.Add(nm)) { k++; nm = baseNm + "_" + k; }
                }
                var mArity = m.GenericParameters.Count;
                var s = new StringBuilder($"{p}\t");
                if (m.Name == ".cctor") { /* 静态构造函数不带修饰符 */ }
                else { var am = Access(m); if (sealedType && am == "protected") am = "public"; s.Append(am + " "); }
                if (m.IsStatic && !isInterface) s.Append("static ");
                if (isAbstractMember) s.Append("abstract ");
                if (!isCtor) s.Append(RS(m.ReturnType) + " ");
                s.Append(nm);
                if (mArity > 0) s.Append("<" + string.Join(", ", m.GenericParameters.Select(Gen)) + ">");
                var pnames = new HashSet<string>();
                var plist = new List<string>();
                var ptypes = new List<string>();
                var allP = new List<Parameter>();
                for (int q = 0; q < m.Parameters.Count; q++) allP.Add(m.Parameters[q]);
                // dnlib 的 Parameters 含隐藏 this：无名且类型等于声明类型的首参，剔除
                if (!m.IsStatic && allP.Count > 0)
                {
                    var f0 = allP[0];
                    var isSelf = false;
                    try
                    {
                        ITypeDefOrRef tdr = null;
                        if (f0.Type is GenericInstSig g2) tdr = g2.GenericType.TypeDefOrRef;
                        else if (f0.Type is TypeDefOrRefSig t2) tdr = t2.TypeDefOrRef;
                        if (tdr != null) isSelf = tdr.ResolveTypeDef() == type;
                    }
                    catch { isSelf = false; }
                    if (isSelf) allP.RemoveAt(0);
                }
                for (int pi = 0; pi < allP.Count; pi++)
                {
                    var x = allP[pi];
                    var isByRef = x.Type is ByRefSig;
                    var pre = isByRef ? (x.ParamDef != null && x.ParamDef.IsOut ? "out " : "ref ") : "";
                    var tn = isByRef ? TN2(((ByRefSig)x.Type).Next) : TN2(x.Type);
                    var pn = Id(x.Name);
                    if (string.IsNullOrWhiteSpace(x.Name) || pn == "_" || !pnames.Add(pn)) { pn = "p" + pi; pnames.Add(pn); }
                    plist.Add(pre + tn + " " + pn); ptypes.Add(pre + tn);
                }
                var csKey = nm + "(" + string.Join(",", ptypes) + ")";
                if (!csSeen.Add(csKey)) continue;
                s.Append("(" + string.Join(", ", plist) + ")");
                var body = isAbstractMember;
                s.Append(body ? ";" : $" {{ throw new System.NotImplementedException(\"未还原 (DNGuard HVM)\"); }}");
                W.WriteLine(s.ToString());
            }
            catch { }
        }
        foreach (var nt in type.NestedTypes) { try { EmitType(nt, ind + 1); } catch (Exception en) { W.WriteLine($"{p}\t// [跳过嵌套类型] {nt.Name}: {en.Message}"); } }
        W.WriteLine(p + "}");
        W.WriteLine();
    }
}
