// MassRecon — DNGuard 保护下的 .NET 程序集静态方法清单器
//
// 用途：绕开被摧毁的 IL，直接读 ECMA-335 元数据，枚举全部 MethodDef，
//       并按「IL 桩形态」分类：
//         throw-stub : 00 72 xx.. 73 xx.. 2a  → ldstr "Error, DNGuard Runtime library not loaded!"; newobj; throw
//         vm-stub    : 20 p0.. 20 i.. 28 t.. 2a → ldc.i4 progid; ldc.i4 idx; call dispatcher; ret
//         real       : 其余（未受保护 / 已明文）
//         none       : 无方法体（abstract / pinvoke / 内部调用）
//
// 输出 JSONL，供回填器与统计使用。
//
// 用法:
//   MassRecon dump <dir-or-dll>... --out methods.jsonl [--summary]
using System.Text;
using System.Text.Json;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;

string? outPath = null;
bool summary = false;
var inputs = new List<string>();

for (int i = 0; i < args.Length; i++)
{
    switch (args[i])
    {
        case "--out": outPath = args[++i]; break;
        case "--summary": summary = true; break;
        default: inputs.Add(args[i]); break;
    }
}

if (inputs.Count == 0)
{
    Console.Error.WriteLine("用法: MassRecon dump <dir-or-dll>... [--out methods.jsonl] [--summary]");
    Console.Error.WriteLine("      MassRecon tables <dll>...");
    return 2;
}

// ---------------- tables 子命令：元数据表统计 ----------------
if (inputs.Count > 0 && inputs[0] == "tables")
{
    foreach (var f in inputs.Skip(1))
    {
        try
        {
            using var fs = File.OpenRead(f);
            using var pe = new PEReader(fs);
            if (!pe.HasMetadata) { Console.WriteLine($"{Path.GetFileName(f)}: 非托管"); continue; }
            var md = pe.GetMetadataReader();
            Console.WriteLine($"=== {Path.GetFileName(f)}  MVID={md.GetGuid(md.GetModuleDefinition().Mvid):N} ===");
            Console.WriteLine($"  MethodDef={md.MethodDefinitions.Count}  TypeDef={md.TypeDefinitions.Count}  " +
                              $"StandAloneSig={md.GetTableRowCount(TableIndex.StandAloneSig)}  " +
                              $"MemberRef={md.GetTableRowCount(TableIndex.MemberRef)}  " +
                              $"TypeRef={md.GetTableRowCount(TableIndex.TypeRef)}  " +
                              $"TypeSpec={md.GetTableRowCount(TableIndex.TypeSpec)}  " +
                              $"MethodSpec={md.GetTableRowCount(TableIndex.MethodSpec)}  " +
                              $"CustomAttribute={md.GetTableRowCount(TableIndex.CustomAttribute)}");
            int nsig = md.GetTableRowCount(TableIndex.StandAloneSig);
            for (int rid = 1; rid <= Math.Min(nsig, 4); rid++)
            {
                var h = MetadataTokens.StandaloneSignatureHandle(rid);
                var blob = md.GetBlobBytes(md.GetStandaloneSignature(h).Signature);
                var hex = Convert.ToHexString(blob);
                Console.WriteLine($"    StandAloneSig[{rid}] ({blob.Length}B) = {(hex.Length > 120 ? hex.Substring(0, 120) + "…" : hex)}");
            }
        }
        catch (Exception e) { Console.WriteLine($"{Path.GetFileName(f)}: {e.GetType().Name} {e.Message}"); }
    }
    return 0;
}

// 展开目录
var files = new List<string>();
foreach (var inp in inputs)
{
    if (Directory.Exists(inp))
        files.AddRange(Directory.GetFiles(inp, "*.dll", SearchOption.TopDirectoryOnly));
    else if (File.Exists(inp))
        files.Add(inp);
}
files = files.Distinct().OrderBy(f => f, StringComparer.Ordinal).ToList();

StreamWriter? w = outPath != null ? new StreamWriter(outPath, false, new UTF8Encoding(false)) : null;
var perAsm = new Dictionary<string, (int total, int real, int vm, int thr, int none, long ilBytes)>();
var jsonOpts = new JsonSerializerOptions { Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping };

int grandTotal = 0, grandReal = 0, grandVm = 0, grandThr = 0, grandNone = 0;
long grandIl = 0;

