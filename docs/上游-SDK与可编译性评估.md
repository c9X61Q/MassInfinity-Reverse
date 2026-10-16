# 上游 SDK 与「可编译的 Mass」可达成性评估

> 本文回答一个具体问题：**要拿到"能直接编译出 Mass 的源码"，现在还差什么？**

---

## 1. 结论先说

| 层 | 现状 | 来源 |
|---|---|---|
| **服务端 API 层**（HTTP 客户端、鉴权、DTO、序列化） | ✅ **有权威源码** | 上游官方 SDK（**MIT**）：`refs/upstream-mass-sdk` |
| **客户端 UI / 视图模型 / 页面** | 🟡 部分（约 30–60%/类） | 本项目反编译产物 `src/`（1,191 个文件 / 23.4 M 字符） |
| **游戏代理 / Bedrock 代理 / Java 启动器** | 🟡 部分（约 30–45%/类） | 同上 |
| **被 DNGuard HVM 保护的方法** | ❌ 语义不在任何可取出的产物里 | 见 `docs/VM-机制与下一步.md` §14–§25 |

**⇒ 现在能拼出"可编译"的骨架：官方 SDK（权威 API 层）+ 已恢复的客户端代码（UI/逻辑/代理）。**
**⇒ 但"与官方 Mass 行为等价"仍不成立**，因为 88.4% 的客户端方法语义缺失（见 §4）。

---

## 2. 上游有什么（已入库为 `refs/`）

### 2.1 `Mass.Sdk`（C#，MIT）—— 官方客户端 SDK

来源 <https://github.com/massarolucien/Mass.Sdk>，本仓库以**原样副本**保存于
`refs/upstream-mass-sdk`（含其 `LICENSE`；MIT，Copyright (c) 2026 massarolucien）。

结构：

```
Mass.Sdk/
├── MassClient.cs                 SDK 总入口（RestSharp + SignalR + 鉴权）
├── Desktop/DesktopClient.cs      桌面端登录（Cookies/163/手机号/短信/4399）
├── Mobile/MobileClient.cs        移动端登录
├── Instance/InstanceClient.cs    实例管理（列举/关闭）
├── Desktop|Mobile/Models/*.cs    会话与游戏/皮肤/角色模型
├── Models/Account/*.cs           账号 DTO（AccountInfoDto / SessionDto / 平台 / 类型）
├── Serialization/*.cs            JSON 转换器（时间戳、字符串布尔、实例多态）
└── ...                           Enums / Interfaces / Helpers
```

**完整 API 端点（从源码提取，共 20 个）**：

```
/api/base/ping                     /api/security/login
/api/desktop/login/cookies         /api/desktop/login/163
/api/desktop/login/mobile          /api/desktop/login/mobile/send
/api/desktop/login/mobile/verify   /api/desktop/login/4399pc
/api/desktop/login/4399com         /api/desktop/login/random-4399com
/api/mobile/login/cookies          /api/mobile/login/163
/api/mobile/login/mobile           /api/mobile/login/mobile/send
/api/mobile/login/mobile/verify    /api/mobile/login/4399com
/api/mobile/login/random-4399com   /api/instance/list
/api/instance/close                /api/instance/close-all
```

**SignalR Hub 事件**（`MassClient.Progress`）：`Progress(step,total,percentage,message)`、
`GameInstance`、`Disposed`。

默认本地服务地址 `http://127.0.0.1:23333`，端口自增探测（`FindAsync(startPort,tryTimes)`）。

### 2.2 `mass-java-sdk`（Java，MIT）

同一套协议的 Java 实现，来源 <https://github.com/massarolucien/mass-java-sdk>。
未入库（避免冗余），需要时按上面的地址取。

---

## 3. 交叉验证：SDK 与目标程序是同一套协议

| 检验 | 结果 | 说明 |
|---|---|---|
| 目标 DLL 里是否含 SDK 的端点字符串 | **0 命中**（`/api/...` 全部找不到；仅 1 处 `/api/system`） | ⇒ 客户端的 HTTP 层**本身就在被保护的方法里** |
| 类型名是否对应 | **对上** | 目标侧有 `Mass.Application.Desktop.DesktopSession`、`Mass.Game.Proxy.Extensions.DesktopSessionExtensions`（我们的反编译产物里就有） |
| 领域模型是否对应 | **对上** | SDK `DesktopNetGame/DesktopSkin/AccountInfoDto` ↔ 目标侧 `Mass.Domain.Desktop.Entities.NetGame.EntityNetGameDetails`、`...Skin.EntitySearchSkinItemDto`、`Mass.Domain.Entities.Mass.EntityMassUser` |

