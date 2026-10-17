// 从元数据生成「干净 DTO 层」—— 只输出属性（编译器生成语义）与枚举。
// ⚠️ 这层的正确性来自「属性访问器体是编译器生成的」，不需要反编译；与受保护方法体无关。
using dnlib.DotNet;
using System.Text;

var outDir = Environment.GetEnvironmentVariable("DTO_OUT") ?? "generated";
Directory.CreateDirectory(outDir);

var mods = args.Select(a => ModuleDefMD.Load(a)).ToList();

// Pass 1：收集所有「有属性」的类型 → 生成名映射
var gen = new Dictionary<TypeDef, string>();
foreach (var mod in mods)
    foreach (var t in mod.GetTypes())
    {
        if (t.IsGlobalModuleType) continue;
        if (t.Properties.Count == 0) continue;
        var asm = Sanitize(mod.Assembly.Name.String);
        var path = t.FullName.Replace('/', '.').Replace('+', '.').Split('.');
        gen[t] = "G_" + asm + "_" + string.Join("_", path.Select(Sanitize));
    }

string Sanitize(string s)
{
    if (string.IsNullOrEmpty(s)) return "_";
    var sb = new StringBuilder();
    foreach (var c in s) sb.Append(char.IsLetterOrDigit(c) || c == '_' ? c : '_');
    var r = sb.ToString();
    if (char.IsDigit(r[0])) r = "_" + r;
    return r;
}

// 枚举名（用于把枚举属性映射到生成枚举）
var enums = new Dictionary<TypeDef, string>();
foreach (var mod in mods)
    foreach (var t in mod.GetTypes())
        if (t.IsEnum && !t.IsGlobalModuleType) enums[t] = gen.TryGetValue(t, out var g) ? g : "G_" + Sanitize(mod.Assembly.Name.String) + "_" + Sanitize(t.Name.String);

string MapType(TypeSig sig)
{
    if (sig is null) return "object";
    if (sig is ByRefSig b) return MapType(b.Next);
    if (sig is SZArraySig a) return MapType(a.Next) + "[]";
    if (sig is GenericInstSig gi)
    {
        var name = gi.GenericType.TypeDefOrRef?.Name?.String ?? "object";
        if (gi.GenericArguments is null || gi.GenericArguments.Count == 0) return "object";
        var args = string.Join(", ", gi.GenericArguments.Select(MapType));
        var argc = gi.GenericArguments.Count;
        switch (name)
        {
            case "Nullable": return args + "?";
            case "KeyValuePair": return argc == 2 ? $"global::System.Collections.Generic.KeyValuePair<{args}>" : "object";
            case "Tuple": return $"global::System.Tuple<{args}>";
            case "ValueTuple": return $"({args})";
            case "IGrouping": return argc == 2 ? $"global::System.Linq.IGrouping<{args}>" : "object";
        }
        if (argc == 1)
            return name switch
            {
                "List" or "IList" or "IReadOnlyList" or "ICollection" or "IReadOnlyCollection" or "IEnumerable"
                    => $"global::System.Collections.Generic.List<{args}>",
                "HashSet" or "ISet" or "IReadOnlySet" => $"global::System.Collections.Generic.HashSet<{args}>",
                "Queue" => $"global::System.Collections.Generic.Queue<{args}>",
                "Stack" => $"global::System.Collections.Generic.Stack<{args}>",
                _ => $"global::System.Collections.Generic.List<{args}>",
            };
        if (argc == 2)
            return name switch
            {
                "Dictionary" or "IDictionary" or "IReadOnlyDictionary" or "SortedDictionary"
                    => $"global::System.Collections.Generic.Dictionary<{args}>",
                "SortedList" => $"global::System.Collections.Generic.SortedList<{args}>",
                _ => $"global::System.Collections.Generic.Dictionary<{args}>",
            };
        return "object";
    }
    if (sig is TypeDefOrRefSig tdr && tdr.TypeDefOrRef is not null)
    {
        var td = tdr.TypeDefOrRef.ResolveTypeDef();
        if (td is not null)
        {
            if (enums.TryGetValue(td, out var en)) return "global::" + NsOf(td) + ".GGEN." + en;
            if (gen.TryGetValue(td, out var g)) return "global::" + NsOf(td) + ".GGEN." + g;
            if (td.IsEnum) return "int";
        }
        var full = tdr.TypeDefOrRef.FullName;
        return full switch
        {
            "System.String" => "string",
            "System.Boolean" => "bool",
            "System.Int32" => "int",
            "System.Int64" => "long",
            "System.UInt32" => "uint",
            "System.UInt64" => "ulong",
            "System.Int16" => "short",
            "System.UInt16" => "ushort",
            "System.Byte" => "byte",
            "System.SByte" => "sbyte",
            "System.Single" => "float",
            "System.Double" => "double",
            "System.Decimal" => "decimal",
            "System.Object" => "object",
            "System.DateTime" => "global::System.DateTime",
            "System.DateTimeOffset" => "global::System.DateTimeOffset",
            "System.TimeSpan" => "global::System.TimeSpan",
            "System.Guid" => "global::System.Guid",
            _ => "object",   // 未生成类型 → 保守降级为 object（并在注释里标出原名）
        };
    }
    if (sig is CorLibTypeSig c) return c.ElementType switch
    {
        ElementType.String => "string", ElementType.Boolean => "bool", ElementType.I4 => "int",
        ElementType.I8 => "long", ElementType.U4 => "uint", ElementType.U8 => "ulong",
        ElementType.R4 => "float", ElementType.R8 => "double", ElementType.Object => "object",
        _ => "object",
    };
    return "object";
}

