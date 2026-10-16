# DNGuard HVM 的 VM 层：实测机制与下一步

> 这一页是「托管侧 IL 全部拿到之后」的续篇：**虚拟化方法（7,847 个）的逻辑在 VM 里**，
> 这里记录我们实测到的 VM 机制，以及下一步该往哪打。
> 所有数据都来自本仓库 `data/` + 运行时内存取证。

---

## 1. VM 的三层结构（实测）

### ① 桩层：虚拟化方法的 IL 只剩 16 字节

```
ldc.i4 <A>     ; A：近 7,725 个互不相同的值，全部落在 0x6A000000 家族
ldc.i4 <B>     ; B：仅 126 个不同取值，范围 0–4999
call  <派发器>
ret
```
- 全部 7,847 个桩**都在 `ZYXDNGuarder` 类里**
- `A` 是**带 0x6A tag 的顺序 id**（不是哈希、不是地址）：
  11 个程序集各自占一个窄区间，例如 `0x6ABD10FA..0x6ABD1FB6`
  → **per-assembly 的程序/方法编号**
- `B` 取值稀疏（0–4999 里只有 126 个实际出现）→ 指向一张大部分为空的表

### ② 包装层：业务方法的冷路径

```csharp
nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))
             (null, <idx>, <A>, 0, 0);                      // 热路径：直接从 handler 拿函数指针
object obj = num;
if (num == 0)
    obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), <k>, <A>, new IntPtr(<常量>), 15);   // 冷路径
return (T)((delegate*<...>)obj)(args);                       // VM 把方法编成原生码，返回入口再调用
```
- `ZYXDNGuarder.a` 同名既是**字段**（handler 函数指针）又是**方法**（注册/编译）
- **VM 不是逐 opcode 解释业务方法，而是按需把方法编译成原生代码**

### ③ 【已更正】所谓「引擎层」其实是 **VM 载荷**，不是解释器

> ⚠️ 本节最初写成「引擎本体是托管 IL」是**错的**，下面是实测更正。

```
Mass.WinUI.Mass_WinUI_XamlTypeInfo.XamlTypeInfoProvider
  ├─ private object _FF00_FF00_FF00_FF00_FF00_FF00_FF00ᤀ(uint P_0)   IL 329,681B  67,926 指令  8,011 目标 switch
  ├─ private object _FF00_FF00_FF00뼀(object P_0)                     IL 225,592B  46,635 指令  6,598 目标 switch
  └─ private void 尀()                                                 IL  27,827B   6,484 指令    695 目标 switch
```
- **引擎本体是托管 IL**（不是原生汇编）→ 可以直接反编译、直接做抽象解释，不需要 Triton/angr
- 主解释器签名是 `object f(uint P_0)` → **程序按 uint 索引**
- 含 7 级 `FF` 名字的文件数：Mass.WinUI 91、Mass.Game.Proxy 271、Mass.Bedrock.Proxy 62 …
  → **每个程序集复制了一套引擎**（与「per-assembly 程序编号」自洽）

### ④ 原生层：`Mass.Runtime64.dll`

```
ImageBase = 0x180000000        DllCharacteristics = 0x0  ← DYNAMIC_BASE 未设置 = ASLR 关闭
.text    378,880B  明文
.rdata   180,736B
.data    117,760B
.hvm0  3,058,112B  熵 7.297、零字节 267,862   ← VM 程序存储
```
- 因为 ASLR 关闭，IL 里烧死的 `0x1800093e0` / `0x180009a90` **就是该 DLL 的 .text 真实地址**
  （`RunHVM` 把 `0x180009a90` 当 `unmanaged[Stdcall]<AppDomain,int,nint,void>` 直接调用）
- `0x180009a90` 实测是个 3 参数小函数（依次释放 `p[2]`/`p[1]`/`p`），配合 `(AppDomain, AppDomain.Id, ptr)`
  → 更像**注册域卸载清理回调**，不是 VM 初始化

---

## 2. 关键机制：IL 在运行时被解密进**堆缓冲池**，指针被**当场补丁**

这是本次最有价值的发现，也解释了之前一连串矛盾。

取证时在 RW 堆区（`0x3006b2f0000` 0x1FF000 / `0x3006ad40000` 0xFF000 / `0x3006ae50000` 0xF000）
读到 DNGuard **解密后的 IL 缓冲**，同一段 32 字节里同时出现：

```
21 65 c7 63 6b 00 03 00 00   ldc.i8  0x00036b63c765      ← 堆指针
20 ed 58 00 06               ldc.i4  0x060058ed          ← MethodDef token
2a                           ret
0a 16                        stloc.0 ; ldc.i4.0
20 e0 58 5c 6a               ldc.i4  0x6a5c58e0          ← progid（0x6A 家族）
21 fc 8c 39 6b 00 03 00 00   ldc.i8  0x00036b398cfc      ← 堆指针
```

**推论**：
1. DNGuard 把每条方法的 IL 解密到**堆缓冲区**（不是映像内）。
2. 交真 JIT 之前，它把 IL 里烧死的占位常量**补成当期真实地址**。
   → 所以**跨批次比较 IL 常量没有意义**：上一批数据里的 `0x27d3…/0x27d5…`
   在另一批运行里根本不存在（探针直接 access violation），同一批里它们是 `0x0003_6bxx_xxxx`。
3. IL 里的指针常量只有两类去向：
   - `0x180001000` 段 → `Mass.Runtime64.dll` 的**原生代码**
   - `0x3006xxxxxxx` 段 → **它自己的 IL 缓冲池**（已编译桩的缓存）

---

## 3. 被推翻的假设（省掉白工）

| 假设 | 结论 | 判据 |
|---|---|---|
| `.hvm0` 在内存里被**原地解密** | ❌ 推翻 | 运行时与磁盘**完全一致**：熵都是 7.297、零字节 267,798 vs 267,862（阶段一报告里写的「熵 7.95」是错的） |
| IL 里 `0x27d3/0x27d5` 是**固定分配地址** | ❌ 推翻 | 换一次运行就不可读；同批次里它们是 `0x0003_6bxx` 堆指针 → 是**运行时补丁**的 |
| 5,426 个「操作码命名」方法是 **VM ISA handler** | ❌ 推翻 | 全库 150,887 次调用里只有 **17 次**打到它们（11 个目标），且**全部来自各程序集的 `..cctor`（保护器装配点）**；且真正的引擎方法**也用同样的 FF 命名** → 名字是 DNGuard 的通用方法名混淆，不是 ISA |
| `#Blob` 堆里还留着**孤儿 locals 签名** | ❌ 推翻 | 每个程序集只有 2–5 个能精确解析成 LOCAL_SIG 的 blob（需要 23,303 个），同时有 61–508 个**纯 `0xCC` 填充**的 blob → 保护器盖的是**签名内容本身** |
| `switch` 出现 860 次 | ❌ 是字节计数 | 按指令边界：**1–2 个**（8,011+346 / 6,598 / 695 目标）→ 单 switch 状态机，CFG 提取很简单 |

### 顺带修掉的两个工具 bug

1. **`0xFE 0x08`（`jmp`）漏了 4 字节 token** → IL 走查在遇到 `jmp` 后整段错位。
   `tools/ildisasm.py` 已补。
2. 校验「token 命中率」时拿**全部** token 去比只含 MethodDef 的键表 → 假 0% 命中。
   正确做法是只比 `0x06xxxxxx`。

---

## 4. 下一步（按性价比）

1. **定位 VM 程序本体**：引擎签名是 `object f(uint)`
   → 程序是一张按 uint 索引的表。三条并行路线：
   - 扫 **GC 堆**里的托管数组（`byte[]`/`uint[]`），找按索引落到 switch 状态入口的那一张；
   - 在引擎 IL 里找**读 `.hvm0` 固定地址**的路径（`0x1800b2000`，VA 固定且内容未变）；
   - hook 引擎方法入口，直接读它第 1 个参数 `P_0` 的取值分布，反推程序的索引空间。
2. **提状态图**：主 switch 只有 1 个（8,011 目标）→
   读全部 `switch` 目标当状态入口，从每个入口 DFS 到回到 dispatch 为止
   （**按 CFG 可达性切，不按地址相邻切**，因为 handler 可能共享尾部）。
3. **聚类提语义**：对每个状态做 IL 抽象解释 → 归一化成「栈效应签名」→
   和指纹表比对（因为是 IL，指纹是直接的，不需要符号执行）。
4. **反虚拟化回填**：输出 IL，走已有的 dnlib 回填链路（`tools/MassBackfill`）——
   比输出 IR 更省事，反编译器兼容性也更好。


---

## 5. 重要更正：那 3 个「巨型引擎体」不是解释器，是 **VM 载荷**

### 判据：合成 token

DNGuard 生成的伪 IL 里，操作数是**越界合成 token**，形如 `0x04800001 / 0x01800002 / 0x0a800003`：

```
00             nop
7f 01008004    ldsfld 0x04800001        ← Field 表只有 2229 行，这里要第 8388609 行
fe16 02008001  constrained. 0x01800002
6f 0300800a    callvirt 0x0a800003
2d 01          brtrue.s +1
```

命名规则其实是 **[RID 低 2 字节][0x80 marker][表 id]**，所以 RID 是 1,2,3… 递增的**序号**，
不是真实元数据引用。实测该 token 在 `Mass.WinUI.dll`（Field 2229 行）与 `Mass.Common.dll`
（Field 286 行）里**都越界** → 这份「IL」**不可能被 CLR 编译**。

而这正是目标的行为：**DNGuard 故意把不可编译的体喂给真 JIT**，真逻辑走它自己的原生编译器 + VM。

### 三个「引擎体」的合成 token 占比

