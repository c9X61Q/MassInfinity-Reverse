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
| 其中 **原始代码可读**（可直接反编译） | **5,971（11.6%）** |
| 其中**体已被 DNGuard 替换或生成** | **45,684（88.4%）** |
| 　· DNGuard VM 桩体（`ldnull;ldc.i4.0;ldc.i4.0;newobj;…;calli`，全部 ≤64 字节） | 27,586 |
| 　· DNGuard 生成码（token 带 bit23 标志，可逆） | 7,851 |
| 　· DNGuard VM 桩（16 字节 `ldc.i4;ldc.i4;call;ret`） | 7,847 |
| 　· 转发桩（`call X; ret`） | 1,655 |
| 　· DVM 派发桩（`ldsfld a;dup;brtrue;pop;ldstr;throw`） | 745 |
| **VM 方法登记表**（方法名 → k / progid / 描述符地址） | **28,331 条** |
| 反编译产物 | **1,191 个 C# 文件 / 26 MB** |
| 局部变量签名 | 保护器不提供（`locals.cbSig` 恒为 0），用 `object` 占位 + 反编译器推断 |

> **这个目标的保护强度比一开始估计的高得多**：88.4% 的方法体不在文件里、
> 也不在 JIT 流里 —— 它们是 DNGuard 生成的、指向原生 VM 的桩。
> 原始语义**不在** `.hvm0`、也不在 JIT 流里；原生处理器不做计算 —— 见下方「保护机制（最终模型）」。

---

## 保护机制（最终模型，全部有证据）

DNGuard HVM 的核心手法：**把每个方法的落盘 IL 换成一个模板化的「守卫桩」，
桩只把 `(k, progid, desc)` 三个常量交给原生运行时，自身不含方法语义。**

```
落盘形态（静态）：
  ldstr "Error, DNGuard Runtime library not loaded!"
  newobj System.Exception::.ctor(string)
  throw

运行时被替换成的桩（模板 A，本文档统计 27,586 个）：
  ldnull; ldc.i4.0; ldc.i4.0; newobj System.Exception::.ctor(string)
  ldsfld ZYXDNGuarder.a                              ; native-int 字段
  call   System.Reflection.MethodBase::GetCurrentMethod()
  ldc.i4 <k>; ldc.i4 <progid>; ldc.i8 <desc>
  newobj System.IntPtr::.ctor(int64)
  ldc.i4.s 15
  call   ZYXDNGuarder.a ; calli
  ldnull; ret
```

**关键事实（本仓库 9 轮逆向的收敛结论）**：

| 事实 | 证据 |
|---|---|
| 原生侧「处理器」不做计算：只 `cmp [rcx+0x3b8],0` 后**返回 0** | `docs/VM-机制与下一步.md` §22（REA 逐函数） |
| 生成的桩**模板化**，所有方法共用同一骨架，只差 `k`/`progid`/`desc` | §14、`data/vm-stub-table.jsonl.gz`（28,331 条） |
| 唯一的 IL 生成器 `sub_180016ed0` **每次运行只被调用约 12 次**（只服务签名支路） | §16.1、§17.2（返回地址法） |
| 描述符表**每程序集一张**，是「桩模板所需的成员集合」，**不含方法语义** | §15 + §23 + §24、[`docs/描述符表-完整还原.md`](docs/描述符表-完整还原.md) |
| `.hvm0`（3 MB 加密段）磁盘与内存**逐字节相同**、**零静态引用**、**零 memcpy 来源** → 本次运行路径里未被使用 | §17–§18、§21 |
| 真正的数据仓库是**托管程序集内部**约 50–60% 的高熵加密块；DNGuard **原地按需解密**其中一部分 | §20.4（差异 46,192 B，熵 8.00→3.4~6.0 为明文） |
| `VirtualProtect`/`VirtualQuery` 在 IAT 里但 **`.text` 零引用** → 不改页属性，解密目标是**可写副本** | §21.3 |
| 托管→原生通道是 `ZYXDNGuarder::CheckRuntime/CheckRuntime64`（`InternalCall`，无托管体） | §23.4 |
| `ZYXDNGuarder` 声明 **5,436 个方法**，绝大多数是同一个 11 字节守卫桩（名称为随机 unicode） | §23.5 |

