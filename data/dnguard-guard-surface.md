# DNGuard 运行时校验面（从 Mass.Runtime64.dll 静态解出）

**派发器**：`sub_180009780(index)` @ RVA `0x9780`
**跳转表**：RVA `0x9924`（位于 `.text` 内的只读表），15 项 u32 RVA
**派发方式**：`base + *(u32*)(base + 0x9924 + index*4)`，`index > 14` 越界走默认
**弹窗函数**：`USER32!MessageBoxA`（IAT 槽 `0x18005e438`），调用约定 `(0, msg, title, 0x40)`

```asm
180009780: push rbx / sub $0x30,%rsp
18000978f: movslq %ecx,%rbx              ; index
1800097a0: cmp $0xe,%ebx
1800097a3: ja  0x180009917               ; 越界 → 直接返回
1800097a9: lea 0x180000000,%rdx          ; 模块基址
1800097b0: mov 0x9924(%rdx,%rbx,4),%ecx  ; 取 RVA
1800097b7: add %rdx,%rcx / jmp *rcx      ; 跳 case
```

## 14 个守卫条件（case → 消息）

| case | 标题字符串 | 消息字符串 |
|---|---|---|
| 0 | `DNGuard HVM` | `A newer version of DNGuard Runtime library is needed to run this application.` |
| 1 | `Trial Expired` | `Your trial period has expired,\nplease contact your software provider.` |
| 2 | `DNGuard HVM` | `This application is protected by DNGuard demo version, can't run on this Computer!` |
| 3 | `Expired!` | `DNGuard HVM demo time expired !` |
| 4 | `DNGuard HVM` | `This application is protected by DNGuard HVM demo version!.` |
| 5–8 | — | （默认分支，直接返回） |
| 9 | `DNGuard HVM` | `This application is protected for .Net Core, can't run under .Net Framework!` |
| 10 | `DNGuard HVM` | `This application is protected for .Net Framework, can't run under .Net Core!` |
| 11 | `DNGuard HVM` | `This application is protected for .Net Framework 4.5 and above, please upgrade your .Net Framework!` |
| 12 | `DNGuard HVM` | `This application is protected for Application Mode, please run from application mode!` |
| 13 | `DNGuard HVM` | `This application is protected for .Net Core!` |
| 14 | `DNGuard HVM` | `This application is protected for .Net Framework!` |

## 意义

- 这是 DNGuard HVM **运行时全部校验条件**的枚举：运行库版本、试用期、demo 版限制、
  .NET Core / Framework 模式匹配、Application Mode 要求。
- 说明该保护器支持 **.NET Framework / .NET Core 双模式**与 **Application Mode**（非托管宿主模式），
  与本目标（.NET 8 自包含 apphost）实际走的是 Core + Application Mode 组合一致。
- 也解释了为什么该 DLL 里有大量与 IL 无关的代码：它同时携带 Framework 与 Core 两套路径。