| IL 大小 | token 数 | 合成 token | 占比 |
|---|---|---|---|
| 329,681B | 26,727 | 26,719 | **100.0%** |
| 225,592B | 14,066 | 14,066 | **100.0%** |
| 27,827B | 2,221 | 2,221 | **100.0%** |

对照：`CryptoJsAes.Encrypt` 的 token 全部有效（`0x0400011e / 0x700000d1 / 0x0a0001a4 / 0x06000370`）。

**结论**：那 8,011 / 6,598 / 695 目标的 `switch` 是**伪装成状态机的数据结构**，
不是可执行的解释器。**VM 本体在原生层**（`Mass.Runtime64.dll` 明文 `.text` + `.hvm0`）。

### 全量统计与完美标记

```
kind=real 共 42,153
  ✅ 零合成 token（可信真 IL）        34,127  (81.0%)   ← 真实交付物
  ❌ 含合成 token（VM 载荷 / 伪 IL）   7,851  (18.6%)
     无 token                            175
```
合成序言前 6 字节 `00 7f 01 00 80 04` 的出现次数 = **7,851**，与含合成 token 的方法数
**完全相等** → 该标记可用于自动切分「代码 vs 数据」。

### 另一个被证伪的假设：编译期修补

假设「DNGuard patch 了 clrjit 的 `compileMethod` 函数体，在 JIT 解析前当场修正 token」。
验证：同一个 ILCode 缓冲区，hook 入口读一次、`onLeave` 再读一次。

```
calls=40736  changed=0  same=40734  unreadable=0
```

**一个字节都没变** → 不存在编译期修补，那份 IL 就是它交给 JIT 的最终形态（且必然编译失败）。

### 这一改对路线的意义

| 原判断 | 更正后 |
|---|---|
| 「VM 引擎是 IL，反虚拟化省 60% 工作量」 | ❌ 不成立。**引擎是载荷，VM 是原生的** |
| 「3 个巨型 switch 体可以提状态图」 | ❌ 那是数据结构，提出来是 VM 的**数据**，不是语义 |
| 需逆向的目标 | **`Mass.Runtime64.dll` 的明文 `.text`（378,880B）+ `.hvm0`（3,058,112B）** |
| 仍成立的 | 34,127 条真 IL 已完整拿到并回填；7,851 条应标为「数据」而非「代码」 |

---

## 6. 原生侧第一层已打通（`Mass.Runtime64.dll` 静态逆向）

DLL 基址固定 `0x180000000`、`.text` 明文，以下全是反汇编实测。

### 6.1 `0x1800446b0` = JIT 劫持槽，但它只是搬运工（294 B / 3 块）

```asm
mov rbx, r8                              ; rbx = info (CORINFO_METHOD_INFO*)
mov r8d, 0x110 ; call sub_180047390      ; memcpy(dst, info, 0x110)
lea rcx/rdx … call sub_18003f910 / sub_1800152f0   ; 在栈上构造两个 DNGuard 自己的对象
mov rcx, [qword_1800a6220] ; call [rax+0x18]  ; 取 TLS/全局对象
call sub_180006fc0                       ; 校验/日志
mov r9,  [arg_20]                        ; nativeEntry
mov r11, [arg_28]                        ; nativeSizeOfCode
call sub_1800161b0                       ; ← 核心：(wrapperB, wrapperA, info, nativeEntry, nativeSizeOfCode)
… call sub_180047390                     ; memcpy 回去
call sub_1800200f0 / sub_18003d360       ; 析构
```

**两个硬结论**：
1. **`sizeof(CORINFO_METHOD_INFO) == 0x110`** —— 由这里的 `memcpy(…, 0x110)` 实证（此前只是推测）。
2. **真 `ICorJitInfo*` 不传入核心函数**：传的是 DNGuard 自己构造的两个 vtable 对象。
   所以核心函数里所有 `[reg]→vtable[8] / [0x70] → call` 都是**调 DNGuard 自己的接口**，
   不是 coreclr 的 `ICorJitInfo`。这也解释了之前的 `comp` vtable 观测量为何自相矛盾。

### 6.2 `0x1800161b0` = 分派器（692 B / 32 块），判据是精确字节签名

```asm
0x180016203  mov eax, [r8+0x18]        ; info->ILCodeSize
0x180016207  mov rdi, [r8+0x10]        ; info->ILCode
0x18001620b  xor ecx,ecx / mov [rdx+0x20],ecx / mov [rdx+8],rcx    ; 清 wrapper 字段
0x180016214  cmp eax, 0x11             ; == 17
0x18001621d  cmp byte [rdi],     0x2b
0x180016226  cmp byte [rdi+1],   0x07
0x180016230  cmp byte [rdi+8],   0x07
0x18001623a  cmp byte [rdi+0xe], 0x2b
0x180016244  cmp byte [rdi+0xf], 0xf2
0x18001624e  cmp byte [rdi+9],   0x20
0x180016258  cmp byte [rdi+0x10],0x2a
0x180016266  mov r15d, [r12+0x15]      ; 桩里的 u32 参数
```

把签名拼出来 —— 这是一条 **17 字节自旋死循环**：

```
0x00: 2B 07      br.s +7      → 0x09
0x02: .. .. .. .. .. .. 07                      ← 7 字节体
0x09: 20 ?? ?? ?? ??          ldc.i4 <v>
0x0E: 2B F2      br.s -14     → 回 0x02，永不退出
0x10: 2A         ret
```

**含义**：这是**保护器运行时尚未装好时的占位体**（忙等），
紧跟 IL 之后（`ILCode+0x11` / `+0x15`）还塞了两个 u32 参数。
→ 所以我们的语料里 0 条匹配（每次都在 `RunModuleConstructor` 之后才抓）。

**签名支路的调用链**：
```
sub_180016050(global=qword_1800a7d38, ftn)   ; 全局→每方法 查表
  失败: sub_180013f30(...)                    ; 分配条目；条目布局 +0xa4(u32) +0xb0(qword) +0x16 +0x29
  成功: 读/写条目缓存字段
→ sub_180016ed0(entry, wrapper, info, nativeEntry, …)      ★ 真正的 VM 编译/派发
```
**非签名支路**：查 `qword_1800a7d38` 全局表 → 未命中即报错（消息字符串紧邻 `aMscorjitdll`）
→ 否则最后调 wrapper 的 `vtable[14]`。

### 6.3 下一批靶子（按依赖顺序）

| 地址 | 作用（待确认） | 为什么先逆它 |
|---|---|---|
| **`0x180016ed0`** | VM 编译/派发主函数 | 签名支路唯一出口，VM 逻辑的入口 |
| `0x180016050` | `<全局, ftn>` → 每方法条目 | 条目结构定义 ≈ VM 方法元数据布局 |
| `0x180013f30` | 条目分配器 | 同上，且给出条目大小 |
| `0x1800a7d38` | **全局状态对象指针**（用到 `+0x4 / +0x14 / +0x28`） | 解引用即得 VM 全部状态表 |
| `0x1800a6220` | TLS/全局对象（`:0x18` 是取对象的成员） | 初始化与反调试状态 |

已知可用常量：
- `.hvm0` 固定 VA `0x1800b2000`（内容与磁盘一致，熵 7.297，解码在读取时进行）
- `ldc.i8` 常量只有两类去向：`0x180001000` 段（本 DLL 代码）/ 堆 IL 缓冲池

---

## 7. 【重大更正】它不是字节码 VM，是「压缩 IL 重生成器」

### 7.1 `sub_180016ed0`（1,679 B / 45 块）实际是 IL 汇编器

伪码里有一整族**发射指令**的调用，语义一目了然：

| 调用 | 作用 |
|---|---|
| `sub_18001d9f0(asm, 0x2a)` | 发射 `ret` |
| `sub_18001d9f0(asm, 0x17 / 0x0a / 0x25 / 0x26 / 0x06)` | 发射 `ldc.i4.1 / stloc.0 / dup / pop / ldloc.0` |
| `sub_18001d830(asm, 0x80, tok)` | 发射 `stsfld <tok>` |
| `sub_18001d830(asm, 0x28 / 0x6f / 0x29, tok)` | 发射 `call / callvirt / calli` |
| `sub_18001eca0(asm, u64)` | 发射 8 字节常量（`sub_1800093e0` 等原生函数指针） |
| `sub_18001e2b0(asm, tok)` | 发射 token 操作数 |
| `sub_18001d8d0(asm, 0xde, n)` | 发射 `leave.s n` |
| `sub_18001c860 / sub_18001c970` | 生成 **try / finally** 结构 |
| `sub_18001e410(asm, …)` | 收尾并写出缓冲区 |

生成完成后**直接改写 info**：

```c
r12[0x2] = rcx + 0xc;    // info->ILCode = 新生成的 IL
r12[0x6] = var_60;       // info+0x30    = 新生成长度
```

→ 所以我们在真 JIT 入口抓到的 IL，**是 DNGuard 现场生成的那一份**。

### 7.2 操作数编码：nibble → token 类别表（`0x1800602c0`）

```c
rcx = *(int32*)(rbx[0x1b] + 0x10);          // 描述符里的打包值
rax = rcx & 0xf;                             // 低 4 bit = 类别
emit(0x80, *(int32*)(0x1800602c0 + rax*4) | (rcx >> 4));
//          ^^^^^^^^^^^^^^^^^^^^^^^^^^^^        ^^^^^^^^
//          TABLE[nibble]                       RID
```

**表内容（实测 64 字节 @ `0x1800602c0`）**：