foreach (var file in files)
{
    var name = Path.GetFileName(file);
    byte[] bytes;
    try { bytes = File.ReadAllBytes(file); }
    catch (Exception e) { Console.Error.WriteLine($"[skip] {name}: {e.Message}"); continue; }

    if (bytes.Length < 0x40 || bytes[0] != (byte)'M' || bytes[1] != (byte)'Z')
    { Console.Error.WriteLine($"[skip] {name}: 非 PE"); continue; }

    PEReader pe;
    try { pe = new PEReader(new MemoryStream(bytes, writable: false)); }
    catch (Exception e) { Console.Error.WriteLine($"[skip] {name}: {e.Message}"); continue; }

    if (!pe.HasMetadata)
    {
        Console.Error.WriteLine($"[skip] {name}: 非托管（无 CLR 元数据）");
        continue;
    }

    MetadataReader md;
    try { md = pe.GetMetadataReader(); }
    catch (Exception e) { Console.Error.WriteLine($"[skip] {name}: 元数据损坏 {e.Message}"); continue; }

    var mvid = md.GetGuid(md.GetModuleDefinition().Mvid).ToString("N");
    int total = 0, nReal = 0, nVm = 0, nThr = 0, nNone = 0;
    long ilBytes = 0;

    foreach (var typeHandle in md.TypeDefinitions)
    {
        var td = md.GetTypeDefinition(typeHandle);
        string typeName = TypeFullName(md, td);
        var typeAttrs = AttrNames(md, td.GetCustomAttributes());

        foreach (var mh in td.GetMethods())
        {
            var mdh = md.GetMethodDefinition(mh);
            string methodName = md.GetString(mdh.Name);
            var sig = mdh.DecodeSignature(new SigProvider(), null);
            int token = 0x06000000 | MetadataTokens.GetRowNumber(mh);
            var mAttrs = AttrNames(md, mdh.GetCustomAttributes());
            var allAttrs = typeAttrs.Count > 0 ? typeAttrs.Concat(mAttrs).Distinct().ToList() : mAttrs;

            total++;
            string kind;
            string ilhex = "";
            int ilLen = 0, maxStack = 0, eh = 0;
            uint progid = 0, vmIdx = 0, disp = 0;

            if (mdh.RelativeVirtualAddress == 0)
            {
                kind = "none";
                nNone++;
            }
            else
            {
                MethodBodyBlock? body = null;
                try { body = pe.GetMethodBody(mdh.RelativeVirtualAddress); } catch { }
                if (body == null) { kind = "none"; nNone++; }
                else
                {
                    var il = body.GetILBytes() ?? Array.Empty<byte>();
                    ilLen = il.Length; maxStack = body.MaxStack; eh = body.ExceptionRegions.Length;
                    ilhex = Convert.ToHexString(il).ToLowerInvariant();
                    ilBytes += il.Length;

                    // DNGuard 抛错桩: ldstr <tok>(72) ; newobj <tok>(73) ; throw(7a)
                    if (il.Length == 11 && il[0] == 0x72 && il[5] == 0x73 && il[10] == 0x7a)
                    {
                        kind = "throw"; nThr++;
                    }
                    // DNGuard HVM 桩: ldc.i4 progid(20) ; ldc.i4 idx(20) ; call dispatcher(28) ; ret(2a)
                    else if (il.Length == 16 && il[0] == 0x20 && il[5] == 0x20 && il[10] == 0x28 && il[15] == 0x2a)
                    {
                        kind = "vm"; nVm++;
                        progid = BitConverter.ToUInt32(il, 1);
                        vmIdx = BitConverter.ToUInt32(il, 6);
                        disp = BitConverter.ToUInt32(il, 11);
                    }
                    else
                    {
                        kind = "real"; nReal++;
                    }
                }
            }

            if (w != null)
            {
                var rec = new Dictionary<string, object>
                {
                    ["asm"] = name,
                    ["mvid"] = mvid,
                    ["type"] = typeName,
                    ["method"] = methodName,
                    ["sig"] = sig,
                    ["token"] = token,
                    ["attr"] = allAttrs,
                    ["kind"] = kind,
                    ["il"] = ilLen,
                    ["maxstack"] = maxStack,
                    ["eh"] = eh,
                };
                if (kind == "vm") { rec["progid"] = progid; rec["vmidx"] = vmIdx; rec["disp"] = disp; }
                if (kind != "none") rec["ilhex"] = ilhex;
                w.WriteLine(JsonSerializer.Serialize(rec, jsonOpts));
            }
        }
    }

    pe.Dispose();
    perAsm[name] = (total, nReal, nVm, nThr, nNone, ilBytes);
    grandTotal += total; grandReal += nReal; grandVm += nVm; grandThr += nThr; grandNone += nNone; grandIl += ilBytes;
}

w?.Dispose();

if (summary || outPath == null)
{
    Console.WriteLine($"{"程序集",-32} {"方法",7} {"real",7} {"vm",6} {"throw",7} {"none",6} {"IL字节",10}");
    Console.WriteLine(new string('-', 84));
    foreach (var (asm, v) in perAsm.OrderBy(k => k.Key, StringComparer.Ordinal))
        Console.WriteLine($"{asm,-32} {v.total,7} {v.real,7} {v.vm,6} {v.thr,7} {v.none,6} {v.ilBytes,10}");
    Console.WriteLine(new string('-', 84));
    Console.WriteLine($"{"合计",-32} {grandTotal,7} {grandReal,7} {grandVm,6} {grandThr,7} {grandNone,6} {grandIl,10}");
}
return 0;