string NsOf(TypeDef td)
{
    var asm = Sanitize(td.Module.Assembly.Name.String);
    return "MassInfinity.Rewrite.Generated." + asm;
}

int emitted = 0, propTotal = 0;
var byAsm = new Dictionary<string, StringBuilder>();
foreach (var mod in mods)
{
    var asm = Sanitize(mod.Assembly.Name.String);
    if (!byAsm.TryGetValue(asm, out var sb)) byAsm[asm] = sb = new StringBuilder();
    foreach (var t in mod.GetTypes())
    {
        if (t.IsGlobalModuleType) continue;
        if (!gen.TryGetValue(t, out var gname) && !enums.ContainsKey(t)) continue;

        if (t.IsEnum)
        {
            sb.AppendLine($"namespace {NsOf(t)}.GGEN {{");
            sb.AppendLine($"    // 枚举值来自元数据（Constant 表），可机械确定");
            sb.AppendLine($"    public enum {enums[t]}");
            sb.AppendLine("    {");
            foreach (var f in t.Fields)
            {
                if (!f.HasConstant) continue;
                sb.AppendLine($"        {Sanitize(f.Name.String)} = {f.Constant.Value},");
            }
            sb.AppendLine("    }");
            sb.AppendLine("}");
            emitted++;
            continue;
        }

        sb.AppendLine($"namespace {NsOf(t)}.GGEN {{");
        sb.AppendLine($"    /// <summary>字段/类型来自元数据（属性访问器体由编译器生成，语义可机械确定）。");
        sb.AppendLine($"    /// 原类型: {t.FullName} ⚠️ 方法体未包含（混淆名方法无语义可写）。</summary>");
        sb.AppendLine($"    public partial class {gname}");
        sb.AppendLine("    {");
        var seen = new HashSet<string>();
        foreach (var p in t.Properties)
        {
            var tn = MapType(p.PropertySig?.RetType);
            var pn = Sanitize(p.Name.String);
            var basePn = pn; var k = 1;
            while (!seen.Add(pn)) { k++; pn = basePn + "_" + k; }
            sb.AppendLine($"        public {tn} {pn} {{ get; set; }}");
            propTotal++;
        }
        sb.AppendLine("    }");
        sb.AppendLine("}");
        emitted++;
    }
}
foreach (var kv in byAsm)
{
    var path = Path.Combine(outDir, kv.Key + ".g.cs");
    File.WriteAllText(path, "// 自动生成：MassDtoGen（dnlib 读元数据）\n// ⚠️ 仅含属性/枚举 —— 属性访问器体由编译器生成，故这层的语义可机械确定；\n//    方法体不在此层（受保护方法的语义不在任何可提取产物中）。\n#nullable disable\n" + kv.Value);
}
Console.WriteLine($"类型/枚举 {emitted} 个 → 属性 {propTotal} 个 → {outDir}");