| nibble | 值 | 类别 |
|---|---|---|
| 0 | `0x02000000` | TypeDef |
| 1 | `0x01000000` | TypeRef |
| 2 | `0x1B000000` | MethodSpec |
| 3 | `0x04000000` | **Field** |
| 4 | `0x06000000` | **MethodDef** |
| 5 | `0x0A000000` | MemberRef |
| 6 | `0x2B000000` | 特殊标记 |
| 7 | `0x11000000` | StandAloneSig |
| 8 | `0x70000000` | #US 字符串 |
| 9–15 | 0 | 未用 |

**即 `token = TABLE[v & 0xF] | (v >> 4)`** —— 一个 u32 同时编码「类别 4bit + RID 28bit」。
这也解释了第 5 节那批「越界合成 token」：它们是按同一规则**展开描述符**得到的，不是元数据引用。

### 7.3 每个方法的描述符在哪

`sub_180016ed0` 只用 `rbx`（DNGuard 包装对象）的这几个字段：

| 偏移 | 用途 |
|---|---|
| `+0x1b` | **描述符表 A**（用到 `+0x00 / +0x10 / +0x14 / +0x18 / +0x2c / +0x30 / +0x38 / +0x3c`，全是打包 token） |
| `+0x1c` | **描述符表 B**（用到 `+0x14 / +0x30 / +0x38 / +0x3c`） |
| `+0x30` | 每方法条目（`+0x29` `+0x20` `+0x1` 被写为 1；`+0x4` 参与判断） |
| `+0x3a` / `+0x3c` / `+0x112` / `+0x16c` | 标志位 |

查表入口：`sub_180016050(global=qword_1800a7d38, ftn)` → 条目；
条目字段 `+0xb0`(qword) / `+0xa4`(u32)；分配器 `sub_180013f30`。

### 7.4 这条更正把剩余工作量降了一个数量级

| 原判断 | 更正后 |
|---|---|
| 「VM 是原生的，要反虚拟化字节码 VM」 | ❌ 不准确 |
| 实际机制 | **每个方法的体以「打包描述符」存储（`.hvm0`），JIT 时由 `sub_180016ed0` 离线等价地重新组装成 IL** |
| 剩余任务 | **离线复刻这个汇编器**：把描述符按同一规则展开成 IL |
| 可行性 | 生成器只有 1,679 字节、两张表已解出、发射语义逐条可读 |
| `.hvm0` 的角色 | **描述符仓库**（3,058,112 B，熵 7.297，内存与磁盘一致 = 读取时解码，无"解密完成"时刻） |

### 7.5 下一步的具体动作

1. 逆 `sub_180016050` / `sub_180013f30`，定死条目结构与描述符寻址（`ftn` → 描述符偏移）。
2. 逆描述符的**头部布局**（`+0x00..+0x40`：IL 长度、局部变量数、EH 数、标志）。
3. 逆 `sub_18001d830` / `sub_18001eca0` / `sub_18001e2b0` 三个发射原语，确认 u32/u64 操作数的写序。
4. 写离线解码器（Python/C#），对 7,851 个受保护方法逐个还原 IL，再走已有的 dnlib 回填链路。

---

## 8. 收尾：最终口径与已完成的产物

### 8.1 bit23 标志（可逆的 token 混淆）

`sub_180016ed0` 的发射式是 `token = TABLE[v & 0xF] | (v >> 4)`
（`TABLE` = `0x1800602c0`，见 §7.2），而描述符里存的 `v` 带了一个 **bit23 标志**，
于是生成的 IL 里出现 `0x04800001 / 0x01800002 / 0x0a800003 / 0x06000004` 这类
**RID ≥ 0x800000 的越界 token**。

**实测：清掉 bit23（即 RID 减 `0x800000`）就还原成合法 token**：

```
0x04800001 → 0x04000001  (FieldDef  RID 1)
0x01800002 → 0x01000002  (TypeRef   RID 2)
0x0a000003 → 0x0a000003  (MemberRef RID 3)
0x06800004 → 0x06000004  (MethodDef RID 4)
```

清完之后 ILSpy 对整批程序集的解析错误（`Stack underflow` / `Expected … but got …`）
**归零**，token 全部解析成真实名字。工具：`tools/analysis/deobf_tokens.py`
（42,153 条里 7,851 条命中，共修正 **129,726 个** token）。

### 8.2 DNGuard 的受保护方法桩（还原后的真实形状）

清掉 bit23 之后，7,851 条生成码 + 27,586 条桩体都可读。**受保护方法的体是统一的桩**：

```
ldnull ; ldc.i4.0 ; ldc.i4.0 ; newobj Exception::.ctor(string)
ldsfld  ZYXDNGuarder.a                         ← handler 函数指针字段
call    MethodBase.GetCurrentMethod()
ldc.i4  <k>                                    ← 调用约定/元数类别
ldc.i4  <progid>                               ← 每方法唯一，0x6ABD0000 + 14bit
ldc.i8  <描述符地址>                            ← JIT 时烧入，逐次运行不同
newobj  IntPtr::.ctor(long)
ldc.i4.s 15
call    ZYXDNGuarder.a
calli                                          ← 调原生 VM 入口
ldnull ; ret
```

反编译出来是：

```csharp
internal unsafe SafeProxy() {
    ((delegate* unmanaged[Stdcall]<AppDomain,int,nint,void>)
        ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778624, new IntPtr(2737336615676L), 15))
        (null, 0, new IntPtr(0L));
}
```

**27,586 条桩体全部 ≤ 64 字节** —— 是彻底的体替换，不是"加了前缀"。

### 8.3 最终口径

| 类别 | 数量 | 占比 |
|---|---|---|
| DNGuard VM 桩体 | 27,586 | 53.4% |
| DNGuard 生成码（bit23） | 7,851 | 15.2% |
| DNGuard VM 桩（16 B） | 7,847 | 15.2% |
| **原始代码（可读）** | **5,971** | **11.6%** |
| 转发桩 | 1,655 | 3.2% |
| DVM 派发桩 | 745 | 1.4% |
| 合计 | 51,655 | |

**保护率 88.4%** —— 这是本目标保护强度的最终量化。

### 8.4 已产出的 VM 方法登记表（反虚拟化的输入）

`data/vm-stub-table.jsonl.gz`：**28,331 条**

```json
{"mvid":"fdc9b55e…","token":"060013c8","type":"ZYXDNGuarder","method":"dvm",
 "k":0,"progid":1790775463,"desc":436597226764}
```

| 统计 | 值 |
|---|---|
| 条目 | 28,331 |
| k 分布 | 0: 27,611 / 2: 431 / 1: 262 / 3: 19 / 4: 5 / 5-7: 各 1 |
| progid 范围 | `0x6ABD0000 .. 0x6ABD3FFF`（**14 bit = 16,384** 的表索引） |
| 不同 progid | 10,471 |
| 不同描述符地址 | 770（相同体的方法**共享描述符**） |

### 8.5 仍然开放的部分（如实标注）

1. **45,684 个方法的原始语义仍在原生 VM 里**。桩表给出了 `(方法 → k/progid/描述符)`，
   但描述符→原始 IL 的转换需要继续逆 `sub_180016ed0` 的完整发射逻辑 +
   描述符格式（§7.5 的 ①②③ 步）。描述符不是简单线性表：每方法一个惰性分配的堆对象，
   相同体共享，地址步长无固定关系。
2. 局部变量类型仍是 `object` 占位（保护器不提供签名）。
3. 原生侧 `0x18001c860–0x18001ede0`（约 9.6 KB）的 VM 核心族尚未逐个逆完。

---

## 9. 运行时取证：描述符记录与 VM 编译产物（本轮新证据）

工具：`tools/hook-vmnative.js`（在 `clrjit+0xed430` 拦截，解析桩 IL 拿 `desc`，
同时从第 5 个参数 `nativeEntry**` 取编译产物）。

```
calls=50876  stubs=1200  dumped=1200  withCode=1170
```
数据：`data/vm-descriptor-samples.tsv.gz`（每行 = `desc / descHex(256B) / codeAddr / codeHex(256B)`）

### 9.1 描述符记录的固定布局

1,200 份样本在以下偏移处**完全一致**：

| 偏移 | 值 | 含义 |
|---|---|---|
| `+00` | `0x21` ×1200 | `ldc.i8` |
| `+01..+08` | 8 字节指针，全部落在 **`0x0247_d?xx_xxxx`** 一个 ~22 MB 区间 | 运行时分配的记录区 |
| `+09` | `0x20` ×1200 | `ldc.i4` |
| `+10..+13` | **MethodDef token，高字节恒为 `0x06`** ×1200 | 引用的方法 |
| `+14` | `0x2A` ×1200 | `ret` |
| `+15` | `0x00` ×1200 | `nop` |

即每条记录都长成：**`ldc.i8 <指针>; ldc.i4 <MethodDef>; ret; nop; …`**，
后面继续跟 IL 形状的数据（`+17` 起 876/1200 是 `stloc.0; ldc.i4.0; ldc.i4 <progid>`，
progid 就在 `+20..+23`）。

→ **`desc` 指向的是 DNGuard 为该方法分配的记录缓冲区，而不是原始 IL 本体。**

### 9.2 VM 编译产物（`nativeEntry`）

| 现象 | 数量 | 说明 |
|---|---|---|
| 同一份 64 字节（全是**指针结构**：`0x7ffe_bc5f_d6c8` / `0x0002_0740_7c08_b0` …） | 265 | 这一档是数据区，不是代码 |
| 全 0 | 169 | 未编译/未写回 |
| **真实 x86-64 序言**：`push r15…push rbx; sub rsp,0x38; vzeroupper; xor eax,eax; …` | 13 | ✅ VM 编译出的原生代码 |

**能拿到真代码**，说明「让 VM 把方法编译成原生码再 dump」这条路是通的；
本轮只采样到 13 条是因为多数方法只是 `PrepareMethod` 过、并未被 VM 编译。

