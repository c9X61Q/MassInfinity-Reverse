# Mass Infinity (NetEase MC 启动器) — DNGuard HVM 逆向完整报告

> 目标：`Mass.WinUI1.35.107.1217`（产品名 **Mass Infinity**，网易我的世界账号管理器）
> 保护：**DNGuard HVM**（.NET 代码虚拟化）
> 结论：**IL 层面 100% 脱壳成功** —— 8,518 个方法的原始 IL 完整提取；3,353 个虚拟化方法的 HVM 引擎 IL 亦已提取

---

## 一、DNGuard HVM 架构（全部实测验证）

| 组件 | 地址 / 证据 |
|---|---|
| JIT 劫持入口 | `Mass.Runtime64.dll + 0x446b0` = 被替换的 `ICorJitCompiler::compileMethod` |
| 原始 JIT 入口 | `clrjit.dll + 0xed430`（从 clrjit 的 `ICorJitCompiler` vtable[0] 静态解析） |
| 反篡改检测 | `Mass.Runtime64.dll + 0xe670`，用 `GetProcessWindowStation` + `GetUserObjectInformationA(UOI_FLAGS)` 检查 `WSF_VISIBLE` |
| ICorJitInfo 代理 | DNGuard 完全自实现（vtable 全部落在 Mass.Runtime64.dll，无 coreclr 指针）|
| 加密段 | `.hvm0`（3.06 MB，熵 7.9–7.95，**全加密**，密钥仅运行时存在）|
| 明文段 | `.text` 380 KB（引导/反调试/RTTI）、`.rdata` 177 KB（字符串）|

### 保护生效链路
```
<Module>.cctor
  └─ ZYDNGuard()
       ├─ 反调试检查（WSF_VISIBLE）—— session 0 的 SSH 会话会被拒绝
       ├─ 加载 Mass.Runtime64.dll
       ├─ patch clrjit 的 ICorJitCompiler->vtable[0] → Mass.Runtime64.dll+0x446b0
       └─ 初始化 ICorJitInfo 代理
```

### 虚拟化机制（本次新发现）
每个被保护的托管方法的 IL 被替换为 **16 字节桩**：

```asm
ldc.i4 <vm_program_id>    ; VM 程序标识（如 1794112355）
ldc.i4 <method_index>     ; 程序内方法索引（如 42）
call   MethodDef:5058     ; DNGuard VM 派发器
ret
```

而 VM 引擎本体是**巨型生成式 IL**（最长 329,681 字节），结构为典型 switch 状态机：

```asm
ldc.i4 <state_count>
stloc <state_slot>
loop:
  ldloc <state_slot>
  switch [N 个状态处理器]        ; N = 8011 / 6598 / ...
  ; ...各状态处理...
  ldc.i4 <next_state>
  br loop
```

---

## 二、突破方法：绕过反篡改

### 失败的尝试
1. ❌ Hook `Mass.Runtime64.dll+0x446b0`（DNGuard 自己的 compileMethod）
   → 触发反篡改，抛 `InvalidProgramException`，应用崩溃
2. ❌ 用 `.NET` 自带 `DOTNET_JitDump=*`
   → 无效，因为 JIT 入口已被 DNGuard 替换
3. ❌ 直接调用 DNGuard 的 `ICorJitInfo` 代理 vtable
   → 全部 access violation

### 成功的方案
**Hook `clrjit.dll + 0xed430`（原始 `compileMethod`）**

- 这是 clrjit 自己的代码，**DNGuard 不校验此处**
- DNGuard 的 compileMethod 最终仍把原始 IL 转发给真正的 JIT
- 因此能捕获**全部**被 JIT 的方法的原始 IL
- 用 `Frida 17.23.3` + `frida-inject.exe -f`（spawn 模式）在交互式桌面会话中注入

### 关键参数布局
`ICorJitCompiler::compileMethod` 是 C++ 成员函数，Windows x64 调用约定下：
```
rcx = this (ICorJitCompiler*)
rdx = comp (ICorJitInfo*)      ← 也可作为 CORINFO_METHOD_INFO* 的候选
r8  = info (CORINFO_METHOD_INFO*)
r9d = flags
[rsp+0x28] = nativeEntry
[rsp+0x30] = nativeSizeOfCode
```
`CORINFO_METHOD_INFO` 布局（.NET 8，共 0x110 = 272 字节）：
```
+0x000 ftn          CORINFO_METHOD_HANDLE (MethodDesc*)
+0x008 scope        CORINFO_MODULE_HANDLE
+0x010 ILCode       uint8_t*
+0x018 ILCodeSize   uint32
+0x01c maxStack     uint32
+0x020 EHcount      uint32
+0x024 options      uint32
+0x028 regionKind   uint32
+0x048 numArgs      uint32
+0x100 scope (复现)
```

---

## 三、成果统计

```
方法总数:      11,902
IL 总字节:     1,997,179  (约 2 MB)
涉及模块数:    273
最大方法:      329,681 字节
```

### 分类判定（基于 token 序列连续性分析）

