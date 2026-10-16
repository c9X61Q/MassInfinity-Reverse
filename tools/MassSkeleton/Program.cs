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
        foreach (var asm in inputs)
        {
            var name = Path.GetFileNameWithoutExtension(asm);
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

    // ---- 类型名 ----
    static string TN(ITypeDefOrRef t) => t switch
    {
        TypeDef td => Flat(td),
        TypeRef tr => Full(tr.Namespace, tr.Name),
        TypeSpec ts => TN2(ts.TypeSig),
        _ => "object"
    };
    static string Flat(TypeDef td)
    {
        var raw = td.Name.String;
        var i = raw.IndexOf('`'); if (i > 0) raw = raw.Substring(0, i);
        var n = Id(raw);
        if (td.DeclaringType != null) return Flat(td.DeclaringType) + "." + n;
        return Full(td.Namespace, raw);
    }
    static string Full(string ns, string n)
    {
        var i = n.IndexOf('`'); if (i > 0) n = n.Substring(0, i);
        var parts = n.Replace('/', '.').Split('.').Select(Id);
        var nn = string.Join(".", parts);
        if (string.IsNullOrEmpty(ns)) return nn;
        var nsp = string.Join(".", ns.Split('.').Select(Id));
        return nsp + "." + nn;
    }
    static string TN2(TypeSig s)
    {
        switch (s)
        {
            case GenericInstSig g:
                var b = TN(g.GenericType.TypeDefOrRef);
                return b + "<" + string.Join(", ", g.GenericArguments.Select(a => TN2(a))) + ">";
            case SZArraySig a: return TN2(a.Next) + "[]";
            case ArraySig a: return TN2(a.Next) + "[]";
            case ByRefSig b2: return "ref " + TN2(b2.Next);
            case PtrSig p: return TN2(p.Next) + "*";
            case GenericVar gv: return "T" + gv.Number;
            case CorLibTypeSig c: return c.TypeDefOrRef != null ? TN(c.TypeDefOrRef) : "object";
            case TypeDefOrRefSig t: return t.TypeDefOrRef != null ? TN(t.TypeDefOrRef) : "object";
            default: return "object";
        }
    }
    static string RS(TypeSig s) => s == null ? "void" : TN2(s);

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
        var p = new string('\t', ind);
        if (type.IsGlobalModuleType) return;
        var arity = type.GenericParameters.Count;
        var rawName = type.Name.String;
        if (arity > 0) { var bi = rawName.IndexOf('`'); if (bi > 0) rawName = rawName.Substring(0, bi); }
        var n = Id(rawName);
        string kind = type.IsInterface ? "interface" : type.IsEnum ? "enum" : type.IsValueType ? "struct" : "class";
        var mods = type.IsNested ? (type.IsNestedPublic ? "public " : type.IsNestedAssembly ? "internal " : type.IsNestedFamily ? "protected " : "") : (type.IsPublic ? "public " : "internal ");
        if (kind == "class" && type.IsAbstract && type.IsSealed) mods += "static ";
        else { if (type.IsAbstract && kind != "interface") mods += "abstract "; if (type.IsSealed && kind == "class") mods += "sealed "; }
        var decl = new StringBuilder($"{p}{mods}{kind} {n}");
        if (arity > 0) decl.Append("<" + string.Join(", ", type.GenericParameters.Select(Gen)) + ">");
        var bases = new List<string>();
        if (type.BaseType != null && type.BaseType.FullName != "System.Object" && type.BaseType.FullName != "System.ValueType" && type.BaseType.FullName != "System.Enum")
            bases.Add(TN(type.BaseType));
        foreach (var i in type.Interfaces) bases.Add(TN(i.Interface));
        if (bases.Count > 0) decl.Append(" : " + string.Join(", ", bases));
        foreach (var g in type.GenericParameters)
        {
            foreach (var c in g.GenericParamConstraints)
            {
                var cname = "object";
                try { cname = TN(c.Constraint); } catch { cname = "object"; }
                decl.Append(" where " + Gen(g) + " : " + cname);
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

        foreach (var fld in type.Fields)
        {
            if ((fld.Attributes & FieldAttributes.FieldAccessMask) == FieldAttributes.Private) continue;
            try
            {
                var fmods = fld.IsPublic ? "public" : fld.IsFamily ? "protected" : "internal";
                if (fld.IsStatic) fmods += " static";
                if (fld.IsInitOnly) fmods += " readonly";
                if (fld.IsLiteral) fmods += " static readonly";
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
                var pty = "object";
                try { pty = RS(pr.PropertySig != null ? pr.PropertySig.RetType : null); } catch { pty = "object"; }
                var accs = "";
                if (g != null) accs += (g.IsStatic ? "static " : "") + "get; ";
                if (s != null) accs += "set; ";
                W.WriteLine(p + "\t" + acc + " " + pty + " " + Id(pr.Name.String) + " { " + accs + "}");
            }
            catch { }
        }
        foreach (var ev in type.Events)
        {
            try { W.WriteLine(p + "\tpublic event " + TN(ev.EventType) + " " + Id(ev.Name.String) + " { add { } remove { } }"); } catch { }
        }
        var sigSeen = new HashSet<string>();
        foreach (var m in type.Methods)
        {
            try
            {
                var sigKey = m.Name.String + "/" + m.GenericParameters.Count + "/" + m.Parameters.Count + "/" + (m.ReturnType?.FullName ?? "v");
                if (!sigSeen.Add(sigKey)) continue;
                var isCtor = m.IsConstructor;
                var nm = isCtor ? Id(n) : Id(m.Name.String);
                var mArity = m.GenericParameters.Count;
                var s = new StringBuilder($"{p}\t");
                s.Append(Access(m) + " ");
                if (m.IsStatic) s.Append("static ");
                if (m.IsAbstract || m.IsRuntime) s.Append("abstract ");
                else if (m.IsVirtual && !m.IsNewSlot) s.Append("override ");
                if (!isCtor) s.Append(RS(m.ReturnType) + " ");
                s.Append(nm);
                if (mArity > 0) s.Append("<" + string.Join(", ", m.GenericParameters.Select(Gen)) + ">");
                s.Append("(" + string.Join(", ", m.Parameters.Select(x =>
                {
                    var pre = x.ParamDef != null && x.ParamDef.IsOut ? "out " : "";
                    var pn = Id(x.Name);
                    return pre + TN2(x.Type) + " " + pn;
                })) + ")");
                var body = m.IsAbstract || m.IsRuntime || type.IsInterface;
                s.Append(body ? ";" : $" {{ throw new System.NotImplementedException(\"未还原 (DNGuard HVM)\"); }}");
                W.WriteLine(s.ToString());
            }
            catch { }
        }
        foreach (var nt in type.NestedTypes) { try { EmitType(nt, ind + 1); } catch { } }
        W.WriteLine(p + "}");
        W.WriteLine();
    }
}