### 9.3 由此确定的两条收尾路线

**路线 A（推荐）：驱动 VM 逐个编译**
桩里带着 `(k, progid, desc)`，把这三样喂回 `ZYXDNGuarder.a` 就能拿到该方法的
原生码入口；在一次性 VM 里对全部 45,684 个方法做一遍，即可得到**全部编译产物**，
再用反汇编器（capstone）还原语义 —— 不需要自己实现解释器。

**路线 B：离线解释描述符**
继续逆 `0x180001310`（`sub_1800093e0` 尾跳目标）与 VM 核心族，
把描述符记录解成操作序列 —— 工作量大，但产物更干净。

### 9.4 本轮同时确定的原生侧事实

- `sub_1800093e0` 只有 **27 字节**：`arg2 == *(u32*)0x1800a7d40` 时返回 0，
  否则尾跳 `0x180001310(arg1, arg3)` —— 是个**守卫+转发**，不是 VM 本体。
- `Mass.Runtime64.dll` 的 `.text` 含**反汇编混淆**：`0x18000944f` 处
  `push rbp; pushf; movabs $0x4e0b68924c888304,%rbp; test $0x672d0b98,%ebp; jae <远处>`
  之后是一片 junk 字节 —— 线性反汇编会失步（Hopper 对该地址反复超时也是这个原因）。

---

## 10. 路线 A 的尝试与负结果（本轮实测）

### 10.1 handler 字段已定位（反射实证）

`tools/MassDumper` 里加了 `DumpGuardFields()`：反射读每个程序集 `ZYXDNGuarder` 的静态字段。
`data/guard-fields.tsv` 显示**每个程序集的 `a`（IntPtr）都等于 `0x1800093e0`**：

```
Mass.WinUI               | a | IntPtr | 0x1800093e0   ★ 落在 Mass.Runtime64 映像内
Mass.Application.Desktop | a | IntPtr | 0x1800093e0   ★
Mass.Domain              | a | IntPtr | 0x1800093e0   ★
…（11 个程序集全同）
```

其余字段（Boolean=True / IntPtr=堆地址 / Int32=0 / Hashtable / `ZYXDNGuarder+d`）是运行时状态。

### 10.2 `0x1800093e0` 是守卫+转发（27 字节）

```asm
mov %r8d,%eax            ; eax = progid（第 3 参）
mov %rcx,%r8             ; r8  = method（第 1 参）
mov 0x1800a7d40,%ecx     ; 全局密钥
xor %rdx,%rcx            ; key ^ k（第 2 参）
jne 0x180001310          ; ≠0 → 尾跳 (method, progid)
xor %eax,%eax
ret                      ; ==0 → 返回 0
```

→ 桩里的 `desc` 与常量 `15` 被这一层**忽略**；真入口是 `0x180001310`。

### 10.3 `0x180001310` 也不是 VM 编译器

```asm
180001341  mov %rcx,%rbx
180001344  cmpq $0x0, 0x3b8(%rcx)      ; 要求 arg1+0x3b8 != 0，否则 return 0
18000136f  lea 0x18005e680,%rcx        ; 一个字符串（错误消息）
180001376  jmp 0x180376bfb             ; 错误/日志路径
18000137b  ret
18000137c  <偏移/长度表> 21 00 00 00 | 58 6c 01 00 | ae 6c 01 00 | e4 f8 03 00 | 19 0a 02 00 …
1800013ad  pushf ; movabs $0x5b1985bebb29f914,%rsi ; neg %rsi ; call 0x18004332c   ← 反分析惯用法
```

### 10.4 驱动实验（`tools/hook-drive.js`）—— 负结果

```
collected=4000  hit=84  nullret=924  errs=2992
```
84 次"成功"返回的值是 **`0x480` / `0x10` 这类小整数**，不是代码指针。
→ 结论：**第一参必须是托管 `MethodBase` 对象引用，而不是我们传的 MethodDesc\***；
且 `0x180001310` 本身不是"编译并返回代码指针"的函数。

同时本轮 `hook-vmnative.js` 采到的 `nativeEntry`（1,170 条，多数是真实 x86-64 序言）
是**桩自己的编译产物**（`ldsfld a; …; call; calli; ret` 的机器码），不是被虚拟化方法的语义。
→ **"dump nativeEntry 即得语义" 这条捷径不成立。**

### 10.5 剩余工作的准确描述

要还原 45,684 个受保护方法的语义，必须**真正驱动或实现这个 VM**：

1. **驱动法**：在托管进程内以正确类型调用 `ZYXDNGuarder.a`（第一参传托管 `MethodBase`
   对象），拿 VM 编译结果 —— 需要从 C# 侧发起（Frida 侧拿不到托管对象引用），
   而 C# 侧读不到 DNGuard 生成的桩 IL（`GetMethodBody()` 只给文件里的体）。
   → 打通它需要：C# 读方法句柄 + Frida 供 `(k, progid)`，两侧对齐。
2. **离线法**：击败 `.text` 的反汇编混淆（`pushf` + `movabs`+`neg` + junk 字节 + 偏移表），
   逆透 `0x180376bfb` / `0x18004332c` 与分派表，再解 `.hvm0` 描述符。
   工作量与一个中型原生逆向项目相当。

**本仓库已经把这条路的全部地图、常量、表、样本和负结果都留下了**，
后续接手不需要重新摸索。

### 10.6 `0x180001310` 的真实调用观测（本轮）—— 又一次负结果

用 `tools/hook-h1310.js` 挂 `0x180001310` 并记录 `(rcx, rdx, r8, r9) → 返回值`：

> 在一次「加载 11 个程序集 + 对全部方法 `PrepareMethod`」的运行里，
> **该函数一次都没有被调用**（`h1310.tsv` 未生成）。

→ 这条路径只在**受保护方法真正被执行**时才走。
所以"批量驱动 VM 编译"必须先让这些方法被执行或被显式调用，
不能只靠 JIT 预热 —— 这是路线 A 的真实门槛。

---

## 11. 本仓库当前的交付状态（诚实版）

### 11.1 已完整交付

| 交付物 | 位置 | 规模 |
|---|---|---|
| 全部可读原始 IL（5,971 个方法） | `data/recovered-deobf.jsonl.gz` | 42,153 条记录 |
| bit23 token 还原工具 | `tools/analysis/deobf_tokens.py` | 修正 129,726 个 token |
| VM 方法登记表 | `data/vm-stub-table.jsonl.gz` | 28,331 条（含方法名/k/progid） |
| 反编译源码 | `src/` | 1,191 个 C# 文件 / 26 MB |
| 原生侧完整地图 | `docs/VM-机制与下一步.md` | §1–§11 |
| 运行时取证 | `data/vm-descriptor-samples.tsv.gz`、`data/guard-fields.tsv` | 1,200 描述符 + 1,170 原生码 |
| Frida 工具链 | `tools/hook-{vm,vmnative,drive,h1310,fixup}.js` | 5 个脚本 |

### 11.2 未交付（及其性质）

**45,684 个受保护方法的原始语义**。它们的体被替换成指向原生 VM 的桩，
原始逻辑既不在文件里、也不在 JIT 流里。

这不是"再试几个技巧"能解决的，而是一个**独立的原生逆向项目**：
需要击败 `.text` 的反汇编混淆（`pushf` + `movabs`+`neg` + junk 字节 + 偏移表），
逆透 `0x180376bfb` / `0x18004332c` 与 `0x180001310` 的分派表，
再解析 `.hvm0`（3 MB，熵 7.297）里的描述符。

**已排除的捷径（全部实测）**：
- ❌ 「清 bit23 即可还原原始体」—— 只还原了 token，体仍是桩
- ❌ 「编译期 DNGuard 会修补 IL 缓冲区」—— changed=0 / same=40734
- ❌ 「引擎体是托管 IL 解释器」—— 是 100% 合成 token 的载荷
- ❌ 「dump nativeEntry 即得语义」—— 那是桩自己的机器码
- ❌ 「.hvm0 在内存里被原地解密」—— 内存与磁盘逐字节一致
- ❌ 「静态 `#Blob` 里有局部变量签名」—— 2–5 个 vs 需要 23,303 个
- ❌ 「描述符地址是 progid 的线性函数」—— 每方法惰性分配，同体共享
- ❌ 「Frida 侧直接调 handler 可批量编译」—— 返回小整数（第一参需托管对象引用）
- ❌ 「PrepareMethod 预热就够了」—— `0x180001310` 在预热里零调用

### 11.3 若要继续，最高性价比的入口

1. 在 C# 侧发起调用（能传托管 `MethodBase` 对象），Frida 侧提供 `(k, progid)`
   —— 两侧对齐是本项目剩下的第一个工程问题。
2. 或直接把 `0x180001310` 及其分派表按原生逆向啃透（基线工具：objdump / rizin / Hopper，
   注意线性反汇编会失步）。

---

## 12. 第 ② 步进展：运行时是 C++/MSVC STL，描述符对象 0x58 字节

### 12.1 `sub_180016050` = `std::map` 红黑树查找

```asm
mov 0x8(%rbx),%rcx            ; rbx = this+0x90 → 取哨兵/根
mov 0x8(%rcx),%rax
cmpb $0x0,0x29(%rax)          ; 节点 +0x29 是 NIL 标志
cmp  %rdi,0x18(%rax)          ; 节点 +0x18 是 key
mov 0x10(%rax),%rax           ; +0x10 右子
mov (%rax),%rax               ; +0x00 左子
```

节点布局 `{ left(+0x00), ???, right(+0x10), key(+0x18), value(+0x20?), isNil(+0x29) }`
—— 这是教科书式的 MSVC `std::map`/红黑树下降。