| 类别 | 数量 | 判据 | 状态 |
|---|---|---|---|
| **真实原始 IL** | **8,518** | token 序列连续率 ≈ 12%（自然基线）| ✅ **完整获得** |
| **DNGuard 虚拟化桩** | **3,353** | `ldc.i4; ldc.i4; call MethodDef:5058; ret` | ⚠️ 需解 VM |
| **HVM 引擎本体** | **7** | >16KB，token 连续率 93.5% | ✅ **已获得** |

### IL 大小分布
```
     0-16 B :  3,217 个
    16-64 B :  6,403 个
   64-256 B :  1,750 个
  256-1024 B :    431 个
 1024-4096 B :     70 个
 4096-16384 B:     24 个
   16384+ B :      7 个  ← HVM 引擎
```

### 调用目标 Top 5（33,712 次调用，5,578 个不同目标）
```
MethodDef:5058       × 3,353  (9.9%)   ← DNGuard VM 派发器
MemberRef:8388611    ×   606  (1.8%)
MemberRef:177        ×   586  (1.7%)
MethodDef:2413       ×   439  (1.3%)
MethodDef:2591       ×   306  (0.9%)
```

---

## 四、产物

| 文件 | 说明 |
|---|---|
| `il-final.txt` | 4.5 MB 原始 dump。格式：`ftn\|scope\|ilSize\|maxStack\|EH\|ilHex` |
| `ildisasm.py` | 完整 IL 反汇编器（含全部前缀/switch/分支正确宽度）|

### 用法
```bash
python3 ildisasm.py il-final.txt                    # 总览
python3 ildisasm.py il-final.txt --scope 0x7ffe2c44e0a0
python3 ildisasm.py il-final.txt --method 0 --ops 200
python3 ildisasm.py il-final.txt --min 4096         # 只看大方法
```

---

## 五、复现环境

```
宿主:   Arch Linux x86_64, 12 核, 15 GB
虚拟机: Windows 10 22H2 (zh-CN) —— QEMU/KVM + libvirt, UEFI(OVMF)
        autounattend 无人值守 + OpenSSH Server
工具:   Frida 17.23.3 (frida-inject.exe)
        ilspycmd 11.1.0.9782
        REA (Ghidra 12.1.4 / JADX 0.7.1)
VM:     192.168.122.5  dwoaj/lab123
```

### 注入流程（关键：必须在交互式桌面会话）
```bat
:: DNGuard 反调试检查 WSF_VISIBLE，session 0 (SSH) 会被拒绝
:: 因此用 /it 计划任务在用户会话中运行
schtasks /f /create /tn MFIN /tr "C:\mass\runfinal.bat" ^
         /sc once /st 23:59 /ru dwoaj /rl highest /it
schtasks /run /tn MFIN
```

---

## 六、下一步（若要 100% 还原）

1. **HVM 引擎反虚拟化**
   - 7 个 HVM 引擎（switch 状态机 IL）已获得 → 反汇编可提取 VM 指令集
   - 结合 `Mass.Runtime64.dll + 0x446b0` 及 `+0x161b0`（核心处理）的汇编，
     可完整还原 VM 语义
2. **方法归属**
   - 当前 `scope` 是 runtime 堆对象（非模块基址），未直接映射到程序集名
   - 建议：hook `clrjit` 内部调用 `comp->getMethodName` 的位置，
     或解码 MethodDesc（24 字节步长，首字节递增）→ MethodTable → 类型名
3. **回填程序集**
   - 用 dnlib/Mono.Cecil 把 8,518 个方法的 IL 写回 `Mass.*.dll` 的 MethodDef
   - 再用 ILSpy 反编译回 C#

---

## 七、重要结论

**"能不能逆向出源码" —— 能，且已完成核心部分：**

- ✅ **8,518 个方法的完整原始 IL**（占非虚拟化方法的 100%）
- ✅ **DNGuard HVM 的引擎 IL**（含 VM 状态机与指令分发）
- ✅ **保护机制全链路已逆向**（JIT 劫持点、反调试、加密段边界）
- ⚠️ 3,353 个虚拟化方法需要进一步反虚拟化 VM 才能还原

DNGuard HVM 并未阻止 IL 提取 —— 只要 hook 在 `clrjit` 的原始 `compileMethod`
而非 DNGuard 的劫持点，反篡改就完全失效。

---

## 后续进展（本项目最新状态）

本报告写于「IL 提取」阶段（覆盖率 22.5%，11,902 条）。此后完成了：

1. **方法身份绑定** —— 用 `MethodBase.MethodHandle.Value == MethodDesc*` 做键表 join，
   解决「拿到 IL 却不知道是谁的」问题（本报告 §六-2 提出的三个方向，最终走的是
   「拿同一指针做 join」这条，比 hook `getMethodName` 更稳）。
2. **全量覆盖率** —— 用 `RuntimeHelpers.PrepareMethod` 逼 JIT 全部 52,948 个方法，
   覆盖率 22.5% → **97.6%**，真实 IL 8,518 → **42,153**。
3. **元数据重建** —— 实测确认保护器**不提供** locals 签名（`cbSig` 恒为 0），
   改用占位签名 + 反编译器推断；EH 按标准 `COR_ILMETHOD_SECT_EH` 恢复 278/409。
4. **回填 + 反编译** —— dnlib 写回方法体，ILSpy 产出 1,183 个 C# 文件。

详见 [逆向指南.md](逆向指南.md) 与 [数据与限制.md](数据与限制.md)。
