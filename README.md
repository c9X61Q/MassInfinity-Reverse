# Mass Infinity 逆向工程（DNGuard HVM 脱壳与源码还原）

> 目标：**Mass Infinity**（网易《我的世界》账号管理器 Windows 客户端）
> 程序集：`Mass.WinUI 1.35.107.1217`（net8.0 / WinUI3 / 自包含）
> 保护：**DNGuard HVM**（.NET JIT 劫持型代码虚拟化）
> 许可：**GPL-3.0**

---

## 结果一览

| 指标 | 结果 |
|---|---|
| 受保护程序集 | 11 个 `Mass.*.dll` |
| 方法总数（静态清单） | **52,948** |
| 运行时捕获到 IL 的方法 | **51,655（97.6%）** |
| 其中**真实原始 IL**（脱壳成功） | **42,153（79.6%）** |
| 其中 HVM 虚拟化桩（逻辑在 VM 字节码里） | 7,847 |
| 其中转发桩 `call X; ret` | 1,655 |
| 元数据被摧毁的局部变量签名 | 23,303 个方法（用占位签名重建，见「已知限制」） |
| 异常处理子句 | 409 个方法，恢复 278 个 |
| 产物 | **1,183 个 C# 源文件 / 24 MB**（ILSpy 反编译） |

---

## 保护机制（全部实测）

DNGuard HVM 的核心手法：**把每个方法的落盘 IL 换成一个抛错桩，真实 IL 只在运行时由保护器现场解密。**

```
落盘形态（静态看）：
  ldstr "Error, DNGuard Runtime library not loaded!"
  newobj System.Exception::.ctor(string)
  throw
  → 52,159 / 52,948 个方法都是这个 11 字节桩

运行时链路：
  <Module>.cctor
    └─ ZYXDNGuarder.Startup()
         ├─ 反调试：GetProcessWindowStation + GetUserObjectInformationA(UOI_FLAGS) 检查 WSF_VISIBLE
         │          → SSH/session 0 会被拒，必须在交互式桌面会话运行
         ├─ 加载原生 Mass.Runtime64.dll
         ├─ 改写 clrjit.dll 的 ICorJitCompiler::vtable[0] → Mass.Runtime64.dll+0x446b0
         └─ 初始化自己的 ICorJitInfo 代理
```

| 组件 | 值 |
|---|---|
| JIT 劫持入口 | `Mass.Runtime64.dll + 0x446b0` |
| 原始 JIT 入口 | `clrjit.dll + 0xed430` |
| 核心处理函数 | `Mass.Runtime64.dll + 0x161b0` |
| 加密节区 | `.hvm0` 3.06 MB，熵 7.95（全加密，密钥仅在运行时） |
| 元数据摧毁 | `StandAloneSig` 全表填 `0xCC`；`MethodDef` 表顺序被打乱 |

---

## 关键突破（本项目的技术核心）

### 1. 绕过反篡改：hook 原始 JIT 而不是被劫持的槽

保护器改写了 `clrjit.dll` 的 `ICorJitCompiler::vtable[0]`。但如果直接 hook 保护器自己的
`compileMethod`，会触发反篡改抛 `InvalidProgramException`。

**正解**：hook `clrjit.dll + 0xed430` —— clrjit 自己的那段原始 `compileMethod`。
保护器不校验那里，而它最终仍把解密后的 IL 转发给真 JIT，于是能拿到**全部**真实 IL。

```js
const cm = clrjit.base.add(0xed430);
Interceptor.attach(cm, { onEnter(a) {
  const info = a[2];                 // CORINFO_METHOD_INFO*
  const ftn  = info.readPointer();   // MethodDesc*
  const ilP  = info.add(16).readPointer();
  const ilS  = info.add(24).readU32();
  ...
}});
```

### 2. 方法身份绑定：用 `MethodDesc*` 做主键

`compileMethod` 只给一个 `MethodDesc*`，没有名字、没有 token —— 这是「拿到 IL 却不知道是谁的」的根源。

**正解**：托管侧 `MethodBase.MethodHandle.Value` **返回的就是同一个 `MethodDesc*`**。
于是把采集拆成两路、用 `MethodDesc` 离线 join，运行期两者**完全不需要通信**：

```
Frida  侧：抓 (MethodDesc → IL 字节)
托管侧 ：全量枚举 → map.txt (MethodDesc → MVID + token + 类型 + 方法 + 签名)
离线    ：按 MethodDesc join
```

好处：无顺序依赖，多线程并发 JIT / tiering / 重复编译都不影响（早期用「顺序文件通道」的做法非常脆弱，已废弃）。

### 3. 覆盖率：用 `RuntimeHelpers.PrepareMethod` 全量逼 JIT

只 hook 的话，覆盖率取决于「程序跑过哪些方法」——上一阶段只拿到 11,902 个（22.5%）。

**正解**：写一个自包含的「覆盖器」，借目标自带的 net8 运行时启动，
对全部 52,948 个方法逐个调 `RuntimeHelpers.PrepareMethod`，把没跑到的代码也逼进 JIT。
（`RunModuleConstructor` 必须显式调，否则保护器的 JIT 劫持根本没装上。）

### 4. 元数据被摧毁时的重建