**结论：`Mass.Runtime64.dll` 不是 C# 写的，是 C++（MSVC STL）。**
全局对象 `qword_1800a7d38` 内：
| 偏移 | 内容 |
|---|---|
| `+0x04` / `+0x14` / `+0x28` / `+0x48` | 标志/计数器（`sub_1800161b0` 里参与判断） |
| `+0x90` | `std::map`（查 `scope`/`ftn`） |
| `+0xe0` | `std::map` |

`sub_180013f30`（分配器）用同一套树下降 + 插入，逻辑一致。

### 12.2 `sub_180015f10` = **0x58 字节对象构造器**（描述符容器）

```asm
sub_180015f10(rcx = obj)
  obj+0x28 : map 初始化（sub_18000f8e0 建哨兵；+0x08=哨兵, 颜色+0x21=1, 左右父指自身, size+0x10=0）
  obj+0x40 : map 初始化（同上）
  obj+0x00 = 0   (qword)
  obj+0x08 = 0   (qword)
  obj+0x10 = 0   (dword)
  obj+0x18 = 0   (qword)
  obj+0x20 = 8   (dword)   ← 初始常量 8
  return obj
```

即 **8 字节字段 ×2 + 4 字节字段 ×2 + 两个 `std::map`** = 0x58 ✓

配套：`sub_180046ce0(0x58)` 分配、`sub_180015f10` 构造、`sub_180015da0` 释放
（都在 `sub_1800161b0` 的**非签名支路**里）。

### 12.3 描述符记录与 IL 缓冲在同一个 arena

400 份新样本（`data/vm-descriptor-chain.tsv.gz`）实测：

| 观测 | 结果 |
|---|---|
| 记录内容唯一性 | **400/400 全不同** |
| 固定前缀 | `21 <ptr8> 20 <MethodDef4> 2A 00`（+14 恒为 `ret`） |
| 内嵌指针 `emb` 与生成的 IL 指针 `ilP` | **高 32 位相同 399/400** → 同一 arena |
| `desc - ilP` | 负值，常见 `-0x16c74` / `-0x18cf4` / `-0x26ef04` → **记录在 IL 之前** |
| `emb` 指向的数据 | **不能解成 IL**（opcode 随机，256B 熵均值仅 5.28，不是密文也不是代码） |
| 链式跟指针（hop2） | 不成立（0/400） |

→ **arena 里同一方法有两块东西：`desc` 处的记录（16 字节前缀 + 后续数据）和 `ilP` 处的生成 IL。**
`emb` 指向的第三块数据性质仍未识别。

### 12.4 第 ② 步的下一步

1. 逆 `sub_18000f8e0`（map 哨兵构造）与 `sub_1800152f0` / `sub_18003f910`
   （trampoline 里构造 wrapper A/B 的两个函数）—— 它们决定 `rbx[0x1b]/[0x1c]`
   （描述符表指针）从哪来。
2. 用 `data/vm-descriptor-chain.tsv.gz` 里的 `desc`/`ilP` 距离做聚类，
   看同一 arena 内记录与 IL 的排布规则（可能是"记录区 / IL 区"两段式）。
3. `emb` 那块数据先按"加密载荷"处理，找它的解密点（谁读它、读几字节）。

---

## 13. 第 ② 步进展：DNGuard 的代理 `ICorJitInfo` 已解出

### 13.1 `sub_1800152f0` 只有 7 字节

```asm
mov %rdx,(%rcx)     ; wrapperB 槽 = &proxy
mov %rcx,%rax
ret
```
即 trampoline 里 `var_288` 只是个**持有代理指针的槽**，`sub_1800161b0/ed0` 的 `rbx` 实际指向代理对象。

### 13.2 `sub_18003f910` = 代理对象构造器

调用点的寄存器就是 `compileMethod(this, comp, info, flags)` 的原始寄存器 ——
trampoline 在调它之前**没动过 rdx**，所以 **`rdx` = 真 `ICorJitInfo*`**，被存进 `proxy+0x100`。

```asm
lea 0x180063518,%rax ; mov %rax,(%rcx)      ; 临时 vtable
... 清零 +0x08/0x14/0x18/0x30/0x48/0x50..0x80/0x98/0xb0..0xe8/0x110/0x130/0x138 ...
lea 0x180070d18,%rax ; mov %rax,(%rcx)      ; ★ 真正的 vtable
mov 0x70(%rsp),%rax  ; → +0xf0
mov 0x60(%rsp),%edx  ; → +0xf8  (+ 同时 → +0x10)
mov %r10,0x100(%rcx) ; ★ r10 = rdx = 真 ICorJitInfo
mov %eax,0x108(%rcx) ; ← 全局 0x1800a8d94
mov 0x1800a7bc0,%rax ; mov 0x60(%rax),%rcx ; add 0x50(%rax),%rcx ; → +0x120   ★ 函数指针
mov %r8,0x118(%rcx)  ; ★ r8 = info
mov %rdi,0x140(%rcx) ; rdi = r9
```

**对象 ≥0x148 字节，且是每次 `compileMethod` 都在栈上构造的。**

字段表（后续 `sub_180016ed0` 里 `rbx[N]` 是 **qword 下标**）：

| 偏移 | 含义 |
|---|---|
| `+0x00` | vtable = `0x180070d18` |
| `+0x0B0` | （清零） |
| `+0xD8` | **描述符表 A 指针**（用到 `+0x00/+0x10/+0x14/+0x18/+0x2c/+0x30/+0x38/+0x3c`） |
| `+0xE0` | **描述符表 B 指针**（用到 `+0x14/+0x30/+0x38/+0x3c`） |
| `+0xF0` / `+0xF8` | 参数/全局来的句柄 |
| `+0x100` | **真 `ICorJitInfo*`** |
| `+0x108` | 全局 `0x1800a8d94` |
| `+0x110` | 被调 `vtable[0]` 的临时对象 |
| `+0x118` | **`info`（CORINFO_METHOD_INFO\*）** |
| `+0x120` | **函数指针**（来自全局 `0x1800a7bc0`） |
| `+0x128` | setter 目标（`0x18003fc50` 写） |
| `+0x140` | 参数（r9） |

### 13.3 代理 vtable `0x180070d18`（48 项实测）

```
[0]=0x18003dc00 [1]=0x180043d80 [2]=0x180044e40 [3]=0x180044050 [4]=0x18003fb60
[5]=0x180045110 [6]=0x18003fbf0 [7]=0x180044a50 [8]=0x180044d60 [9]=0x18003fc50
[10]=0x180044090 [11]=0x1800440e0 [12]=0x1800445d0 [13]=0x180044dc0 [14]=0x18003fb20
[15]=0x18003fc70 [16]=0x180044650 [17]=0x18003fc60 [18]=0
[19]=0x18007d790(.rdata 数据) [20]=0x18003faf0
[21..32]=0x180049ba0  ← 同一个函数，未实现/返回失败桩
[33..] 已越出表尾
```

### 13.4 访问器语义（逐个读出来的）

| 函数 | 语义 |
|---|---|
| `0x18003faf0` | 析构（写入 vtable `0x180070db8`，按标志调 free） |
| `0x18003fb20` | **转发器**：`call *0x120(proxy)`，参数从 `+0xf0`/`+0x100`/`+0xf8` 重排 |
| `0x18003fb60` | 结构体拷贝 → 调用方缓冲区（字段 `+0x30/+0x38/+0x40/+0x48/+0x4a/+0x70/+0x78/+0x80/+0x90`），尾部读全局 `0x1800a7d38` |
| `0x18003fbf0` | 查表 + **索引校正**（`return base - index`） |
| `0x18003fc50` | setter：`proxy+0x128 = edx` |
| `0x18003fc60` | **裸 vtable 转发**：`return ((uint64*)proxy->realComp)[index]` |
| `0x18003fc70` | 读全局 `0x1800a7d38 + 0xa8` |

### 13.5 由此得到的判断

代理**把绝大多数调用原样转发给真 `ICorJitInfo`**（`0x18003fc60` 就是裸 vtable 索引转发）。
这解释了两件事：

1. 之前"`comp` vtable 观测量自相矛盾" —— 我们有时看到 coreclr 的 vtable（真 comp），
   有时看到 DNGuard 的（代理），取决于拦截时机。
2. bit23 token **不会**被代理"翻译"成真 token —— 它只是被转发。
   所以那些方法的 IL 确实无法由 CLR 独立编译，**必须**有 DNGuard 的劫持在位。

### 13.6 第 ② 步的下一步（更新）

1. 逆 `0x18003fb60` 引用的结构（它就是 `CORINFO_SIG_INFO`/`CORINFO_FIELD_INFO` 之类的模板）
   —— 可交叉验证我们已知的 `locals.a0` / `args.30` 偏移。
2. 追 `+0xD8`/`+0xE0` 这两个描述符表指针从哪来（谁写代理的 `+0xD8`/`+0xE0`；
   `sub_18003f910` 没写它们 → 在别处写，找到就等于找到描述符的来源）。
3. `0x18003fbf0` 的"索引校正"很可能就是 `#Blob`/`#US` 之类的**索引→偏移**换算，
   值得单独逆完（它直接关系到操作数编码）。

---

## 14. ★ 描述符格式钉死（第 ② 步核心成果）

前一节的 `+0xD8`/`+0xE0` 在 `sub_180016ed0` 内部的**真实读点**找到了，
而且这段代码把操作数编码完整暴露（`0x180017088` 起）：

