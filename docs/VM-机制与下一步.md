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