| 被摧毁的东西 | 现象 | 本项目的处理 |
|---|---|---|
| `locals` 签名 | `CORINFO_METHOD_INFO.locals.cbSig == 0`（实测 100% 为 0） | 按 IL 里用到的最大局部槽位造 `object` 占位签名，类型交给 ILSpy 从使用点推断 |
| `StandAloneSig` 表 | 全填 `0xCC` | 同上（回填时 dnlib 自动生成新签名） |
| `MethodDef` 表顺序 | 被打乱 | 回填/验证一律按 **(MVID, token)** 或 **(类型全名, 方法名)** 定位，不假设 token 稳定 |
| `dynstr` / `dynsym`（原生侧） | 见 `docs/原生侧说明.md` | 不可逆（等长随机替换） |

---

## 完整流水线

```
① 目标环境       Windows 10 22H2 / QEMU-KVM / 交互式桌面会话（反调试要求）
② 静态清单       MassRecon     → methods-inventory.jsonl（52,948 个方法 + 桩形态）
③ 强制 JIT       MassDumper     → map.txt（MethodDesc → 方法身份）
                                （借目标自带运行时启动，RunModuleConstructor + PrepareMethod 全量）
④ 运行时抓取     hook-dump.js   → il-all.tsv（MethodDesc → 解密后的原始 IL）
                 （Frida 挂在 clrjit+0xed430；spawn 模式；需 /rl highest /it 计划任务）
⑤ join + 分类    join.py/extract.py → recovered.jsonl（51,655 条，含身份 + 形态 + EH）
⑥ 回填           MassBackfill   → 11 个 IL 已修复的程序集
                 （把 IL 合成标准 COR_ILMETHOD 镜像，交 dnlib 的 MethodBodyReader 解析）
⑦ 反编译         ilspycmd -p    → src/（1,183 个 C# 文件）
⑧ 验证           verify_backfill.py（token 掩码后的指令级比对）
```

---

## 目录结构

```
├── src/                     反编译出的 C# 源码（11 个项目，1,183 个文件）
├── docs/
│   ├── 逆向指南.md          完整方法论（含每一步的命令与踩坑）
│   ├── 逆向进度.md          进度快照与技术细节
│   ├── 报告-DNGuard-HVM.md  保护机制分析报告
│   └── 数据与限制.md        数据字典、统计、已知限制
├── tools/
│   ├── MassRecon/           静态方法清单器（ECMA-335 直读，绕开被摧毁的 IL）
│   ├── MassDumper/          强制 JIT 全量覆盖器 + MethodDesc 键表
│   ├── MassBackfill/        dnlib 回填器（含指令级自验证）
│   ├── hook-dump.js         Frida hook（挂 clrjit 原始 compileMethod）
│   ├── ildisasm.py          IL 反汇编器（含全部前缀/switch/分支宽度）
│   └── analysis/            join / extract / verify / calibrate 脚本
└── data/
    ├── recovered.jsonl.gz           42,153 条真实 IL（含身份、maxStack、局部变量数、EH）
    ├── map.txt.gz                   52,896 条 MethodDesc → 方法身份
    ├── methods-inventory.jsonl.gz   静态清单（52,948 个方法 + 桩形态分类）
    └── _out-il.tsv.gz               回填后程序集里各方法体的实际 IL（供比对）
```

---

## 快速复现

```bash
# ① 静态清单（只看落盘形态，不需要运行目标）
dotnet run --project tools/MassRecon -- dump <目标目录> --out inventory.jsonl --summary

# ② 回填（需要 ③ 产出的 recovered.jsonl）
dotnet run --project tools/MassBackfill -- data/recovered.jsonl <原始程序集目录> <输出目录>

# ③ 反编译
ilspycmd -p -o src/ <回填后的程序集>
```

运行时采集（②③④）需要一台 Windows + 交互式桌面会话，详见 [docs/逆向指南.md](docs/逆向指南.md)。

---

## 已知限制

1. **7,847 个方法被 HVM 虚拟化**：它们的真实逻辑在 DNGuard 的 VM 字节码里，IL 只剩
   `ldc.i4 progid; ldc.i4 idx; call VM派发器; ret`。反编译结果里表现为
   `ZYXDNGuarder.a(...)` 形式的 DVM 调用。要还原需要反虚拟化 VM（7 个巨型 IL 状态机已在
   `data/recovered.jsonl.gz` 里）。
2. **局部变量类型是推断值**：保护器不给 locals 签名，本项目按槽位数造 `object` 占位，
   具体类型由 ILSpy 从使用点推断。**`ref`/`struct` 语义可能丢失。**
3. **约 1,293 个方法从未被 JIT**（因此没有真实 IL），落盘仍是抛错桩。
4. **异常处理子句只有 278/409 恢复**：保护器把 IL 放在自己的缓冲里，EH 表的位置不是固定的。
5. 回填后的程序集**不能直接运行**：原生运行时 `Mass.Runtime64.dll` 与 `Mass.*.dll` 里的
   DNGuard 保护段没有（也无法）重建。本项目产物用于**阅读与分析**。
6. 验证口径：token 掩码后的指令级等价率为 68.5%，其余差异主要来自「同名重载配对噪声」与
   「元数据被摧毁导致操作数为空的指令被降级为 `nop`」。详见 `docs/数据与限制.md`。

---

## 免责与许可

- 本项目为**互操作性研究 / 安全分析**产物，仅用于学习交流。
- 原始程序及其商标、著作权归 **网易（NetEase）** 所有；本仓库不含原始程序集二进制。
- 本仓库中本项目自有的工具、脚本与文档以 **GPL-3.0** 发布，见 [LICENSE](LICENSE)。