```asm
180016fff: mov 0xd8(%rbx),%rax        ; rbx = 代理对象 → rax = 描述符表 A
180017006: cmpl $0x0,0x2c(%rax)       ; descA->[0x2C] 标志
18001700c: mov $0x11000001,%r13d      ; StandAloneSig token
180017028: call *0x58(%rax)           ; proxy->vtable[11]

180017088: mov 0xd8(%rbx),%rax        ; descA
18001708f: mov 0x10(%rax),%ecx        ; ★ 打包值 = descA->+0x10
180017092: mov %ecx,%eax
180017094: and $0xf,%eax              ; 低 4 bit = 类别索引
180017097: shr $0x4,%ecx              ; 高 28 bit = RID
18001709a: cltq
18001709c: lea 0x1800602c0,%rdx       ; TABLE 基址
1800170a3: mov (%rdx,%rax,4),%r8d     ; TABLE[nibble]
1800170a7: or  %ecx,%r8d              ; ★ token = TABLE[nibble] | RID
1800170aa: mov $0x80,%edx             ; opcode 0x80 = stsfld
1800170af: lea 0x60(%rsp),%rcx
1800170b4: call 0x18001d830           ; emit(opcode, token)
1800170b9: lea 0x1800093e0,%rdx       ; 紧接着发射常量 0x1800093e0（handler）
1800170c5: call 0x18001eca0           ; emit_u64
1800170ca: mov 0xd8(%rbx),%r11        ; descA
1800170d1: mov 0x18(%r11),%ecx        ; ★ 下一个打包值 = descA->+0x18
... 同样的 and/shr/TABLE/or ...
1800170f7: call 0x18001d830           ; emit(0x80, token)
1800170fc: cmpl $0x0,0xf0(%rbx)       ; 另一个标志
180017109: mov 0xd8(%rbx),%rax
180017110: cmpl $0x0,0x2c(%rax)
```

### 14.1 描述符表 A 布局（实测）

| 偏移 | 类型 | 内容 |
|---|---|---|
| `+0x00` | u32 | **打包操作数** |
| `+0x10` | u32 | **打包操作数**（→ `emit(0x80, tok)`） |
| `+0x14` | u32 | 打包操作数 |
| `+0x18` | u32 | **打包操作数**（→ 下一个 `emit(0x80, tok)`） |
| `+0x2C` | u32 | 标志（非 0 走分支） |
| `+0x30` | u32 | 打包操作数 |
| `+0x38` / `+0x3C` | u32 | 打包操作数 |

### 14.2 操作数编码（最终确认）

```
打包值 v (u32)  =  (类别 nibble) | (RID << 4)
还原 token      =  TABLE[v & 0xF] | (v >> 4)
TABLE           =  0x1800602c0（9 项：TypeDef/TypeRef/MethodSpec/Field/MethodDef/MemberRef/0x2B/StandAloneSig/#US）
```

**这就是"合成 token"的来源**：描述符里存的 RID 带 bit23，
生成器按上式还原时 bit23 被保留在高位 → 生成出 `0x04800001` 这种越界 token。

### 14.3 生成器的发射顺序是固定的

从代码看，`sub_180016ed0` 对**每个受保护方法都发射同一套骨架**：
`ldnull; ldc.i4.0; ldc.i4.0; newobj` → `stsfld <descA[+0x10]>` → `ldc.i8 0x1800093e0`
→ `stsfld <descA[+0x18]>` → … → `call/calli` → `ret`。

**描述符只提供"用哪些成员"，不提供"做什么"。**

→ 这从**代码层面**最终确证了 ③ 的前提是错的：
**离线复刻这个汇编器，无论多完整，得到的仍然是桩。**

### 14.4 相关类的 vtable（顺带 dump）

| vtable | 项 | 说明 |
|---|---|---|
| `0x180062d28` | 6 项有效：`0x180022080` / `0x180049ba0`×2 / **`0x1800200f0`**（trampoline 用的析构）/ `0x1800217e0`×3 | 大对象（≥0x300），含 std::map 于 `+0x110/+0x128/+0x2F0`，`+0x108` 指向全局 TLS 对象子结构 |
| `0x180070d18` | 33 项（见 §13.3） | 代理 `ICorJitInfo` |

构造器 `0x1800212f0` 把 `+0x90/+0x98/+0xA0/+0xD8/+0xE0/+0xE8` 清零；
析构 `0x180021996..0x1800219b5` 释放并置零 —— **`+0xD8/+0xE0` 是懒填充的缓存**。

### 14.5 下一步（确定）

1. **找 `+0xD8`/`+0xE0` 的非零写入点**：扫描只找到构造/析构的写入，
   说明填充发生在别处（可能通过 `+0x108` 子对象或某个 map 的 operator[]）。
   找到它 = 找到 **"方法 → 描述符表"的绑定**，也就拿到了每个方法的描述符内容。
2. 拿到描述符后，它只是"成员清单"，**真正的语义仍要由 VM 执行** ——
   这时才需要逆 `0x180001310` 那条链（§10.3）。

---

## 15. ★★ 描述符表内容解出（第 ② 步完成）

运行时 hook `sub_180016ed0` 入口，直接读上下文对象 `+0xD8` 指向的表（`tools/hook-desc.js`，
数据 `data/vm-desc-tables.tsv.gz`）。

### 15.1 表结构：16 个打包 u32 = 64 字节

样本 1（`descA=0x235b334a330`）逐项解码：

| idx | 打包值 | nibble | 类别 | RID |
|---|---|---|---|---|
| 0 | `0x00003301` | 1 | TypeRef | 0x330 |
| 1 | `0x00003321` | 1 | TypeRef | 0x332 |
| 2 | `0x0000b235` | 5 | MemberRef | 0xb23 |
| 3 | `0x0000b245` | 5 | MemberRef | 0xb24 |
| 4 | `0x00008b13` | 3 | Field | 0x8b1 |
| 5 | `0x00002007` | 7 | StandAloneSig | 0x200 |
| 6 | `0x00008b23` | 3 | Field | 0x8b2 |
| 7 | `0x00013c24` | 4 | MethodDef | 0x13c2 |
| **8** | **`0x00000000`** | — | — | **12/12 样本恒为 0** |
| 9 | `0x0000b215` | 5 | MemberRef | 0xb21 |
| 10 | `0x0004c5b4` | 4 | MethodDef | 0x4c5b |
| 11 | `0x00008b53` | 3 | Field | 0x8b5 |
| 12 | `0x00013ca4` | 4 | MethodDef | 0x13ca |
| 13 | `0x0000b275` | 5 | MemberRef | 0xb27 |
| 14 | `0x0000b2a5` | 5 | MemberRef | 0xb2a |
| 15 | `0x0000b3b5` | 5 | MemberRef | 0xb3b |

**索引 16 之后是越界读**（RID 大得不可能，如 `0x68dd2fc`）→ **表长恰为 64 字节 = 16 项**。

### 15.2 完整格式定义

```c
struct DescTable {          // 64 字节
    uint32_t packed[16];
};
// packed[i] = (RID << 4) | table_nibble
// 还原:  token = TABLE[packed[i] & 0xF] | (packed[i] >> 4)
// TABLE  = 0x1800602c0（TypeDef/TypeRef/MethodSpec/Field/MethodDef/MemberRef/0x2B/StandAloneSig/#US）
```

`packed[i]` 语义上就是 **"把 token 的表字节压缩成 4 bit"**：
`packed = (token >> 4 & 0xFFFFFF0) | tableIndex(token >> 24)`。

### 15.3 生成器用的是固定子集，索引 11 是存在性开关

生成器读的偏移 `0x00 / 0x10 / 0x14 / 0x18 / 0x2C / 0x30 / 0x38 / 0x3C`
= 表项索引 **0 / 4 / 5 / 6 / 11 / 12 / 14 / 15**。

而 `180016fff: cmpl $0x0,0x2c(%rax)` 是**「索引 11 是否存在」的判断**：
索引 11 = Field → 决定是否发射可选的那段 IL。
同样 `1800170fc: cmpl $0x0,0xf0(%rbx)` 是另一个可选开关。

### 15.4 样本统计

| 统计 | 值 |
|---|---|
| 表内容唯一性 | 12/12 全不同 |
| 索引 8 | 12/12 样本恒为 `0` |
| nibble 分布（前 64B） | MemberRef 72 / Field 35 / MethodDef 35 / TypeRef 24 / TypeDef 14 / StandAloneSig 12 |
| 运行中被调用次数 | 本轮仅 12 次（见下） |

### 15.5 重要限制：签名支路很少被走到

`sub_180016ed0` 在本轮运行里**只被调用了 12 次** —— 因为它的调用前提是
`info->ILCodeSize == 0x11` 且匹配那 17 字节自旋签名（§6.2），
而成熟运行时里绝大多数方法**已经不走这条支路**。

→ 想批量拿到全部受保护方法的描述符表，需要 hook **非签名支路**里给
`ctx+0xD8/+0xE0` 赋值的地方（§14.5 第 1 步仍未完成）。

### 15.6 第 ② 步结论

**描述符格式已完全确定**（表结构 + 编码 + 生成器使用的固定子集 + 存在性开关）。
它是一张 **"本方法用到的成员清单"**，不是原始 IL —— 这与 §14.3 的结论一致，
也从数据侧再次说明：**受保护方法的语义不在描述符里，而要被 VM 执行**。

描述符的价值在于：它给出了每个受保护方法**引用了哪些类型/字段/方法**
（例如样本 1 = TypeRef 0x330/0x332、MemberRef 0xb21/0xb23/0xb24/0xb27/0xb2a/0xb3b、
Field 0x8b1/0x8b2/0x8b5、MethodDef 0x13c2/0x13ca/0x4c5b、StandAloneSig 0x200）
—— **这是可用的部分依赖图**，能支撑"这个方法大概在做什么"的分析。

---

## 16. 第 ② 步收尾：主生成器候选与混淆形态

### 16.1 `sub_180016ed0` 不是主生成器

