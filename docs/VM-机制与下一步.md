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