⇒ SDK 与目标程序面向**同一个 Mass 服务协议**；SDK 提供的那一层，
恰好是目标程序里**看不见（被保护）**的那一层。

---

## 4. 已恢复源码的可用性盘点（`src/`，1,191 个文件）

统计口径：文件字符数 / **桩标记数**（`ZYXDNGuarder` 或 `throw new Exception("Error, DNGuard…` 出现次数）/
成员声明数（按 `public|internal|private|protected … 方法名(` 计数）。
> 注意：桩标记是**出现次数**，同一成员体里可能多次出现，故"恢复率"只是近似，不是精确比例。

**全局：23,443,205 字符 / 43,997 个成员声明 / 37,809 处桩标记 ≈ 14% 可读。**

体量最大的 12 个文件：

| 字符 | 桩标记 | 成员 | 近似恢复率 | 文件 |
|---|---|---|---|---|
| 2,303,920 | 2,147 | 4,865 | 55.9% | `Mass.WinUI/Mass_WinUI_XamlTypeInfo/XamlTypeInfoProvider.cs` |
| 914,468 | 5,439 | 5,436 | ~0% | `Mass.WinUI/ZYXDNGuarder.cs`（DNGuard 注入的槽位池） |
| 627,927 | 441 | 646 | 31.7% | `Mass.Application.Desktop/DesktopSession.cs` |
| 576,674 | 1,471 | 971 | ~0% | `Mass.WinUI.Localization/Strings.cs` |
| 511,477 | 214 | 376 | 43.1% | `Mass.Game.Launcher.Java/JavaGame.cs` |
| 480,097 | 246 | 362 | 32.0% | `Mass.WinUI.ViewModels/AccountViewModel.cs` |
| 457,081 | 320 | 456 | 29.8% | `Mass.WinUI.ViewModels/DesktopViewModel.cs` |
| 338,812 | 215 | 318 | 32.4% | `Mass.Game.Launcher.Java.LanGame/DesktopTransfer.cs` |
| 244,603 | 163 | 229 | 28.8% | `Mass.WinUI.Models/DesktopGameModel.cs` |
| 242,767 | 83 | 144 | 42.4% | `Mass.Game.Launcher.Java.LanGame/WebRtc.cs` |
| 236,220 | 148 | 226 | 34.5% | `Mass.WinUI.ViewModels/PaymentViewModel.cs` |
| 193,623 | 123 | 175 | 29.7% | `Mass.Application.Desktop/DesktopAuthentication.cs` |

**完全无桩标记、可直接使用的文件：37 / 1,191（共 104 个成员声明）** —— 多为小工具类。

---

## 5. 「可编译的 Mass」还差什么（诚实清单）

1. **被保护方法的语义**（最大缺口）。已用两条独立路线证伪其可取出性：
   - 桩 `calli` 到达的原生处理器只做一次判断后返回 0（`VM-机制与下一步.md` §22）；
   - 跑真 App 也无法让加密块多解出明文（同文档 §25.2）。
2. **被保护方法之外的"半成品"**：约 86% 的成员是桩，需要按用途逐个实现或从 SDK 推导。
3. **DNGuard 运行时**（`Mass.Runtime64.dll` 与各程序集里的保护段）不可重建 —— 但**不需要重建**：
   若用官方 SDK 替换掉客户端自己的 HTTP/鉴权层，这一层就不再依赖保护器。
4. **第三方依赖**：反编译产物引用了 RestSharp、Serilog、BouncyCastle、WinUI3、
   WebRTC 等，需按 `src/` 的 `using` 逐个还原工程引用（这部分是纯工程工作，可做）。

---

## 6. 建议的推进顺序

1. 用 `refs/upstream-mass-sdk` 建一个可编译的 `Mass.Sdk` 工程（上游即可编译）。
2. 把 `src/` 里**无桩或低桩**的类先并入工程（UI 模型、序列化器、工具类、XAML 类型信息）。
3. 以 SDK 的 `DesktopSession`/`MassClient` 为参照，逐个重新实现客户端里高桩比例的
   API/鉴权类（`DesktopSession`、`DesktopAuthentication`、`NetEaseDesktop`、`MassService`）。
4. 游戏代理（`Mass.Game.Proxy`/`Mass.Bedrock.Proxy`）与 Java 启动器按协议单独实现 ——
   这部分协议细节**不在 SDK 里**，只能靠本项目已有的抓包/反编译线索。
5. 每完成一层就在本仓库记录"已实现/仍缺失"，使缺口可枚举、可核对。