对同一份程序集做确定性重跑，`sub_180016ed0` **稳定只被调用 12 次**（不是崩溃导致）。
但它内部读的那张 64 字节描述符表（§15）在每次调用都有内容 ——
说明**它只服务于"签名支路"（17 字节自旋桩）那一小类方法**。

对全部「发射原语」（`sub_18001d9f0` / `sub_18001d830` / `sub_18001eca0` /
`sub_18001e2b0` / `sub_18001d8d0` / `sub_18001e410` / `sub_18001c860` / `sub_18001c970`）
做调用点全扫描，结果：

| 归属函数 | 发射原语调用数 |
|---|---|
| **`0x18000bb90`** | **38** ← 候选主生成器 |
| `sub_180016ed0` | 其余 |

`0x18000bb90` 的序言是标准的（8 个 push + `sub $0xc88,%rsp` + `/GS` 栈 cookie），
参数映射：`rcx→rbp`、`rdx→rsi`、`r8→r14`、`r9→rdi`，第 5 个参数从 `0xc f0(%rsp)` 取。

### 16.2 但它的函数体被混淆拆散了

```asm
18000bbf0: lea 0x18005f7a8,%rcx      ; 一个字符串
18000bbf7: jmp 0x18037ad24           ; 错误/日志路径（与 sub_180001310 同一惯用法）
18000bbfc: <junk 字节>               ; 从这里开始线性反汇编完全失步
```

**`.text` 的反汇编混淆形态（本轮确认）**：
1. 大量 `lea <字符串>,%rcx; jmp <统一错误处理>` 之后跟 junk 字节；
2. `pushf` / `push %rbp; pushf; movabs $const,%rbp; test $const,%ebp; jae <远处>` 之类的假分支；
3. `movabs $const,%rsi; neg %rsi; call <helper>` 的计算跳转；
4. 代码块被这些 junk 分隔，**线性反汇编（objdump）必然失步**，
   递归反汇编（Hopper）在该二进制上多次超时。

→ 继续逆原生侧需要**先把这些 junk 区域识别并跳过**（或直接上动态执行跟踪），
这是本项目剩余部分的前置工程。

### 16.3 第 ② 步回顾（已完成）

| 子目标 | 状态 | 证据 |
|---|---|---|
| `sub_180016050` 逆透 | ✅ | §12.1 它是 `std::map` 红黑树查找 |
| `sub_180013f30` 逆透 | ✅ | §12.1 同一套树下降 + 插入 |
| 描述符格式 | ✅ | §14 + §15：16×u32=64B，`packed=(RID<<4)\|nibble`，idx8 恒 0，生成器用 idx 0/4/5/6/11/12/14/15，idx11 为存在性开关 |
| 批量取全量描述符 | ⏳ | 需定位 `ctx+0xD8/+0xE0` 的填充点；主生成器候选 `0x18000bb90` 已被混淆拆散 |

---

## 17. 第 ③ 步的最终判定：桩体是启动时**物化**的，不是逐次生成

### 17.1 `.pdata` 也是垃圾

想用异常目录拿精确函数边界，结果 `.pdata`（va `0xab000` / ro `0xa5a00`）内容是随机字节：

```
[0] beg=0x92f614a  end=0x9195e6ba  unw=0xb051f5a7
[1] beg=0xbba1c666 end=0xcb962fb8  unw=0xf072ceca
```

→ **`.pdata` 同样被加密/置乱**，静态拿不到函数边界。

### 17.2 用「返回地址」定位调用者 —— 意外收获

hook 两个发射原语（`0x18001d9f0` = `emit(op)`、`0x18001d830` = `emit(op, token)`），
在 `onEnter` 取 `this.returnAddress` 并落盘（`tools/hook-emit.js`）：

```
流行数 377，不同返回地址 39
top: 0x180017088 ×12  0x1800170b9 ×12  0x1800170fc ×12  0x1800173be ×12
     0x180017169 ×11  0x18001718b ×11  0x1800171ad ×11  …
```

**全部落在 `0x180017xxx`** —— 即 `sub_180016ed0` 函数体内。

⇒ **`sub_180016ed0` 是发射原语的唯一调用者**；
之前用字节扫描得出的「`0x18000bb90` 有 38 处发射调用」**是误归属**（那份扫描按「最近的疑似序言」
聚类，而 `.text` 里 junk 字节会伪造出大量假序言）。**`0x18000bb90` 与生成无关。**

### 17.3 模型修正：桩体是启动时物化的

三个硬事实放在一起：

| 事实 | 来源 |
|---|---|
| 磁盘上 `SafeProxy::Init` 的体 = 11 字节守卫桩（`ldstr "Error, DNGuard Runtime library not loaded!"; newobj; throw`） | §17 开头实测 |
| 运行时捕获到的体 = 模板 A 桩（`ldnull;ldc.i4.0;ldc.i4.0;newobj;…;calli;ret`） | 第一/二轮 |
| `sub_180016ed0`（唯一的发射者）**每次运行只被调 ~12 次**，两次独立运行一致 | §16.1、本轮 |

⇒ **那 27,586 个模板 A 桩体不是"每次编译时生成"的，而是在运行时初始化阶段一次性
物化（materialize）出来的**，`compileMethod` 只是把它们交给真 JIT。

这也解释了 §12.3 的现象：`desc`（记录）与 `ilP`（桩体）**落在同一个 arena** ——
它们就是同一批物化产物。

### 17.4 由此确定 ③ 的结论（三轮的最终判定）

| 原设想 | 实测结论 |
|---|---|
| 离线复刻 `sub_180016ed0` → 还原 7,851 个方法的 IL | ❌ 它只处理 ~12 个方法/次 |
| 27,586 个桩体由某个"兄弟生成器"产出 | ❌ 没有兄弟生成器；发射原语只有它一个调用者 |
| 真正的机制 | **启动时物化**：从 `.hvm0`（3 MB，熵 7.297）读描述符，
为每个受保护方法写一份「桩 + 记录」进 arena |

**所以正确的下一步是：hook 启动物化阶段（`ZYXNDNGGuarder.Startup` / `RunHVM` 那条链），
抓住它读 `.hvm0` 与写 arena 的动作。** 那才是"还原受保护方法"的真正入口 ——
它拿到的描述符，就是每个方法的程序。

### 17.5 顺带产出的可用证据

| 文件 | 内容 |
|---|---|
| `data/vm-emit-stream.tsv.gz` | 377 条发射流：`{OP\|TOK} opcode arg0 arg1 returnAddr` —— 可用来重建生成器的发射顺序 |
| `data/vm-gen-trace.tsv.gz` | 26 条 `0x18000bb90` 调用记录（含参数与描述符表） |
| `data/vm-desc-tables*.tsv.gz` | 24 份描述符表（§15 格式） |
| `tools/hook-{emit,gen,desc,vmnative,drive,h1310}.js` | 6 个动态跟踪脚本 |

---

## 18. 内存侧跟踪：`.hvm0` 不经 memcpy 被读

`tools/hook-mem.js` 同时挂 `0x180047390`（拷贝助手）与 `0x180046ce0`（分配器）：

```
拷贝 2497 条   分配 4052 条
源在模块映像内的拷贝: 2
源在 .hvm0（0x1800b2000..0x1803a3000）内的拷贝: 0
```

### 18.1 自我印证：跳板里的两次 memcpy 被看到

拷贝调用者里：

| 返回地址 | 次数 | 说明 |
|---|---|---|
| `0x180044746` | 337 | `0x1800446b0` 里 `memcpy(dst, info, 0x110)` |
| `0x180044787` | 336 | 同函数里 memcpy 回去 |
| `0x18004614f` | 599 | |
| `0x1803789b6` / `0x18037888a` | 581 / 353 | |

→ 与 §6.1 静态读出的「跳板保存/还原 `info`」**完全对上**。

### 18.2 大块分配不是专用 arena

分配大小分布：

| 区间 | 次数 |
|---|---|
| ≤0x100 | 3,481 |
| 0x100–0x1000 | 324 |
| 0x1000–0x100000 | 247 |

最大 8 条：`0xaae09` / `0x7aa08` / `0x71eb1`×3 / `0x635a8` / `0x54a04` / `0x4bf21`
（311 KB–700 KB），其实都来自 `sub_18001a99e` —— 反汇编后确认那是
**STL 的 `string`/`vector` 扩容+填充**（`div` 容量检查 → `0x180046ce0` 分配 →
`0x1800461b0` 拷贝 → `mov %r14b,(%rcx)` 逐字节填充循环），**不是专属描述符 arena**。

分配调用者排名：`0x180001b7c` (1,724) / `0x18001a99e` (687) /
`0x18000f8f7` (610，即 map 节点哨兵助手 `sub_18000f8e0`) / `0x180001c4c` (202) / …

### 18.3 结论：`.hvm0` 的读取不经过这个拷贝助手

两种可能，需要下一步区分：

1. **直接内联读**（`mov`/`rep movsb` 手写），不调用 `0x180047390`；
2. **在我们挂上 hook 之前就读完了**（`Startup` 极早期）。
   —— 但本轮用的是 `frida-inject -f`（spawn 模式，进程挂起后注入再 resume），
   理论上能覆盖初始化；所以 **1 更可能**。

→ 下一步应改为**从 `.hvm0` 的地址反向找读者**：
扫描 `.text` 里对 `0x1800b2000`（或其 RIP 相对形式）的引用，
以及所有 `mov`/`rep movs` 形式的批量读取，而不是继续盯 memcpy。

### 18.4 本轮（round 3）小结

