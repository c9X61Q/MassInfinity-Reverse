using dnlib.DotNet;
int types = 0, dtoTypes = 0, props = 0, methods = 0, accessors = 0, cctor = 0, obf = 0, readable = 0;
long dtoProps = 0;
foreach (var path in args)
{
    using var mod = ModuleDefMD.Load(path);
    foreach (var t in mod.GetTypes())
    {
        if (t.IsGlobalModuleType) continue;
        types++;
        props += t.Properties.Count;
        var allAccessors = t.Methods.Count > 0;
        foreach (var m in t.Methods)
        {
            methods++;
            var n = m.Name.String;
            if (n.StartsWith("get_") || n.StartsWith("set_") || n.StartsWith("add_") || n.StartsWith("remove_")) { accessors++; continue; }
            if (n is ".ctor" or ".cctor") { cctor++; continue; }
            allAccessors = false;
            if (System.Text.RegularExpressions.Regex.IsMatch(n, @"^[A-Za-z_][A-Za-z0-9_]*$") && !n.StartsWith("_FF")) readable++;
            else obf++;
        }
        if (allAccessors) { dtoTypes++; dtoProps += t.Properties.Count; }
    }
}
Console.WriteLine($"类型 {types}");
Console.WriteLine($"方法 {methods}");
Console.WriteLine($"  属性访问器 {accessors}");
Console.WriteLine($"  构造函数   {cctor}");
Console.WriteLine($"  可读名     {readable}");
Console.WriteLine($"  混淆名     {obf}");
Console.WriteLine($"属性总数 {props}");
Console.WriteLine($"纯数据类（所有方法都是访问器/构造）{dtoTypes} 个，覆盖属性 {dtoProps}");
