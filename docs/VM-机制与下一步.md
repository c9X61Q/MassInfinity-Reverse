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

### ③ 引擎层：**托管 IL**，且每个程序集各带一套

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