> **结论**：受保护方法的语义**不在文件里、也不在 JIT 流里、也不在 `.hvm0` 里**，
> 并且原生侧没有可复刻的「解释并执行」入口。
> 因此「离线还原 7,851（乃至 45,684）个受保护方法的原始 IL」**在数据层面不可达成** ——
> 不是工具不够，而是这些方法的原始 IL 从未以任何可提取的形式存在于本目标的产物中。
> 详细证据链见 [`docs/VM-机制与下一步.md`](docs/VM-机制与下一步.md) §14–§24。

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
├── src/                     反编译出的 C# 源码（11 个项目，见 `find src -name '*.cs' | wc -l`）
├── docs/
│   ├── 逆向指南.md          完整方法论（含每一步的命令与踩坑）
│   ├── 逆向进度.md          进度快照与技术细节
│   ├── 报告-DNGuard-HVM.md  保护机制分析报告
│   ├── 描述符表-完整还原.md  ★ 描述符表 16 槽全部解码（编码 + 生成器读法 + 与桩的对应）
│   ├── VM-机制与下一步.md    ★ 9 轮逆向的完整证据链（§1–§24），含全部已证伪假设与纠错记录
│   └── 数据与限制.md        数据字典、统计、已知限制
├── tools/
│   ├── MassRecon/           静态方法清单器（ECMA-335 直读，绕开被摧毁的 IL）
│   ├── MassDumper/          强制 JIT 全量覆盖器 + MethodDesc 键表
│   ├── MassBackfill/        dnlib 回填器（含指令级自验证）
│   ├── hook-dump.js         Frida hook（挂 clrjit 原始 compileMethod）
│   ├── hook-{vmnative,vn,drive,fixup,desc,gen,emit,mem,blob2,h1310}.js
│   │                        运行时取证脚本：VM 原生链 / 描述符表 / 发射流 / 内存拷贝 / 加密块
│   ├── ildisasm.py          IL 反汇编器（含全部前缀/switch/分支宽度）
│   └── analysis/            join / extract / verify / calibrate 脚本
└── data/
    ├── recovered.jsonl.gz              运行时捕获的真实 IL（含身份、maxStack、局部变量数、EH）
    ├── recovered-deobf.jsonl.gz        清除 token bit23 标志后的回填输入
    ├── map.txt.gz                      MethodDesc → 方法身份
    ├── methods-inventory.jsonl.gz      静态清单（方法 + 桩形态分类）
    ├── vm-stub-table.jsonl.gz          ★ 28,331 条桩登记（方法 → k / progid / desc）
    ├── vm-desc-tables*.tsv.gz          ★ 运行时抓到的描述符表原始内容
    ├── vm-descriptor-*.tsv.gz          描述符记录采样 / 链分析
    ├── vm-emit-stream.tsv.gz           IL 生成器的 377 条发射流（含返回地址）
    ├── vm-gen-trace.tsv.gz             主生成器候选调用记录
    ├── vm-mem-copy.tsv.gz              memcpy 取证（印证跳板的 info 保存/还原）
    ├── vm-mem-alloc.tsv.gz             分配取证
    ├── mass-winui-blob-runtime.bin.gz  Mass.WinUI 加密块的运行时快照（1.7 MB）
    ├── guard-fields.tsv                ZYXDNGuarder 字段反射快照
    └── _out-il.tsv.gz                  回填后各方法体的实际 IL（供比对）
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

## 已知限制（按最终模型重写）

1. **受保护方法的原始 IL 无法还原（原理性限制）**：桩是模板化的、描述符表只含成员引用、
   原生处理器只做一次判断后返回 0。这三条互相独立地排除了「从产物还原语义」的路径。
   本仓库保留的是**桩登记表**（`data/vm-stub-table.jsonl.gz`，28,331 条：
   方法名 → `k` / `progid` / `desc`），可用于定位每个方法「被保护到了什么程度」，
   但**不能**给出方法在做什么。
2. **`.hvm0`（3,058,112 字节）在本运行路径中未被使用**：磁盘与内存逐字节一致、
   无 RIP 相对引用、无立即数、无 `.rdata` 字面量、无 memcpy 来源。早期把它当作
   「保护器代码段」的假设已被 §17–§21 排除。
3. **托管程序集内 50–60% 的高熵块只被部分解密**：实测运行时差异 46,192 字节（2.69%），
   差异处确为明文（资源/字符串）。其余部分在本运行路径中没有变明文，
   且密钥流经检验**不是重复密钥 XOR**（§21.4）。
4. **局部变量类型是推断值**：保护器不提供 locals 签名（`locals.cbSig` 恒为 0），
   本项目按槽位造 `object` 占位，具体类型由 ILSpy 从使用点推断，**`ref`/`struct` 语义可能丢失**。
5. **约 1,293 个方法从未被 JIT**（因此没有运行时体），落盘仍是抛错桩。
6. **异常处理子句只有 278/409 恢复**。
7. **回填后的程序集不能直接运行**：原生运行时与 DNGuard 保护段无法重建；
   产物用于**阅读与分析**。
8. **一处已作废的中间结论**：本仓库 §20.5（旧版）曾据「按表宽累加」推算的 MethodDef 表偏移
   读方法体，并由此推断「方法数据不在原地解密」。该表偏移的行宽推导有误
   （`#Strings > 64 KiB` → 名字索引 4 字节，行宽 16 而非 14），**该组读数已作废**
   （§23.6）。块级观察（差异 46,192 B / 明文）不受影响。
9. **本轮逆向的正确工具顺序**：原生侧用 REA **逐函数**分析（Hopper 的整程序查询在此二进制上
   必超时）；托管侧用 REA `inspect_managed_members` 取权威元数据；
   本地脚本只用于有界扫描喂候选地址。

---
## 免责与许可

- 本项目为**互操作性研究 / 安全分析**产物，仅用于学习交流。
- 原始程序及其商标、著作权归 **网易（NetEase）** 所有；本仓库不含原始程序集二进制。
- 本仓库中本项目自有的工具、脚本与文档以 **GPL-3.0** 发布，见 [LICENSE](LICENSE)。