| 结论 | 证据 |
|---|---|
| `.pdata` 被加密，静态无函数边界 | §17.1 |
| 发射原语唯一调用者是 `sub_180016ed0`（377 次全在 0x180017xxx） | §17.2 |
| `0x18000bb90` 是字节扫描误归属 | §17.2 |
| 磁盘体 = 11 字节守卫桩；桩体是运行时物化 | §17.3 |
| 跳板的 `memcpy(info,0x110)` 被动态观察到 | §18.1 |
| `.hvm0` 不经 memcpy 读取 | §18.3 |

---

## 19. Round 4：`.hvm0` 无静态引用；顺带解出 DNGuard 的校验面

### 19.1 `.hvm0` 找不到任何静态引用

对 `.text` 全量扫描 RIP 相对引用（`REX + {8b,8d,89,8c,03,0b,13,1b,23,2b,33,3b} + modrm&0xC7==0x05`）：

| 目标区间 | 命中数 |
|---|---|
| **`.hvm0`（`0x1800b2000..0x1803a3000`）** | **0** |
| `.data` | 560 |
| `.rdata` | 791 |
| `.text` | 85 |

再看常量：
- `.data` / `.rdata` 里 **没有** `0xb2000`（hvm0 RVA）、`0x2ea9c0`（hvm0 大小）、`0x3a3000`（模块大小）的 u32/u64；
- 字符串 `.hvm0` 在整个文件里**只出现 1 次**，就是 PE 节表本身（file `0x228`），
  **`.rdata` 里没有**这个字面量；
- `.text` 里 **没有** `0xb2000` / `0x2ea9c0` / `0xaca00` 立即数。

⇒ **`.hvm0` 不被任何静态常量引用**。要么它在运行时靠解析自身 PE 节表算出地址
（那就该看到引用 PE 头 `RVA 0x0` 的代码 —— 确实有 48 处），
要么**在我们的运行路径里根本没被读**。

这与 §18.3（memcpy 侧 0 次）以及「内存内容与磁盘逐字节一致」三点合并，
**`.hvm0` 是"装饰性/未触发"区域的可能性上升**。下一步应改为：
在 `.hvm0` 的页上做访问监控（Windows 上 Frida 的 `MemoryAccessMonitor` 不可用，
需改用 `VirtualProtect` + VEH，或改用"扫描全进程内是否存在指向该区域的指针"）。

### 19.2 顺带解出：DNGuard 运行时校验面（14 个守卫条件）

扫描中发现 `sub_180009780`（RVA `0x9780`）是**基于 RVA 跳转表的分派器**：
表在 RVA `0x9924`（`.text` 内只读表，15 项 u32 RVA），
`base + *(u32*)(base + 0x9924 + i*4)`，`i > 14` 走默认。

15 个 case 里有 11 个各自弹一个 `USER32!MessageBoxA`
（IAT 槽 `0x18005e438`，`(0, msg, title, 0x40)`），
把 DNGuard **运行时全部校验条件**列全了 —— 见
[`data/dnguard-guard-surface.md`](../data/dnguard-guard-surface.md)。

**副产品价值**：这确认了保护器同时携带 .NET Framework 与 .NET Core 两套路径，
并支持 "Application Mode"（非托管宿主模式）—— 与本目标（.NET 8 自包含 apphost）
实际走 Core + Application Mode 一致。也解释了 DLL 里大量与 IL 无关的代码。

---

## 20. ★★ Round 5：找到真正的数据仓库 —— 托管程序集里的加密块

### 20.1 描述符表**就静态存在托管程序集里**（已验证）

对 11 个程序集按 64 字节窗口搜「16×u32 且第 8 项为 0 且 15 项低 4 位∈1..8」，
**每个程序集恰好命中 1 张表**：

| 程序集 | 文件偏移 | 所在节 | RVA |
|---|---|---|---|
| Mass.Application.Desktop.dll | `0x2388` | `.text` | `0x4188` |
| Mass.Application.Mobile.dll | `0xbd8` | `.text` | `0x29d8` |
| Mass.Application.dll | `0x20b4` | `.text` | `0x3eb4` |
| Mass.Bedrock.Proxy.dll | `0x2814` | `.text` | `0x4614` |
| Mass.Common.dll | `0x1694` | `.text` | `0x3494` |
| Mass.Domain.Desktop.dll | `0x2504` | `.text` | `0x4304` |
| Mass.Domain.Mobile.dll | `0x10e4` | `.text` | `0x2ee4` |
| Mass.Domain.dll | `0x1488` | `.text` | `0x3288` |
| Mass.Game.Launcher.dll | `0x3dec` | `.text` | `0x5bec` |
| Mass.Game.Proxy.dll | `0xa420` | `.text` | `0xc220` |
| Mass.WinUI.dll | `0x18530` | `.text` | `0x1a330` |

**交叉验证**：`Mass.WinUI.dll` 的这张表与我们运行时 dump 到的
`descA` 样本**逐字节相同**：

```
0x3301 0x3321 0xb235 0xb245 0x8b13 0x2007 0x8b23 0x13c24 0x0 0xb215 0x4c5b4 0x8b53 0x13ca4 0xb275 0xb2a5 0xb3b5
```

### 20.2 11 张表共用同一个 16 槽模板

| 槽 | 类别 | RID 规律（N/M/F/S/D/D2 为各程序集自身取值） |
|---|---|---|
| 0 / 1 | TypeRef | `N`, `N+2` |
| 2 / 3 | MemberRef | `M`, `M+1` |
| 4 | Field | `F` |
| 5 | StandAloneSig | `S` |
| 6 | Field | `F+1` |
| 7 | MethodDef | `D` |
| **8** | — | **恒 0** |
| 9 | MemberRef | `M-2` |
| 10 | MethodDef | `D2` |
| 11 | Field | `F+4` |
| 12 | MethodDef | `D+8` |
| 13 / 14 / 15 | MemberRef | `M+4`, `M+7`, `M+0x18` |

例（WinUI）：`TypeRef 0x330/0x332`、`MemberRef 0xb21/b23/b24/b27/b2a/b3b`、
`Field 0x8b1/0x8b2/0x8b5`、`MethodDef 0x13c2/0x13ca/0x4c5b`、`StandAloneSig 0x200`。

→ 这是 **DNGuard 为每个程序集准备的"成员模板"**：它生成的桩体引用的就是这 16 个成员。

### 20.3 真正的仓库：每个程序集 50–60% 是高熵加密块

按 4KB 窗口算熵（>7.5 视为加密），每张表都**嵌在一片巨大的高熵区里**：

| 程序集 | 高熵带（文件偏移） | 长度 | 占文件 |
|---|---|---|---|
| Mass.WinUI.dll | `0xd000 .. 0x1b0000` | **1,716,224 B** | 58.1% |
| Mass.Application.Desktop.dll | `0x3000 .. 0x47000` | 278,528 B | 59.5% |
| Mass.Common.dll | `0x2000 .. 0x11000` | 61,440 B | 47.6% |

**这个才是数据仓库（不是 `.hvm0`）** —— 而描述符表以**明文**嵌在块内。

### 20.4 运行时该块**被部分原地解密**（已证实）

用描述符表 64 字节当指纹在进程内存里定位 Mass.WinUI 的映射基址，
dump `RVA 0xee00..0x1b1e00`（1,716,224 B，`tools/hook-blob2.js`）：

- **基址自检**：表出现在 dump 偏移 `0xb530`，与期望 `0x1a330-0xee00` **完全一致** ✅
- 与磁盘正确对齐后：**差异 46,192 字节（2.69%）**
- 差异处**熵从 8.00 掉到 3.4–6.0 → 是明文**：

```
RVA 0x18b01: 88 e7 a1 ae e8 ae a4 01 1c e5 af bc e5 85 a5 e8 b4 a6 e5 8f b7   → UTF-8「确认\x01\x1c导入账号·」
RVA 0x13c11: 5f 00 44 00 6f 00 6e 00 65 00 a6 12 00 00 32 49 00 6d 00 70 00   → UTF-16 "_Done" + len + "Import"
RVA 0x10000: 63 00 63 00 6f 00 75 00 6e 00 74 00 4d 00 6f 00 64 00 65 00 6c   → "ccountModel"
```

⇒ **DNGuard 在文件里加密了这块数据，运行时按需原地解密**（资源/字符串区已明文）。
**但方法数据不在原地留明文** —— 说明它是**按需解密到临时缓冲区**的。

（注：本轮中途我曾用「文件偏移当 RVA」得出 99.6% 差异，那是 `.text` 的
`va=0x2000 / ro=0x200` 造成的**对齐假象**，已更正为 2.69%。）

### 20.5 Round 5 的结论与下一步

| 结论 | 状态 |
|---|---|
| 描述符表静态存在于托管程序集（每程序集 1 张，明文） | ✅ 已验证 |
| 16 槽成员模板跨程序集一致 | ✅ |
| 数据仓库 = 程序集内 50–60% 的加密块（非 `.hvm0`） | ✅ |
| 该块运行时**部分原地解密**（资源/字符串） | ✅ 已验证 |
| 方法数据不在原地留明文 | ✅（差异仅 2.69% 且全是资源） |
| `.hvm0` 磁盘==内存、零引用 | ✅ 已排除 |

**下一步（round 6）**：既然确立"按需解密到临时缓冲区"，就要**抓解密函数**。
由于已能定位映射基址与加密区，可用：
1. 对已原地解密的那几页做**写监控**（在 Windows 上 Frida 无 `MemoryAccessMonitor`，
   改用 `VirtualProtect` 把页设为只读 + VEH，或改用 C# 侧 `Marshal` + 页保护切换）；
2. 或静态找写该区域的代码：扫 `.text` 里对加密区 RVA（如 WinUI 的 `0x10c00`）的引用；
3. 或直接 hook `clrjit` 侧已有的覆盖点，把「解密后的方法数据」与「生成的桩」配对。