static string TypeFullName(MetadataReader md, TypeDefinition td)
{
    string ns = md.GetString(td.Namespace);
    string n = md.GetString(td.Name);
    var declaring = td.GetDeclaringType();
    if (!declaring.IsNil)
        return TypeFullName(md, md.GetTypeDefinition(declaring)) + "+" + n;
    return string.IsNullOrEmpty(ns) ? n : ns + "." + n;
}

static List<string> AttrNames(MetadataReader md, CustomAttributeHandleCollection handles)
{
    var list = new List<string>();
    foreach (var h in handles)
    {
        try
        {
            var ca = md.GetCustomAttribute(h);
            string s = ca.Constructor.Kind switch
            {
                HandleKind.MemberReference => MemberRefName(md, (MemberReferenceHandle)ca.Constructor),
                HandleKind.MethodDefinition => MethodDefName(md, (MethodDefinitionHandle)ca.Constructor),
                _ => ca.Constructor.Kind.ToString(),
            };
            list.Add(s);
        }
        catch { }
    }
    return list;
}

static string MemberRefName(MetadataReader md, MemberReferenceHandle h)
{
    var mr = md.GetMemberReference(h);
    string type = "";
    try
    {
        if (mr.Parent.Kind == HandleKind.TypeReference)
        {
            var tr = md.GetTypeReference((TypeReferenceHandle)mr.Parent);
            type = md.GetString(tr.Namespace) + "." + md.GetString(tr.Name);
        }
        else if (mr.Parent.Kind == HandleKind.TypeDefinition)
        {
            var td = md.GetTypeDefinition((TypeDefinitionHandle)mr.Parent);
            type = md.GetString(td.Namespace) + "." + md.GetString(td.Name);
        }
    }
    catch { }
    return type.TrimStart('.') + "::" + md.GetString(mr.Name);
}

static string MethodDefName(MetadataReader md, MethodDefinitionHandle h)
{
    var m = md.GetMethodDefinition(h);
    var t = md.GetTypeDefinition(m.GetDeclaringType());
    return md.GetString(t.Namespace) + "." + md.GetString(t.Name) + "::" + md.GetString(m.Name);
}

sealed class SigProvider : ISignatureTypeProvider<string, object?>
{
    public string GetArrayType(string elementType, ArrayShape shape) => elementType + "[]";
    public string GetByReferenceType(string elementType) => "ref " + elementType;
    public string GetFunctionPointerType(MethodSignature<string> signature) => "fnptr";
    public string GetGenericInstantiation(string genericType, System.Collections.Immutable.ImmutableArray<string> typeArguments)
        => genericType + "<" + string.Join(",", typeArguments) + ">";
    public string GetGenericMethodParameter(object? genericContext, int index) => "!!" + index;
    public string GetGenericTypeParameter(object? genericContext, int index) => "!" + index;
    public string GetModifiedType(string modifier, string unmodifiedType, bool isRequired) => unmodifiedType;
    public string GetPinnedType(string elementType) => elementType;
    public string GetPointerType(string elementType) => elementType + "*";
    public string GetPrimitiveType(PrimitiveTypeCode typeCode) => typeCode switch
    {
        PrimitiveTypeCode.Void => "void", PrimitiveTypeCode.Boolean => "bool", PrimitiveTypeCode.Char => "char",
        PrimitiveTypeCode.SByte => "sbyte", PrimitiveTypeCode.Byte => "byte", PrimitiveTypeCode.Int16 => "short",
        PrimitiveTypeCode.UInt16 => "ushort", PrimitiveTypeCode.Int32 => "int", PrimitiveTypeCode.UInt32 => "uint",
        PrimitiveTypeCode.Int64 => "long", PrimitiveTypeCode.UInt64 => "ulong", PrimitiveTypeCode.Single => "float",
        PrimitiveTypeCode.Double => "double", PrimitiveTypeCode.String => "string", PrimitiveTypeCode.TypedReference => "typedref",
        PrimitiveTypeCode.IntPtr => "nint", PrimitiveTypeCode.UIntPtr => "nuint", PrimitiveTypeCode.Object => "object",
        _ => typeCode.ToString(),
    };
    public string GetSZArrayType(string elementType) => elementType + "[]";
    public string GetTypeFromDefinition(MetadataReader reader, TypeDefinitionHandle handle, byte rawTypeKind)
    {
        var td = reader.GetTypeDefinition(handle);
        string ns = reader.GetString(td.Namespace), n = reader.GetString(td.Name);
        return string.IsNullOrEmpty(ns) ? n : ns + "." + n;
    }
    public string GetTypeFromReference(MetadataReader reader, TypeReferenceHandle handle, byte rawTypeKind)
    {
        var tr = reader.GetTypeReference(handle);
        string ns = reader.GetString(tr.Namespace), n = reader.GetString(tr.Name);
        return string.IsNullOrEmpty(ns) ? n : ns + "." + n;
    }
    public string GetTypeFromSpecification(MetadataReader reader, object? genericContext, TypeSpecificationHandle handle, byte rawTypeKind)
        => "typespec";
}
