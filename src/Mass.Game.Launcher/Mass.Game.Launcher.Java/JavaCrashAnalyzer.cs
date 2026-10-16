using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Mass.Application.Desktop;
using Mass.Application.Desktop.Helpers;
using Mass.Application.Netease;
using Mass.Common.Extensions;
using Mass.Common.Helpers;
using Mass.Domain.Desktop.Entities.Mods;
using Mass.Domain.Desktop.ValueObjects;
using Mass.Domain.Value;
using Mass.Game.Launcher.Entities.Fever;
using Mass.Game.Launcher.Models;
using Mass.Game.Launcher.Paths;
using Mass.Game.Launcher.Values;
using Microsoft.Win32;
using Org.BouncyCastle.Crypto.Engines;
using RestSharp;
using Serilog;

namespace Mass.Game.Launcher.Java;

public static class JavaCrashAnalyzer
{
	internal static JavaCrashAnalyzer DecorateMixedChain;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string Analyze(MinecraftPath mcPath, IReadOnlyList<string> recentLog, int exitCode)
	{
		return (string)_EF00(mcPath, recentLog, (uint)exitCode);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object ReadRecentLog(IReadOnlyList<string> lines)
	{
		return 儀(lines);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object? ReadLatestCrashReport(object mcPath)
	{
		return 頀(mcPath);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object? ReadLatestHsErr(object mcPath)
	{
		return 唀(mcPath);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object? ReadNewestFile(object dir, object pattern)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 240, 1790778867, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778867, new IntPtr(2737337538764L), 15);
		}
		return ((delegate*<object, object, object>)obj)(dir, pattern);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static (CrashReason, string) Classify(object logMc, object? logCrash, object? logHs, uint exitCode)
	{
		return 倀(logMc, logCrash, logHs, exitCode);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static (CrashReason, string)? AnalyzeExitCode(uint exitCode)
	{
		return 搀(exitCode);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static (CrashReason, string)? AnalyzeCrit1(object logMc, object? logCrash, object? logHs)
	{
		return 錀(logMc, logCrash, logHs);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static (CrashReason, string)? AnalyzeCrit2(object logMc, object? logCrash)
	{
		return 픀(logMc, logCrash);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static (CrashReason, string)? AnalyzeCrit3(object logMc, object? logCrash)
	{
		return _FFFD(logMc, logCrash);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static byte IsMixin(object log, [Out] nint modName)
	{
		return _EC00(log, modName);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object ExtractAfter(object s, object marker)
	{
		return 턀(s, marker);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object ExtractBetween(object s, object start, object end)
	{
		return _E100(s, start, end);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object ExtractDuplicateMod(object logMc)
	{
		return 昀(logMc);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object BuildMessage(CrashReason reason, object detail)
	{
		return 케(reason, detail);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object BuildWindowsExitCodeMessage(object detail, object cause)
	{
		return 鴀(detail, cause);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CheckFlexibleEnumerator()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static JavaCrashAnalyzer DecorateSegmentedParameter()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static (CrashReason, string) 伀(object P_0, object P_1, object P_2, uint P_3)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778866, new IntPtr(2737337572044L), 15))(null, 0, new IntPtr(0L));
		return ((CrashReason, string))/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static (CrashReason, string) 倀(object P_0, object P_1, object P_2, uint P_3)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_005f: Expected I4, but got Obj
		//IL_01b3: Expected Obj, but got Ref
		//IL_020a: Expected VT, but got I4
		//IL_00c9: Expected Obj, but got Ref
		//IL_006c: Expected VT, but got Obj
		//IL_00f4: Expected Obj, but got Ref
		//IL_01de: Expected Obj, but got Ref
		//IL_0132: Expected Obj, but got Ref
		//IL_0163: Expected VT, but got I4
		//IL_00fb: Expected Obj, but got I4
		//IL_0107: Expected native int or pointer, but got Obj
		//IL_0074: Expected VT, but got Obj
		//IL_0173: Expected native int or pointer, but got Obj
		//IL_0097->IL0026: Incompatible stack heights: 2 vs 1
		//IL_021d->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0111->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01cc->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00e2->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01f7->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0150->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b7->IL0026: Incompatible stack types: I4 vs Obj
		//IL_017d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_011c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01d7->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ed->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0202->IL0026: Incompatible stack types: I4 vs Obj
		//IL_015b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c2->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0188->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 10;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 6:
				return ((CrashReason, string))new Func<Task>((object)/*Error near IL_006b: Stack underflow*/, 1);
			case 3:
				_ = 0;
				return ((CrashReason, string))new TcpListener();
			case 10:
				obj = ((Authenticator)P_1).ListenAuthenticationConnectAsync(P_2);
				_ = 9;
				break;
			case 9:
				if (((AsyncTaskMethodBuilder*)(&obj))->Task != null)
				{
					obj2 = 11;
					if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003Et__builder).listener != null)
					{
						obj2 = 10;
					}
					break;
				}
				((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)P_0)->SetStateMachine((IAsyncStateMachine)P_1);
				obj = (object)/*Error near IL_013c: Stack underflow*/;
				obj2 = 8;
				if ((int)((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003C_003E1__state)->_003C_003Et__builder != 0)
				{
					obj2 = 8;
				}
				break;
			case 5:
				((TcpListener)(&obj)).Dispose();
				if ((int)/*Error near IL_00ce: Stack underflow*/ == 0)
				{
					obj2 = 0;
					if (Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler == null)
					{
						obj2 = 0;
					}
					break;
				}
				goto case 12;
			case 7:
				return ((CrashReason, string))((Task)(&obj)).GetAwaiter();
			case 11:
				((AsyncTaskMethodBuilder*)/*Error near IL_0132: Stack underflow*/)->SetException((Exception)(&obj));
				return ((CrashReason, string))/*Error near IL_0133: Stack underflow*/;
			case 12:
				return ((CrashReason, string))((TaskAwaiter<TcpClient>*)(&obj))->IsCompleted;
			default:
				if (P_2 == null)
				{
					obj2 = 1;
					if (((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003C_003E4__this)->_003Cstream_003E5__2 == null)
					{
						obj2 = 3;
					}
					break;
				}
				goto case 6;
			case 2:
				if (((Encoding)/*Error near IL_01b3: Stack underflow*/).GetBytes((string)(&obj)) == null)
				{
					((Authenticator._003CListenAsync_003Ed__7*)/*Error near IL_00fb: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)P_3);
					obj = (object)/*Error near IL_00fd: Stack underflow*/;
					obj2 = 5;
					if (((Authenticator._003CReceiveAsync_003Ed__9*)(nint)Authenticator._003CReceiveAsync_003Ed__9._003C_003E4__this)->client != null)
					{
						obj2 = 0;
					}
				}
				else
				{
					obj2 = 7;
					if (((FeverInstaller)FeverInstaller._003CappId_003EP)._003CappVersion_003EP == null)
					{
						obj2 = 2;
					}
				}
				break;
			case 8:
				if ((int)((Task<string>)(&obj)).GetAwaiter() == 0)
				{
					obj2 = 1;
					if (FeverInstaller.ReflectVisualArgument == null)
					{
						obj2 = 1;
					}
					break;
				}
				goto case 4;
			case 4:
				return ((CrashReason, string))((Stream)/*Error near IL_0209: Stack underflow*/).Read((byte[])/*Error near IL_0209: Stack underflow*/, (int)/*Error near IL_0209: Stack underflow*/, (int)(&obj));
			case 1:
				obj = ((FeverInstaller)P_1).InstallAsync();
				_ = 2;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object 儀(IReadOnlyList<string> P_0)
	{
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		((AsyncTaskMethodBuilder*)10)->Start(ref *(Authenticator._003CReceiveAsync_003Ed__9*)P_0);
		return (object)/*Error near IL_001d: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object 刀(IReadOnlyList<string> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778865, new IntPtr(2737337539804L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object 吀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778864, new IntPtr(2737337572044L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object 唀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 3880, 1790778863, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778863, new IntPtr(2737337572044L), 15);
		}
		return ((delegate*<object, object>)obj)(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static (CrashReason, string)? 搀(uint P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_012f: Expected I4, but got Obj
		//IL_01c5: Expected Obj, but got I4
		//IL_01d1: Expected Obj, but got VT
		//IL_0390: Expected Obj, but got I4
		//IL_0536: Expected Obj, but got VT
		//IL_0540: Expected native int or pointer, but got Obj
		//IL_068c: Expected Obj, but got I4
		//IL_0691: Unknown result type (might be due to invalid IL or missing references)
		//IL_0698: Expected Obj, but got Unknown
		//IL_06a1: Expected Obj, but got I4
		//IL_0373: Expected Obj, but got Ref
		//IL_0341: Expected Obj, but got VT
		//IL_05ab: Expected Obj, but got I4
		//IL_0679: Expected Obj, but got VT
		//IL_067b: Expected Obj, but got VT
		//IL_06ea: Expected Obj, but got VT
		//IL_04cd: Expected Obj, but got VT
		//IL_013b: Expected Obj, but got I4
		//IL_0140: Expected I, but got Obj
		//IL_0154: Expected VT, but got Obj
		//IL_03f5: Expected Obj, but got I4
		//IL_03fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0401: Expected Obj, but got Unknown
		//IL_0226: Expected Obj, but got I4
		//IL_02b0: Expected Obj, but got I4
		//IL_0443: Expected Obj, but got I4
		//IL_01a4: Expected Obj, but got I4
		//IL_05dd: Expected Obj, but got I
		//IL_01db->IL0026: Incompatible stack heights: 3 vs 1
		//IL_03b0->IL0026: Incompatible stack heights: 2 vs 1
		//IL_054a->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0389->IL0026: Incompatible stack heights: 4 vs 1
		//IL_034d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_036a->IL0026: Incompatible stack heights: 4 vs 1
		//IL_0685->IL0026: Incompatible stack types: I4 vs Obj
		//IL_06f4->IL0026: Incompatible stack heights: 2 vs 1
		//IL_017b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_04e1->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0151->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0415->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0243->IL0026: Incompatible stack types: I4 vs Obj
		//IL_029c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_03bb->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0555->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0713->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0263->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0792->IL0026: Incompatible stack types: I4 vs Obj
		//IL_07db->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0611->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02ee->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0733->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0476->IL0026: Incompatible stack types: I4 vs Obj
		//IL_04ec->IL0026: Incompatible stack heights: 3 vs 1
		//IL_07b1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_05a4->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0169->IL0026: Incompatible stack types: I4 vs Obj
		//IL_04ba->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0496->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0420->IL0026: Incompatible stack heights: 3 vs 1
		//IL_01be->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02d9->IL0026: Incompatible stack types: I4 vs Obj
		//IL_05e2->IL0026: Incompatible stack types: I4 vs Obj
		//IL_024e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0190->IL0026: Incompatible stack types: I4 vs Obj
		//IL_074a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_071e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_07e6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0481->IL0026: Incompatible stack types: I4 vs Obj
		//IL_07bc->IL0026: Incompatible stack types: I4 vs Obj
		//IL_05ed->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 20;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 41:
					obj = new Task(new Func<Task>((object)/*Error near IL_0140: Stack underflow*/, (nint)((Authenticator)30).Listener));
					obj2 = 5;
					continue;
				case 5:
				case 10:
				case 13:
				case 14:
				case 16:
				case 22:
				case 29:
				case 40:
				case 42:
				case 47:
				case 51:
				case 52:
				case 58:
				case 60:
				case 61:
				case 63:
					return ((CrashReason, string)?)obj;
				case 48:
					if (P_0 != 3221226356u)
					{
						obj2 = 34;
						continue;
					}
					goto case 9;
				case 8:
				case 17:
				case 18:
				case 28:
				case 30:
				case 36:
				case 43:
				case 44:
					*(AsyncTaskMethodBuilder<EntityFeverManifestInfo>*)(&obj) = default;
					obj2 = 59;
					continue;
				case 39:
				case 62:
					if (P_0 != 3221225786u)
					{
						obj2 = 4;
						continue;
					}
					goto case 54;
				case 37:
					if (P_0 != 3221225595u)
					{
						obj = 43;
						break;
					}
					goto case 6;
				case 55:
					if (P_0 != 3221225477u)
					{
						obj2 = 28;
						continue;
					}
					goto default;
				default:
					((Authenticator)/*Error near IL_01c5: Stack underflow*/).ListenAuthenticationConnectAsync((object)23);
					new AsyncTaskMethodBuilder();
					obj = new AsyncTaskMethodBuilder();
					_ = 22;
					continue;
				case 4:
					if (P_0 != 3221225794u)
					{
						obj = 17;
						break;
					}
					goto case 2;
				case 59:
					obj = obj;
					obj2 = 26;
					if (Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler == null)
					{
						obj2 = 42;
					}
					continue;
				case 12:
					if (P_0 != 3221225622u)
					{
						obj2 = 30;
						continue;
					}
					goto case 35;
				case 1:
					if (P_0 != 3221225478u)
					{
						obj2 = 31;
						continue;
					}
					goto case 38;
				case 7:
					if (P_0 != 3221225501u)
					{
						obj = 37;
						break;
					}
					goto case 3;
				case 56:
					if ((int)P_0 > -1073741511)
					{
						obj2 = 39;
						continue;
					}
					goto case 45;
				case 32:
					if (P_0 != 3221225785u)
					{
						obj2 = 18;
						continue;
					}
					goto case 26;
				case 24:
					((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)34)->MoveNext();
					obj = new IAsyncStateMachine((IAsyncStateMachine)new AsyncTaskMethodBuilder());
					obj2 = 13;
					continue;
				case 25:
					_ = 29;
					Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.ReflectRandomReporter();
					new TaskAwaiter<TcpClient>();
					obj = new TcpListener();
					_ = 52;
					continue;
				case 23:
					_ = 12;
					((Task<TcpClient>)(&P_0)).GetAwaiter();
					new TaskAwaiter<TcpClient>();
					obj = new Encoding();
					_ = 16;
					continue;
				case 3:
					((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)/*Error near IL_0390: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)22);
					new Encoding((byte[])/*Error near IL_0395: Stack underflow*/, (int)/*Error near IL_0395: Stack underflow*/, (int)/*Error near IL_0395: Stack underflow*/);
					obj = new TcpClient();
					_ = 13;
					if (((FeverInstaller)FeverInstaller.McBedrock__BackingField).Client__BackingField == null)
					{
						_ = 40;
					}
					continue;
				case 54:
					((FeverInstaller)35).InstallAsync();
					new TaskAwaiter<string>();
					obj = (object)new RestClientOptions();
					_ = 63;
					if (((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14)FeverInstaller._003CFeverRequest_003Ed__15<>._003C_003Eu__1)._003C_003E1__state != 0)
					{
						_ = 35;
					}
					continue;
				case 20:
					if ((int)P_0 <= -1073741674)
					{
						obj = 19;
						break;
					}
					goto case 50;
				case 34:
					if (P_0 != 3221226505u)
					{
						obj2 = 44;
						if (((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14)FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14._003C_003Et__builder)._003C_003E4__this != null)
						{
							obj2 = 17;
						}
						continue;
					}
					goto case 25;
				case 50:
					if ((int)P_0 <= -1073741502)
					{
						obj2 = 56;
						continue;
					}
					goto case 49;
				case 49:
					if ((int)P_0 > -1073740791)
					{
						obj2 = 53;
						continue;
					}
					goto case 48;
				case 38:
					_ = 33;
					new AsyncTaskMethodBuilder<EntityFeverManifest>(ref *(TStateMachine*)FeverInstaller.CheckStaticProgram());
					obj = new AsyncTaskMethodBuilder<EntityFeverManifest>();
					_ = 7;
					if (((FeverInstaller._003CGetFeverManifestAsync_003Ed__12)FeverInstaller._003CGetFeverManifestAsync_003Ed__12._003C_003Et__builder)._003C_003E4__this == null)
					{
						_ = 14;
					}
					continue;
				case 6:
					_ = 24;
					new AsyncTaskMethodBuilder<EntityFeverAppVersion>(ref *(FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14.AnalyzeHandler() ? ((TStateMachine*)1) : ((TStateMachine*)null)));
					obj = new AsyncTaskMethodBuilder<_0021_00210>();
					_ = 10;
					if (((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13*)(nint)FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13._003C_003E4__this)->version == null)
					{
						_ = 3;
					}
					continue;
				case 2:
					_ = 27;
					FeverInstaller._003CGetFeverManifestAsync_003Ed__12.ReceiveEnumerator();
					/*Error near IL_055c: Member reference must be method, but was: Field*/;
				case 9:
					_ = 28;
					FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13.CallGateway();
					/*Error near IL_0579: Member reference must be method, but was: Field*/;
				case 46:
					if (P_0 != 2147483651u)
					{
						obj2 = 55;
						continue;
					}
					goto case 24;
				case 26:
					((FeverInstaller._003CInstallAsync_003Ed__11*)/*Error near IL_05ab: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)26);
					/*Error near IL_05ab: Member reference must be method, but was: Field*/;
				case 57:
					if (P_0 - 23333 <= 1)
					{
						obj2 = 16;
						if (((Rpc)Rpc.ProcessId__BackingField).Logger__BackingField == null)
						{
							obj2 = 23;
						}
						continue;
					}
					goto case 8;
				case 31:
					if (P_0 != 3221225495u)
					{
						obj2 = 8;
						continue;
					}
					goto case 27;
				case 27:
					((Rpc)/*Error near IL_066f: Stack underflow*/).UseCha = true;
					obj = new AsyncTaskMethodBuilder<EntityFeverAppVersion>((EntityFeverAppVersion)new AsyncTaskMethodBuilder<_00210>((IAsyncStateMachine)/*Error near IL_0674: Stack underflow*/));
					obj2 = 29;
					continue;
				case 21:
					((Rpc)/*Error near IL_068c: Stack underflow*/).SendMessage((BinaryWriter)/*Error near IL_068c: Stack underflow*/, (object[])25);
					obj = (object)new RestRequest((string)/*Error near IL_0696: Stack underflow*/, (Method)new TaskAwaiter<EntityFeverApp>());
					obj = 60;
					break;
				case 35:
					((Rpc)/*Error near IL_06de: Stack underflow*/).StartListen(31);
					new Task<EntityFeverApp>();
					obj = new TaskAwaiter<EntityFeverApp>();
					_ = 51;
					continue;
				case 11:
					if (P_0 != 3221225620u)
					{
						obj2 = 5;
						if ((int)((Rpc._003CListenControlConnectAsync_003Ed__35*)Rpc._003CListenControlConnectAsync_003Ed__35._003C_003E1__state)->_003C_003Et__builder == 0)
						{
							obj2 = 12;
						}
						continue;
					}
					goto case 41;
				case 33:
					if ((int)P_0 <= -1073741701)
					{
						obj2 = 7;
						continue;
					}
					goto case 11;
				case 53:
				case 64:
					if ((uint)((int)P_0 - -23334) > 1u)
					{
						obj2 = 57;
						continue;
					}
					goto case 23;
				case 15:
					if ((int)P_0 <= -1073741819)
					{
						obj2 = 46;
						continue;
					}
					goto case 1;
				case 45:
					if (P_0 != 3221225781u)
					{
						obj2 = 29;
						if (Rpc._003CListenControlConnectAsync_003Ed__35.ReflectSymbolicDecorator != null)
						{
							obj2 = 32;
						}
						continue;
					}
					goto case 21;
				case 19:
					if ((int)P_0 <= -1073741801)
					{
						obj2 = 9;
						if ((int)((Rpc._003CReceiveAsync_003Ed__28*)Rpc._003CReceiveAsync_003Ed__28._003C_003E1__state)->_003C_003Et__builder == 0)
						{
							obj2 = 15;
						}
						continue;
					}
					goto case 33;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object 昀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 3897, 1790778862, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778862, new IntPtr(2737337539804L), 15);
		}
		return ((delegate*<object, object>)obj)(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object 最(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778861, new IntPtr(2737337582444L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte 栀()
	{
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte 椀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778860, new IntPtr(2737337579324L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static (CrashReason, string)? 錀(object P_0, object P_1, object P_2)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0137: Expected I4, but got Obj
		//IL_0a2c: Expected Obj, but got I4
		//IL_0a38: Expected Obj, but got I4
		//IL_0a3e: Expected VT, but got Obj
		//IL_0606: Expected I4, but got Obj
		//IL_0606: Expected Obj, but got I4
		//IL_0613: Expected Obj, but got I4
		//IL_061a: Expected I4, but got Obj
		//IL_0625: Expected VT, but got Obj
		//IL_0177: Expected I4, but got Obj
		//IL_0177: Expected Obj, but got I4
		//IL_0195: Expected Obj, but got VT
		//IL_0196: Expected VT, but got Obj
		//IL_05d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e4: Expected VT, but got Obj
		//IL_0594: Expected Obj, but got I4
		//IL_04bf: Expected Obj, but got I4
		//IL_04d8: Expected Obj, but got VT
		//IL_04b7: Expected VT, but got Obj
		//IL_06b0: Expected VT, but got Obj
		//IL_06b0: Expected Obj, but got I4
		//IL_06b1: Expected VT, but got Obj
		//IL_0798: Expected Obj, but got I4
		//IL_0301: Expected Ref, but got VT
		//IL_0651: Expected VT, but got I4
		//IL_064c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0657: Expected VT, but got Obj
		//IL_0a73: Expected I4, but got Obj
		//IL_06eb: Expected Obj, but got I4
		//IL_08f8: Expected Obj, but got I4
		//IL_08fe: Expected VT, but got Obj
		//IL_040a: Expected I4, but got Obj
		//IL_040a: Expected Obj, but got I4
		//IL_0414: Expected Obj, but got I4
		//IL_041e: Expected Obj, but got VT
		//IL_07eb: Expected Obj, but got I4
		//IL_07fc: Expected I4, but got Obj
		//IL_07fd: Expected VT, but got Obj
		//IL_0b33: Expected I4, but got Obj
		//IL_08bb: Expected Obj, but got I4
		//IL_08c1: Expected VT, but got Obj
		//IL_0453: Expected I4, but got Obj
		//IL_0515: Expected VT, but got Obj
		//IL_09cd: Expected Obj, but got I4
		//IL_09cd: Expected Obj, but got I4
		//IL_09ce: Expected VT, but got Obj
		//IL_01e2: Expected Obj, but got VT
		//IL_01e2: Expected Obj, but got I4
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected VT, but got Unknown
		//IL_086a: Expected Obj, but got I4
		//IL_0269: Expected VT, but got Obj
		//IL_0ae9: Expected Obj, but got VT
		//IL_0aea: Expected VT, but got Obj
		//IL_0749: Expected Obj, but got I4
		//IL_074f: Expected VT, but got Obj
		//IL_047b: Expected Obj, but got I4
		//IL_055c: Expected Obj, but got I4
		//IL_02cb: Expected Obj, but got I4
		//IL_06bc: Expected VT, but got I4
		//IL_020e: Expected Obj, but got I4
		//IL_065d: Expected I4, but got Obj
		//IL_0a49: Expected Obj, but got I4
		//IL_01c0: Expected native int or pointer, but got Obj
		//IL_0982: Expected Obj, but got I4
		//IL_056a: Expected Obj, but got I4
		//IL_031c: Expected native int or pointer, but got Obj
		//IL_0283: Expected native int or pointer, but got Obj
		//IL_0ab3: Expected Obj, but got I
		//IL_0676: Expected Obj, but got I4
		//IL_052f: Expected native int or pointer, but got Obj
		//IL_089f: Expected Obj, but got I4
		//IL_07d6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0589->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0951->IL0026: Incompatible stack types: I4 vs Obj
		//IL_05a3->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0561->IL0355: Incompatible stack heights: 1 vs 0
		//IL_09bb->IL0026: Incompatible stack types: I4 vs Obj
		//IL_07b1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_04b4->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02b2->IL0026: Incompatible stack types: I4 vs Obj
		//IL_080d->IL0196: Incompatible stack heights: 2 vs 0
		//IL_0a87->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0704->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0b4c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0251->IL0026: Incompatible stack types: I4 vs Obj
		//IL_022d->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0462->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0afa->IL03b7: Incompatible stack heights: 1 vs 0
		//IL_090e->IL0742: Incompatible stack heights: 1 vs 0
		//IL_0879->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0add->IL0026: Incompatible stack types: I4 vs Obj
		//IL_09a1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_049a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01ca->IL0026: Incompatible stack types: I4 vs Obj
		//IL_095c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0525->IL06a4: Incompatible stack heights: 1 vs 0
		//IL_08e5->IL0026: Incompatible stack types: I4 vs Obj
		//IL_056f->IL0022: Incompatible stack heights: 1 vs 0
		//IL_01f5->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0326->IL0026: Incompatible stack types: I4 vs Obj
		//IL_07bc->IL0026: Incompatible stack types: I4 vs Obj
		//IL_06d5->IL0026: Incompatible stack types: I4 vs Obj
		//IL_063f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_028d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0817->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0ab8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_070f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_05f4->IL01e3: Incompatible stack heights: 1 vs 0
		//IL_067b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0b57->IL0026: Incompatible stack types: I4 vs Obj
		//IL_09e8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_025c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0b04->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0922->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0773->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0a62->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01d5->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0539->IL0026: Incompatible stack heights: 2 vs 1
		//IL_08f0->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0331->IL0026: Incompatible stack types: I4 vs Obj
		//IL_06e0->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01a6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_064a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0298->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0ac3->IL0026: Incompatible stack types: I4 vs Obj
		//IL_05fe->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0686->IL0026: Incompatible stack types: I4 vs Obj
		//IL_04fd->IL0026: Incompatible stack types: I4 vs Obj
		//IL_092d->IL0026: Incompatible stack heights: 2 vs 1
		//IL_077e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0a6d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0544->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0439->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0508->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 6;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 8:
				{
					((Authenticator)19).StartListening((int)P_1);
					object obj3 = ((Authenticator)/*Error near IL_017c: Stack underflow*/).ListenAsync();
					((AsyncTaskMethodBuilder*)10)->Start<TStateMachine>(ref *(TStateMachine*)null);
					_ = ((AsyncTaskMethodBuilder*)((object[])obj3)[0])->Task;
					return ((CrashReason, string)?)(object)new GC((object)new AsyncTaskMethodBuilder());
				}
				case 63:
					((IAsyncStateMachine)((Authenticator)/*Error near IL_01ac: Stack underflow*/).HandleAuthentication((string)P_0)).MoveNext();
					if ((int)/*Error near IL_01b6: Stack underflow*/ != 0)
					{
						obj2 = 0;
						if (((Authenticator._003CReceiveAsync_003Ed__9*)(nint)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler)->_003C_003E1__state == 0)
						{
							obj2 = 10;
						}
						continue;
					}
					goto default;
				case 52:
					return ((CrashReason, string)?)(object)new ILogger((Exception)10, (string)new TaskAwaiter());
				case 26:
					((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)/*Error near IL_01fb: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)P_0);
					((IAsyncStateMachine)/*Error near IL_0200: Stack underflow*/).SetStateMachine((IAsyncStateMachine)/*Error near IL_0200: Stack underflow*/);
					if ((int)/*Error near IL_0205: Stack underflow*/ != 0)
					{
						obj = 30;
						break;
					}
					goto IL_03c4;
				case 43:
					if (((TaskAwaiter<TcpClient>*)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.ReflectRandomReporter())->IsCompleted)
					{
						_ = 18;
						continue;
					}
					FeverInstaller._003CGetFeverManifestAsync_003Ed__12.SearchChain();
					/*Error near IL_0369: Member reference must be method, but was: Field*/;
				case 42:
					((Authenticator._003CReceiveAsync_003Ed__9*)/*Error near IL_0233: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)P_0);
					if ((int)((Task<TcpClient>)/*Error near IL_0238: Stack underflow*/).GetAwaiter() != 0)
					{
						obj2 = 50;
						if (Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.ReflectMixedGateway == null)
						{
							obj2 = 18;
						}
						continue;
					}
					((AsyncTaskMethodBuilder<string>*)/*Error near IL_09d9: Stack underflow*/)->AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref *(TAwaiter*)/*Error near IL_09d9: Stack underflow*/, ref *(TStateMachine*)((JavaCommand)P_0).BaseMinecraft);
					if ((int)/*Error near IL_09de: Stack underflow*/ == 0)
					{
						((Rpc._003CListenAsync_003Ed__34*)P_0)->MoveNext();
						if (((TaskAwaiter<EntityFeverManifestInfo>*)/*Error near IL_04e4: Stack underflow*/)->GetResult() == null)
						{
							((Rpc)/*Error near IL_0425: Stack underflow*/).SendMessage((BinaryWriter)/*Error near IL_0425: Stack underflow*/, (object[])P_0);
							if (!((TaskAwaiter<EntityFeverApp>*)/*Error near IL_042a: Stack underflow*/)->IsCompleted)
							{
								obj2 = 56;
								continue;
							}
							goto case 4;
						}
						obj2 = 18;
						if (((Rpc._003CRemoteCallBackAsync_003Ed__21)Rpc._003CRemoteCallBackAsync_003Ed__21._003C_003Et__builder)._003C_003E4__this != null)
						{
							obj2 = 39;
						}
						continue;
					}
					obj2 = 15;
					continue;
				case 60:
					new Encoding((byte[])/*Error near IL_0263: Stack underflow*/, (int)/*Error near IL_0263: Stack underflow*/, 5);
					return ((CrashReason, string)?)(object)new TcpClient();
				case 30:
					if (((TaskAwaiter<string>*)((FeverInstaller)P_0).InstallAsync())->IsCompleted)
					{
						obj2 = 2;
						continue;
					}
					goto IL_03c4;
				case 19:
					((RestClientOptions)/*Error near IL_02bd: Stack underflow*/).UserAgent = (string)(object)((FeverInstaller)/*Error near IL_02b8: Stack underflow*/).GetFeverManifestInfoAsync(P_2);
					if ((int)/*Error near IL_02c2: Stack underflow*/ == 0)
					{
						obj = 24;
						break;
					}
					goto case 1;
				case 1:
				case 33:
					_ = 11;
					return ((CrashReason, string)?)new AsyncTaskMethodBuilder<EntityFeverManifest>(ref *(TStateMachine*)new AsyncTaskMethodBuilder<EntityFeverManifest>());
				case 20:
					((FeverInstaller._003CFeverRequest_003Ed__15<>*)/*Error near IL_0308: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)P_2);
					if ((int)AsyncTaskMethodBuilder<EntityFeverManifestInfo>.Create() != 0)
					{
						obj2 = 41;
						if (((FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)(nint)FeverInstaller._003CGetFeverManifestAsync_003Ed__12._003C_003E4__this)->info != null)
						{
							obj2 = 38;
						}
						continue;
					}
					goto IL_01e3;
				case 18:
					_ = 13;
					new AsyncTaskMethodBuilder<_0021_00210>();
					/*Error near IL_035d: Member reference must be method, but was: Field*/;
				case 12:
					new AsyncTaskMethodBuilder<_0021_00210>(ref *(TStateMachine*)7);
					return ((CrashReason, string)?)new AsyncTaskMethodBuilder<_0021_00210>();
				case 17:
					FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13.DecorateGroupedVisitor();
					/*Error near IL_03a3: Member reference must be method, but was: Field*/;
				case 2:
					_ = 2;
					/*Error near IL_03b9: Member reference must be method, but was: Field*/;
				case 39:
					((Rpc)15).NeedCha = (byte)(int)P_0 != 0;
					((AsyncTaskMethodBuilder<_00210>*)/*Error near IL_0414: Stack underflow*/)->SetException((Exception)((Rpc)/*Error near IL_040f: Stack underflow*/).UseCha);
					return ((CrashReason, string)?)new AsyncTaskMethodBuilder<EntityFeverAppVersion>((EntityFeverAppVersion)new AsyncTaskMethodBuilder<_00210>((IAsyncStateMachine)/*Error near IL_0419: Stack underflow*/));
				case 45:
					if (RestRequestExtensions.AddQueryParameter((RestRequest)/*Error near IL_0453: Stack underflow*/, (string)/*Error near IL_0453: Stack underflow*/, (string)/*Error near IL_0453: Stack underflow*/, (byte)(int)((Rpc)/*Error near IL_044e: Stack underflow*/).RemoteCallBackAsync(P_0) != 0) != null)
					{
						obj2 = 32;
						continue;
					}
					goto case 61;
				case 6:
					((Rpc)P_0).Dispose();
					if (((TaskAwaiter<EntityFeverApp>*)/*Error near IL_046d: Stack underflow*/)->GetResult() != null)
					{
						obj = 5;
						break;
					}
					if (((ILogger)/*Error near IL_0974: Stack underflow*/).Category((string)(object)((JavaAuthenticator)/*Error near IL_096f: Stack underflow*/).HandleAuthentication((string)P_0)) == null)
					{
						obj = 58;
						break;
					}
					goto case 38;
				case 61:
					((Rpc)/*Error near IL_0486: Stack underflow*/).Writer = (BinaryWriter?)P_0;
					((AsyncTaskMethodBuilder<EntityFeverAppVersion>*)/*Error near IL_048b: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)/*Error near IL_048b: Stack underflow*/);
					if ((int)/*Error near IL_0490: Stack underflow*/ != 0)
					{
						obj2 = 54;
						continue;
					}
					goto case 42;
				case 28:
					((Rpc)/*Error near IL_04a0: Stack underflow*/).ReceiveControlData((object)/*Error near IL_04a0: Stack underflow*/, P_0);
					if ((int)((Task<RestResponse<EntityFeverManifest>>)/*Error near IL_04a5: Stack underflow*/).GetAwaiter() == 0)
					{
						((FeverInstaller)/*Error near IL_026f: Stack underflow*/)._002Ector((string)/*Error near IL_026f: Stack underflow*/, (string)/*Error near IL_026f: Stack underflow*/, (string)P_0);
						((TcpClient)/*Error near IL_0274: Stack underflow*/).Close();
						if ((int)/*Error near IL_0279: Stack underflow*/ != 0)
						{
							obj2 = 26;
							if (((FeverInstaller._003CFeverRequest_003Ed__15<>*)(nint)FeverInstaller.ReflectVisualArgument)->_003C_003E1__state == 0)
							{
								obj2 = 35;
							}
							continue;
						}
						((RpcCallBack)/*Error near IL_088c: Stack underflow*/).Rpc = (Rpc)P_0;
						((StringBuilder)/*Error near IL_0891: Stack underflow*/)._002Ector();
						if ((int)/*Error near IL_0896: Stack underflow*/ == 0)
						{
							obj = 17;
							break;
						}
						goto case 12;
					}
					obj2 = 60;
					continue;
				case 22:
					return ((CrashReason, string)?)obj;
				case 15:
					((Rpc)16).Listener = (TcpListener?)P_0;
					((AsyncTaskMethodBuilder<EntityFeverManifest>*)/*Error near IL_04ce: Stack underflow*/)->SetException((Exception)((Rpc)/*Error near IL_04c9: Stack underflow*/).ListenControlConnectAsync(((Rpc)/*Error near IL_04c4: Stack underflow*/).ListenAsync()));
					return ((CrashReason, string)?)new AsyncTaskMethodBuilder<EntityFeverManifest>((IAsyncStateMachine)new AsyncTaskMethodBuilder<EntityFeverManifest>((EntityFeverManifest)/*Error near IL_04d3: Stack underflow*/));
				case 47:
					return ((CrashReason, string)?)(object)new string((string)/*Error near IL_0514: Stack underflow*/, new RandomHelper(2));
				case 66:
					_ = 2;
					new TaskAwaiter<EntityFeverAppVersion>();
					return ((CrashReason, string)?)new TaskAwaiter<EntityFeverManifest>();
				case 16:
				case 53:
					if ((int)((Task<EntityFeverManifest>)Rpc._003CRemoteCallBackAsync_003Ed__21.RemoveTree()).GetAwaiter() == 0)
					{
						obj = 43;
						break;
					}
					goto case 18;
				case 3:
					((Rpc._003CSyncChaChaAsync_003Ed__38*)P_0)->MoveNext();
					((Dictionary<ushort, Func<RpcCallBack, Task>>)/*Error near IL_057a: Stack underflow*/)._002Ector();
					if ((int)/*Error near IL_057f: Stack underflow*/ != 0)
					{
						obj2 = 53;
						continue;
					}
					goto case 66;
				case 14:
					((BinaryWriter)P_0).Write((byte[])Rpc._003CSyncChaChaAsync_003Ed__38.DecorateConnectedMapper());
					if ((int)/*Error near IL_0599: Stack underflow*/ == 0)
					{
						obj2 = 51;
						continue;
					}
					goto case 38;
				case 13:
					new Salsa20Engine((byte[])/*Error near IL_05de: Stack underflow*/, (int)/*Error near IL_05de: Stack underflow*/, (int)/*Error near IL_05de: Stack underflow*/, (byte[])/*Error near IL_05de: Stack underflow*/, 9);
					return ((CrashReason, string)?)(object)new BinaryWriter();
				case 7:
					((GameValue)19).MaxConcurrency = (int)P_0;
					new BitConverter((byte[])/*Error near IL_061f: Stack underflow*/, (int)BitConverter.ToInt16((byte[])(object)GameValue.GetDesktopValue((string)/*Error near IL_060b: Stack underflow*/, (EnumGameVersion)/*Error near IL_060b: Stack underflow*/), (int)((object[])(object)((BinaryReader)10).ReadBytes(0))[0]));
					return ((CrashReason, string)?)(object)new BinaryReader();
				case 27:
					if (P_1 != null)
					{
						obj2 = 2;
						if (((ComponentPath)(object)ComponentPath.ComponentName).ComponentZip != null)
						{
							obj2 = 21;
						}
						continue;
					}
					goto IL_0196;
				case 34:
					new ILogger((string)/*Error near IL_0651: Stack underflow*/, (_0021_00210)8);
					return ((CrashReason, string)?)(object)new TcpClient();
				case 23:
					return ((CrashReason, string)?)(object)new CollectionExtensions((IReadOnlyDictionary<TKey, TValue>)7, (TKey)new TcpClient());
				case 25:
					((ILogger)/*Error near IL_06bc: Stack underflow*/).Error<_0021_00210>((Exception)/*Error near IL_06bc: Stack underflow*/, (string)/*Error near IL_06bc: Stack underflow*/, (_0021_00210)((JavaGameValue)P_1).GuiScale);
					if ((int)/*Error near IL_06c1: Stack underflow*/ == 0)
					{
						obj2 = 16;
						if (((CppGamePath)(object)CppGamePath.BePackCache).BeMain == null)
						{
							obj2 = 31;
						}
						continue;
					}
					goto case 40;
				case 37:
					if (Encoding.GetEncoding((string)((JavaGameValue)P_0).WindowWidth) != null)
					{
						obj2 = 65;
						if (((CppGamePath)(object)CppGamePath.ConfigFile).ErrorLog != null)
						{
							obj2 = 1;
						}
						continue;
					}
					goto case 63;
				case 10:
				case 64:
				case 65:
					return ((CrashReason, string)?)new RegistryKey(new Path((string)/*Error near IL_0749: Stack underflow*/, (string)4));
				case 55:
					((IDisposable)BedrockGamePath.GetBedrockPath()).Dispose();
					if (P_0 == null)
					{
						obj2 = 28;
						if (((GamePath)(object)GamePath.GameAuthenticationDllSource).PatchMcpSource == null)
						{
							obj2 = 2;
						}
						continue;
					}
					goto case 60;
				case 24:
					((DefaultInterpolatedStringHandler*)P_2)->AppendLiteral((string)ComponentPath.CloseRecord());
					if ((int)/*Error near IL_079d: Stack underflow*/ != 0)
					{
						obj2 = 0;
						if (((JavaGamePath)(object)JavaGamePath.JavaUrl).JavaTarget != null)
						{
							obj2 = 1;
						}
						continue;
					}
					goto case 57;
				default:
					((NotSupportedException)P_0)._002Ector((string?)(object)CppGamePath.DecorateDividedConsumer());
					if ((int)/*Error near IL_07cc: Stack underflow*/ == 0)
					{
						obj2 = 55;
						continue;
					}
					goto case 10;
				case 40:
					_ = 18;
					GamePath.ReflectExtendedSorter();
					GamePath.CheckWrapper();
					_ = 10;
					_ = ((EntityItemDownload)((object[])((EntityItemDownload)0).SubType)[0]).ItemId;
					return ((CrashReason, string)?)(object)new Environment((Environment.SpecialFolder)new EntitySubItemDownload());
				case 31:
					JavaGamePath.DecorateScheduledClient();
					if (AssemblyHelper.Directory != null)
					{
						_ = 8;
						continue;
					}
					goto IL_0196;
				case 57:
					if ((string?)/*Error near IL_086a: Stack underflow*/ + (string?)P_2 + (string?)ServerModPath.AdaptCommand() == null)
					{
						obj2 = 20;
						continue;
					}
					goto case 1;
				case 35:
					_ = 6;
					/*Error near IL_087b: Member reference must be method, but was: Field*/;
				case 44:
					new StringBuilder((object?)21);
					return ((CrashReason, string)?)(object)new RuntimeHelpers();
				case 11:
					if (((EqualityComparer<Type>)/*Error near IL_08cc: Stack underflow*/).GetHashCode((Type)(object)((RpcCallBack)P_1).Data) == 0)
					{
						if (!((TaskAwaiter<EntityFeverManifestInfo>*)Rpc._003CListenControlConnectAsync_003Ed__35.DecorateSeparatedSummarizer())->IsCompleted)
						{
							_ = 25;
							if ((object)((Rpc._003CSyncChaChaAsync_003Ed__38*)(nint)Rpc._003CSyncChaChaAsync_003Ed__38._003C_003E4__this)->callBack == null)
							{
								_ = 6;
							}
							continue;
						}
						goto case 23;
					}
					obj2 = 20;
					if (((MinecraftPath)(object)MinecraftPath.ModSettings).WordV == null)
					{
						obj2 = 47;
					}
					continue;
				case 38:
					new EqualityComparer<BinaryWriter>((BinaryWriter)20);
					return ((CrashReason, string)?)(object)new EqualityComparer<ushort>();
				case 51:
					_ = (RpcCallBack?)/*Error near IL_0904: Stack underflow*/ == (RpcCallBack?)P_0;
					if (EqualityComparer<byte[]>.Default == null)
					{
						_ = 37;
						if (((ServerModPath)(object)ServerModPath.Resource).ResourceMd5 == null)
						{
							_ = 37;
						}
						continue;
					}
					goto case 10;
				case 9:
					if (!((EqualityComparer<byte[]>)/*Error near IL_0938: Stack underflow*/).Equals((byte[]?)/*Error near IL_0938: Stack underflow*/, (byte[]?)(object)((RpcCallBack)P_0)._003CClone_003E_0024()))
					{
						obj2 = 13;
						if (ServerModPath.DecorateExternalAggregator != null)
						{
							obj2 = 46;
						}
						continue;
					}
					goto case 62;
				case 5:
					_ = 3;
					new AsyncTaskMethodBuilder<string>();
					return ((CrashReason, string)?)new AsyncTaskMethodBuilder<string>();
				case 59:
					if (((string)/*Error near IL_0992: Stack underflow*/).StartsWith((string)P_2, JavaAuthenticator.CheckExpandableNotifier() ? StringComparison.CurrentCultureIgnoreCase : StringComparison.CurrentCulture))
					{
						obj2 = 19;
						continue;
					}
					goto case 20;
				case 21:
					((JavaAuthenticator._003CHandleAuthentication_003Ed__9*)P_1)->MoveNext();
					if (((string)/*Error near IL_09ac: Stack underflow*/).Substring((int)/*Error near IL_09ac: Stack underflow*/) == null)
					{
						obj2 = 11;
						continue;
					}
					goto case 44;
				case 32:
				case 49:
				case 50:
				case 54:
					return ((CrashReason, string)?)(object)new DesktopAuthentication((string)14, (string)P_0, (string)JavaAuthenticator._003CHandleAuthentication_003Ed__9.ReflectLogicalModule(), new NeteaseSession());
				case 29:
					_ = ((JavaCommand)P_2).Version;
					/*Error near IL_09ee: Member reference must be method, but was: Field*/;
				case 4:
				{
					string name = ((JavaCommand)(object)((JavaCommand)P_0).Uuid).Name;
					((AsyncTaskMethodBuilder<string>*)10)->SetStateMachine((IAsyncStateMachine)0);
					return ((CrashReason, string)?)(object)new ArgumentNullException(new UuidHelper((string)18, Convert.ToUInt32((string?)((object[])(object)name)[0])));
				}
				case 56:
					((Exception)/*Error near IL_0a49: Stack underflow*/)._002Ector((string?)((JavaCommand)P_0).SocketPort);
					if ((int)/*Error near IL_0a4e: Stack underflow*/ == 0)
					{
						obj2 = 9;
						if (((JavaCommand)JavaCommand.GameId__BackingField).Uuid__BackingField == null)
						{
							obj2 = 27;
						}
						continue;
					}
					goto case 7;
				case 36:
					((DefaultInterpolatedStringHandler*)/*Error near IL_0a78: Stack underflow*/)->AppendFormatted(JavaCommand.Build((DesktopSession)/*Error near IL_0a73: Stack underflow*/, (MinecraftPath)/*Error near IL_0a73: Stack underflow*/, (MinecraftPath)/*Error near IL_0a73: Stack underflow*/, (EnumGameType)/*Error near IL_0a73: Stack underflow*/, (EnumGameVersion)/*Error near IL_0a73: Stack underflow*/, (int)/*Error near IL_0a73: Stack underflow*/, (int)/*Error near IL_0a73: Stack underflow*/, (string)/*Error near IL_0a73: Stack underflow*/, (string)/*Error near IL_0a73: Stack underflow*/, (int)/*Error near IL_0a73: Stack underflow*/, (string)/*Error near IL_0a73: Stack underflow*/, (int)/*Error near IL_0a73: Stack underflow*/, (byte)(int)P_2 != 0));
					if ((int)/*Error near IL_0a7d: Stack underflow*/ != 0)
					{
						obj2 = 48;
						continue;
					}
					if (RandomHelper.GetString((int)/*Error near IL_0a9f: Stack underflow*/, (string?)((JavaCommand)P_2).GetUserProperties()) != null)
					{
						obj2 = 59;
						if (JavaCommand.DecorateAdjustableSingleton != null)
						{
							obj2 = 7;
						}
						continue;
					}
					goto case 20;
				case 48:
					_ = 2;
					/*Error near IL_0a89: Member reference must be method, but was: Field*/;
				case 58:
					if (((JsonElement*)((JavaCommand)/*Error near IL_0ac9: Stack underflow*/).ReplaceClassPath((object)/*Error near IL_0ac9: Stack underflow*/, P_0))->GetString() == null)
					{
						obj2 = 14;
						continue;
					}
					goto case 38;
				case 62:
					_ = 2;
					return ((CrashReason, string)?)(object)new string((string)new JsonElement.ArrayEnumerator());
				case 46:
					if (Path.Combine((string[])(object)JavaCommand.FilterFinalizer()) == null)
					{
						_ = 26;
						continue;
					}
					goto case 2;
				case 41:
					{
						if (((string)/*Error near IL_0b33: Stack underflow*/).Split((char)/*Error near IL_0b33: Stack underflow*/, (StringSplitOptions)ReadLatestHsErr(P_2)) == null)
						{
							((JavaGameValue)/*Error near IL_065d: Stack underflow*/).ReconnectDelay = (int)P_2;
							if (!IPAddress.IsLoopback((IPAddress)/*Error near IL_0662: Stack underflow*/))
							{
								if (((MemberInfo)(object)CppGameValue.CheckLogicalContext()).Name != null)
								{
									_ = 52;
									continue;
								}
								goto IL_01e3;
							}
							obj2 = 13;
							if (ComponentPath.ReflectEfficientVerifier == null)
							{
								obj2 = 6;
							}
							continue;
						}
						obj2 = 34;
						if (CrashReason.GameCoreVerificationLibraryCrash == CrashReason.Unknown)
						{
							obj2 = 27;
						}
						continue;
					}
					IL_0196:
					if (P_2 != null)
					{
						obj2 = 29;
						continue;
					}
					goto IL_01e3;
					IL_01e3:
					*(TaskAwaiter<EntityFeverManifestInfo>*)(&obj) = default;
					obj2 = 22;
					continue;
					IL_03c4:
					_ = ((Rpc)P_0).ProcessId;
					/*Error near IL_03ca: Member reference must be method, but was: Field*/;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static (CrashReason, string)? 鐀(object P_0, object P_1, object P_2)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778859, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
		return ((CrashReason, string)?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object 需(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778858, new IntPtr(2737337573084L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object 頀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 3947, 1790778857, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778857, new IntPtr(2737337575164L), 15);
		}
		return ((delegate*<object, object>)obj)(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object 餀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778856, new IntPtr(2737337587644L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object 鴀(object P_0, object P_1)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 3952, 1790778855, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778855, new IntPtr(2737337589724L), 15);
		}
		return ((delegate*<object, object, object>)obj)(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object 鸀(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778854, new IntPtr(2737337573084L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object 鼀()
	{
		//IL_001a: Expected Obj, but got I4
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object 케(CrashReason P_0, object P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_017b: Expected I4, but got Obj
		//IL_0429: Expected Obj, but got I4
		//IL_08d7: Expected Obj, but got I
		//IL_0766: Expected VT, but got Obj
		//IL_08aa: Expected Obj, but got I
		//IL_054e: Expected Obj, but got I4
		//IL_0841: Expected Obj, but got I4
		//IL_0907: Expected VT, but got I4
		//IL_0907: Expected VT, but got Obj
		//IL_0459: Expected Obj, but got I4
		//IL_0463: Expected native int or pointer, but got Obj
		//IL_030d: Expected Obj, but got I4
		//IL_02bb: Expected native int or pointer, but got Obj
		//IL_02d7: Expected Obj, but got I4
		//IL_06a7: Expected Obj, but got I4
		//IL_07f0: Expected Obj, but got I4
		//IL_0a3e: Expected Obj, but got I4
		//IL_071a: Expected Obj, but got I4
		//IL_0724: Expected native int or pointer, but got Obj
		//IL_0692: Expected Obj, but got I4
		//IL_024c: Expected Obj, but got I4
		//IL_0791: Expected Obj, but got I4
		//IL_02f1: Expected Obj, but got I4
		//IL_073c: Expected Obj, but got I4
		//IL_0433->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0191->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0390->IL0026: Incompatible stack heights: 2 vs 1
		//IL_03f9->IL0026: Incompatible stack types: I4 vs Obj
		//IL_03a8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_08dc->IL0026: Incompatible stack types: I4 vs Obj
		//IL_08af->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0558->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01b3->IL0026: Incompatible stack types: I4 vs Obj
		//IL_091d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_03c0->IL0026: Incompatible stack types: I4 vs Obj
		//IL_066b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_044b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_046d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02c5->IL0026: Incompatible stack heights: 3 vs 1
		//IL_02e1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_06e8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_07cf->IL0026: Incompatible stack types: I4 vs Obj
		//IL_05a4->IL0249: Incompatible stack heights: 1 vs 0
		//IL_07fa->IL0026: Incompatible stack types: I4 vs Obj
		//IL_020e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0a48->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0489->IL0026: Incompatible stack types: I4 vs Obj
		//IL_057a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_072e->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0347->IL0026: Incompatible stack types: I4 vs Obj
		//IL_05ce->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0256->IL0026: Incompatible stack types: I4 vs Obj
		//IL_022b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0943->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0746->IL0026: Incompatible stack types: I4 vs Obj
		//IL_027f->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0404->IL0026: Incompatible stack types: I4 vs Obj
		//IL_08e7->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0775->IL0026: Incompatible stack types: I4 vs Obj
		//IL_08ba->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01be->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0928->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0676->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0478->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0a7f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02d0->IL0026: Incompatible stack heights: 3 vs 1
		//IL_07da->IL0026: Incompatible stack types: I4 vs Obj
		//IL_05ae->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0a08->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0267->IL0026: Incompatible stack types: I4 vs Obj
		//IL_075b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0585->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0739->IL0026: Incompatible stack heights: 2 vs 1
		//IL_094e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0a8a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0a13->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0a64->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 55;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				Authenticator authenticator;
				object obj3;
				object obj4;
				switch ((int)obj2)
				{
				case 2:
				case 51:
					obj = ((Authenticator)/*Error near IL_0185: Stack underflow*/).Listener;
					obj2 = 52;
					continue;
				case 13:
					((Authenticator)/*Error near IL_0198: Stack underflow*/).Listener = (TcpListener?)obj;
					((Authenticator)/*Error near IL_019d: Stack underflow*/).StartListening((int)/*Error near IL_019d: Stack underflow*/);
					obj = (object)/*Error near IL_019f: Stack underflow*/;
					obj2 = 35;
					if (Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton == null)
					{
						obj2 = 76;
					}
					continue;
				case 47:
					goto IL_01f1;
				case 75:
					goto IL_020e;
				case 69:
					obj = 1;
					obj2 = 49;
					continue;
				case 41:
				case 49:
					if (obj == null)
					{
						obj2 = 27;
						continue;
					}
					((JavaGameValue)/*Error near IL_0a69: Stack underflow*/).SaveOptions = (byte)/*Error near IL_0a69: Stack underflow*/ != 0;
					goto IL_0a69;
				case 82:
					goto IL_0267;
				case 29:
					goto IL_02a3;
				case 34:
					goto IL_02d0;
				case 78:
					goto IL_02e1;
				case 26:
					goto IL_02f6;
				case 64:
					goto IL_0336;
				case 3:
					goto IL_0378;
				case 6:
					goto IL_0390;
				case 19:
					goto IL_03a8;
				case 4:
					goto IL_03de;
				case 1:
					goto IL_0422;
				case 23:
					goto IL_0433;
				case 24:
					goto IL_044b;
				case 56:
					goto IL_0478;
				case 25:
					(FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14.AnalyzeHandler() ? ((AsyncTaskMethodBuilder<EntityFeverAppVersion>*)1) : ((AsyncTaskMethodBuilder<EntityFeverAppVersion>*)null))->Start<TStateMachine>(ref *(TStateMachine*)P_1);
					((FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)/*Error near IL_0499: Stack underflow*/)->MoveNext();
					/*Error near IL_0499: Member reference must be method, but was: Field*/;
				case 11:
					goto IL_0547;
				case 59:
					goto IL_0558;
				case 39:
					goto IL_0594;
				case 65:
					goto IL_05bd;
				case 20:
					goto IL_0649;
				case 66:
					goto IL_0676;
				case 38:
					goto IL_0697;
				case 35:
					goto IL_06d0;
				case 63:
					goto IL_070c;
				case 8:
				case 81:
					obj = 0;
					obj2 = 41;
					continue;
				case 55:
					if (((TaskAwaiter<EntityFeverManifestInfo>*)P_1)->GetResult() != null)
					{
						obj2 = 54;
						continue;
					}
					goto case 25;
				case 9:
					if (RestRequestExtensions.AddQueryParameter<_0021_00210>((RestRequest)/*Error near IL_0766: Stack underflow*/, (string)/*Error near IL_0766: Stack underflow*/, (_0021_00210)P_1, Rpc._003CListenAsync_003Ed__34.CheckIntegratedDic()) == null)
					{
						obj2 = 8;
						continue;
					}
					goto case 69;
				case 71:
					goto IL_0775;
				case 36:
					goto IL_07b4;
				case 45:
					goto IL_07e9;
				case 14:
					goto IL_0831;
				case 10:
					goto IL_0888;
				case 7:
					goto IL_08ba;
				case 18:
					goto IL_08f6;
				case 80:
					goto IL_0928;
				default:
					return obj;
				case 40:
					switch (P_0)
					{
					case CrashReason.WindowsIntegerDivideByZero:
						break;
					case CrashReason.ModMissingDep:
						goto IL_01f1;
					case CrashReason.ModConflict:
						goto IL_020e;
					case CrashReason.WindowsDllNotFound:
						goto IL_0267;
					case CrashReason.WindowsIllegalInstruction:
						goto IL_02a3;
					case CrashReason.JavaVersionIncompat:
						goto IL_02d0;
					case CrashReason.GpuDriverAmdCrash:
						goto IL_02e1;
					case CrashReason.WindowsEntryPointNotFound:
						goto IL_02f6;
					case CrashReason.HsErrCrash:
						goto IL_0336;
					case CrashReason.WindowsDllInitializationFailed:
						goto IL_0378;
					case CrashReason.WindowsOutOfMemory:
						goto IL_0390;
					case CrashReason.WindowsInvalidImageFormat:
						goto IL_03a8;
					case CrashReason.ManualDebugCrash:
						goto IL_03de;
					case CrashReason.GameCoreVerificationLibraryCrash:
						goto IL_0422;
					case CrashReason.WindowsBreakpoint:
						goto IL_0433;
					case CrashReason.WindowsAccessViolation:
						goto IL_044b;
					case CrashReason.OutOfMemory:
						goto IL_0478;
					case CrashReason.GpuDriverNvidiaCrash:
						goto IL_0547;
					case CrashReason.WindowsStackBufferOverrun:
						goto IL_0558;
					case CrashReason.NativeComponentLoadFailed:
						goto IL_0594;
					case CrashReason.GpuDriverIntelCrash:
						goto IL_05bd;
					case CrashReason.WindowsPrivilegedInstruction:
						goto IL_0649;
					case CrashReason.ModConfigError:
						goto IL_0676;
					case CrashReason.JavaVersionTooHigh:
						goto IL_0697;
					case CrashReason.WindowsControlC:
						goto IL_06d0;
					case CrashReason.WindowsInPageError:
						goto IL_070c;
					case CrashReason.ModCrash:
						goto IL_0775;
					case CrashReason.OpenGLNotSupported:
						goto IL_07b4;
					case CrashReason.JvmArgError:
						goto IL_07e9;
					case CrashReason.OpenJ9:
						goto IL_0831;
					case CrashReason.ModDuplicate:
						goto IL_0888;
					case CrashReason.WindowsHeapCorruption:
						goto IL_08ba;
					case CrashReason.ModMixinFailed:
						goto IL_08f6;
					case CrashReason.PixelFormatError:
						goto IL_0928;
					default:
						goto IL_09f4;
					case CrashReason.ModExtracted:
						goto IL_0a37;
					}
					goto case 13;
				case 48:
					goto IL_0a37;
				case 27:
					((JavaGameValue)/*Error near IL_0a4d: Stack underflow*/).ReconnectDelay = (int)/*Error near IL_0a4d: Stack underflow*/;
					goto IL_0a69;
				case 54:
					{
						obj = (object)/*Error near IL_0a5a: Stack underflow*/;
						obj2 = 40;
						continue;
					}
					IL_0a37:
					obj = ((JavaGameValue)/*Error near IL_0a3c: Stack underflow*/).ReconnectDelay;
					obj2 = 61;
					continue;
					IL_09f4:
					obj2 = 25;
					if (((ComponentPath)(object)ComponentPath.ComponentName).ComponentZip != null)
					{
						obj2 = 51;
					}
					continue;
					IL_0378:
					obj = FeverInstaller.McBedrock.Client;
					_ = 79;
					continue;
					IL_0928:
					((GameValue)/*Error near IL_092d: Stack underflow*/)._002Ector();
					obj = (object)/*Error near IL_092f: Stack underflow*/;
					obj2 = 53;
					if (((ComponentPath)(object)ComponentPath.Target).Source == null)
					{
						obj2 = 74;
					}
					continue;
					IL_0336:
					((FeverInstaller)/*Error near IL_033b: Stack underflow*/)._002Ector((string)/*Error near IL_033b: Stack underflow*/, (string)/*Error near IL_033b: Stack underflow*/, (string)/*Error near IL_033b: Stack underflow*/);
					obj = (object)/*Error near IL_033d: Stack underflow*/;
					obj2 = 31;
					continue;
					IL_08f6:
					((ILogger)/*Error near IL_0907: Stack underflow*/).Debug<_0021_00210, _0021_00211>((string)/*Error near IL_0907: Stack underflow*/, (_0021_00210)CppGameValue.CheckLogicalContext(), (_0021_00211)((GameValue)obj).MaxConcurrency);
					obj = (object)/*Error near IL_0909: Stack underflow*/;
					obj2 = 12;
					if (BedrockGamePath.StartTemplate == null)
					{
						obj2 = 46;
					}
					continue;
					IL_02f6:
					((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)obj)->MoveNext();
					((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)/*Error near IL_0302: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)/*Error near IL_0302: Stack underflow*/);
					obj = (object)/*Error near IL_0304: Stack underflow*/;
					obj = 73;
					break;
					IL_08ba:
					((CppGameValue)/*Error near IL_08c1: Stack underflow*/).SkinPath = (string)obj;
					obj = CppGameValue.Get((SectionValue)/*Error near IL_08c6: Stack underflow*/);
					obj2 = 72;
					if (((JavaGameValue)JavaGameValue.SetSize__BackingField).WindowWidth__BackingField == 0)
					{
						obj2 = 37;
					}
					continue;
					IL_02e1:
					obj = Authenticator._003CReceiveAsync_003Ed__9.DecorateConvertibleParameter();
					obj = 43;
					break;
					IL_0888:
					((Rpc._003CSyncChaChaAsync_003Ed__38*)/*Error near IL_088d: Stack underflow*/)->MoveNext();
					((Rpc._003CSyncChaChaAsync_003Ed__38*)/*Error near IL_0894: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)obj);
					((Func<RpcCallBack, Task>)/*Error near IL_0899: Stack underflow*/)._002Ector((object)/*Error near IL_0899: Stack underflow*/, (nint)/*Error near IL_0899: Stack underflow*/);
					obj = (object)/*Error near IL_089b: Stack underflow*/;
					obj2 = 83;
					if (((JavaGameValue)JavaGameValue.SaveOptions__BackingField).SetChinese__BackingField == 0)
					{
						obj2 = 29;
					}
					continue;
					IL_02d0:
					obj = Authenticator._003CReceiveAsync_003Ed__9.ReflectAdvancedEnumerator();
					obj2 = 21;
					continue;
					IL_0831:
					((Rpc._003CRemoteCallBackAsync_003Ed__21*)/*Error near IL_0836: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)/*Error near IL_0836: Stack underflow*/);
					obj = (object)/*Error near IL_0838: Stack underflow*/;
					obj = 28;
					break;
					IL_07e9:
					obj = Rpc._003CReceiveAsync_003Ed__28.DecorateOrderedTemplate();
					obj2 = 62;
					continue;
					IL_07b4:
					obj = Rpc._003CListenControlConnectAsync_003Ed__35.DecorateSeparatedSummarizer();
					obj2 = 9;
					if (((Rpc._003CSyncChaChaAsync_003Ed__38)Rpc._003CSyncChaChaAsync_003Ed__38._003C_003Et__builder)._003C_003E4__this == null)
					{
						obj2 = 58;
					}
					continue;
					IL_02a3:
					Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateGenericStruct();
					obj = Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.ReflectRandomReporter();
					_ = 17;
					if (((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.client)->_003C_003E4__this == null)
					{
						_ = 4;
					}
					continue;
					IL_0775:
					((Rpc._003CListenControlConnectAsync_003Ed__35*)/*Error near IL_077a: Stack underflow*/)->MoveNext();
					((Rpc._003CListenControlConnectAsync_003Ed__35*)/*Error near IL_0781: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)obj);
					obj = ((string)/*Error near IL_0786: Stack underflow*/).Replace((string)/*Error near IL_0786: Stack underflow*/, (string?)/*Error near IL_0786: Stack underflow*/);
					obj = 60;
					break;
					IL_020e:
					authenticator = Authenticator.PatchUser();
					((Authenticator._003CListenAsync_003Ed__7*)obj)->MoveNext();
					((AsyncTaskMethodBuilder*)/*Error near IL_021f: Stack underflow*/)->AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref *(TAwaiter*)/*Error near IL_021f: Stack underflow*/, ref *(TStateMachine*)authenticator);
					obj = (object)/*Error near IL_0221: Stack underflow*/;
					obj2 = 67;
					continue;
					IL_0267:
					Authenticator._003CListenAsync_003Ed__7.DecorateExpandableParser();
					obj = Authenticator._003CListenAsync_003Ed__7.ObserveTracker();
					_ = 68;
					continue;
					IL_070c:
					((Rpc)/*Error near IL_0713: Stack underflow*/).SyncChaChaAsync((RpcCallBack)obj);
					obj = Rpc.PopVisitor();
					_ = 15;
					if (Rpc._003CReceiveAsync_003Ed__28.CheckMonoProgram != null)
					{
						_ = 5;
					}
					continue;
					IL_06d0:
					((Rpc)/*Error near IL_06dc: Stack underflow*/).Listener = ((Rpc)obj).Listener;
					obj = (object)/*Error near IL_06de: Stack underflow*/;
					obj2 = 70;
					continue;
					IL_0697:
					((Rpc)/*Error near IL_069c: Stack underflow*/).Writer = (BinaryWriter?)/*Error near IL_069c: Stack underflow*/;
					obj = (object)/*Error near IL_069e: Stack underflow*/;
					obj = 53;
					break;
					IL_0676:
					((Rpc)/*Error near IL_067b: Stack underflow*/).StartListen((int)/*Error near IL_067b: Stack underflow*/);
					((Rpc)obj).Dispose();
					obj = ((TaskAwaiter<EntityFeverApp>*)/*Error near IL_0687: Stack underflow*/)->GetResult();
					obj = 42;
					break;
					IL_0649:
					((Rpc)/*Error near IL_0655: Stack underflow*/).SendMessage((BinaryWriter)/*Error near IL_0655: Stack underflow*/, (object[])(object)((Rpc)obj).Callbacks);
					obj = (object)/*Error near IL_0657: Stack underflow*/;
					obj2 = 12;
					if ((int)((Rpc._003CListenAsync_003Ed__34*)Rpc._003CListenAsync_003Ed__34._003C_003E1__state)->_003C_003Et__builder == 0)
					{
						obj2 = 4;
					}
					continue;
					IL_01f1:
					((Authenticator)/*Error near IL_01f6: Stack underflow*/).Dispose();
					((IAsyncStateMachine)((Authenticator)/*Error near IL_01fd: Stack underflow*/).HandleAuthentication((string)obj)).MoveNext();
					obj = (object)/*Error near IL_0204: Stack underflow*/;
					obj2 = 30;
					continue;
					IL_05bd:
					((Rpc)/*Error near IL_05c2: Stack underflow*/).ProcessId = (int)/*Error near IL_05c2: Stack underflow*/;
					obj = (object)/*Error near IL_05c4: Stack underflow*/;
					obj2 = 33;
					continue;
					IL_0594:
					if (!((TaskAwaiter<RestResponse<EntityFeverResponse<_00210>>>*)FeverInstaller._003CInstallAsync_003Ed__11.SerializeResponder())->IsCompleted)
					{
						_ = 9;
						continue;
					}
					goto case 69;
					IL_0558:
					obj3 = obj;
					((FeverInstaller._003CInstallAsync_003Ed__11*)FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13.DecorateGroupedVisitor())->MoveNext();
					obj = obj3;
					obj2 = 4;
					if ((int)((FeverInstaller._003CInstallAsync_003Ed__11)FeverInstaller._003CInstallAsync_003Ed__11._003C_003Eu__2)._003C_003Eu__3 == 0)
					{
						obj2 = 5;
					}
					continue;
					IL_0a69:
					obj = (object)/*Error near IL_0a6b: Stack underflow*/;
					obj2 = 22;
					if (((CppGamePath)(object)ComponentPath.ReflectEfficientVerifier).BedrockLauncherFile == null)
					{
						obj2 = 5;
					}
					continue;
					IL_0547:
					obj = FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13.CallGateway();
					obj2 = 44;
					continue;
					IL_0478:
					((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14*)/*Error near IL_047d: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)/*Error near IL_047d: Stack underflow*/);
					obj = (object)/*Error near IL_047f: Stack underflow*/;
					obj2 = 57;
					continue;
					IL_044b:
					((FeverInstaller._003CFeverRequest_003Ed__15<>*)/*Error near IL_0452: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)obj);
					obj = FeverInstaller._003CFeverRequest_003Ed__15<>.CheckAdaptableResponder();
					obj2 = 0;
					if (((FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)(nint)FeverInstaller._003CGetFeverManifestAsync_003Ed__12._003C_003E4__this)->info != null)
					{
						obj2 = 0;
					}
					continue;
					IL_0433:
					obj4 = obj;
					((FeverInstaller._003CFeverRequest_003Ed__15<>*)FeverInstaller.CheckStaticProgram())->MoveNext();
					obj = obj4;
					obj2 = 16;
					continue;
					IL_0422:
					obj = FeverInstaller.CheckScopeSummarizer();
					obj2 = 50;
					continue;
					IL_03de:
					obj = ((FeverInstaller)/*Error near IL_03e3: Stack underflow*/).GetFeverAppVersionAsync();
					obj2 = 31;
					if ((int)((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14*)FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14._003C_003E1__state)->_003C_003Et__builder == 0)
					{
						obj2 = 37;
					}
					continue;
					IL_03a8:
					obj = ((FeverInstaller)/*Error near IL_03b4: Stack underflow*/).GetFeverManifestInfoAsync((object)((FeverInstaller)/*Error near IL_03af: Stack underflow*/).GetFeverManifestAsync(obj));
					obj2 = 77;
					continue;
					IL_0390:
					((FeverInstaller)obj).Dispose();
					obj = ((FeverInstaller)/*Error near IL_039c: Stack underflow*/).InstallAsync();
					obj2 = 32;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object 퀀(CrashReason P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778853, new IntPtr(2737337582444L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object 턀(object P_0, object P_1)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 4004, 1790778852, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778852, new IntPtr(2737337573084L), 15);
		}
		return ((delegate*<object, object, object>)obj)(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static (CrashReason, string)? 픀(object P_0, object P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0047: Expected I4, but got Obj
		//IL_00ee: Expected VT, but got Obj
		//IL_0059: Expected Obj, but got I4
		//IL_00d8: Expected Obj, but got Ref
		//IL_00e6: Expected Obj, but got I4
		//IL_0080: Expected native int or pointer, but got Obj
		//IL_014f: Expected Obj, but got I4
		//IL_0104: Expected Obj, but got I4
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected Obj, but got Unknown
		//IL_0130: Expected Obj, but got I4
		//IL_00d0->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00fd->IL00ff: Incompatible stack heights: 2 vs 1
		//IL_0129->IL012b: Incompatible stack heights: 2 vs 1
		//IL_008a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_011a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0095->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 5;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 3:
					((Authenticator)18).Listener = ((Authenticator)P_0).Listener;
					((Authenticator)/*Error near IL_005e: Stack underflow*/).StartListening((int)/*Error near IL_005e: Stack underflow*/);
					((TcpListener)/*Error near IL_0063: Stack underflow*/).Start();
					new AsyncTaskMethodBuilder(ref *(TStateMachine*)/*Error near IL_0068: Stack underflow*/);
					return ((CrashReason, string)?)new AsyncTaskMethodBuilder();
				case 1:
					((Authenticator._003CListenAsync_003Ed__7*)(&obj))->MoveNext();
					if (P_1 != null)
					{
						obj2 = 6;
						continue;
					}
					goto case 2;
				case 5:
					((Authenticator._003CListenAsync_003Ed__7*)P_0)->SetStateMachine((IAsyncStateMachine)(&obj));
					if ((int)/*Error near IL_00dd: Stack underflow*/ != 0)
					{
						obj = 4;
						break;
					}
					if (P_1 == null)
					{
						obj2 = 2;
						continue;
					}
					goto case 1;
				default:
					return ((CrashReason, string)?)obj;
				case 4:
					if (obj != null)
					{
					}
					return ((CrashReason, string)?)new AsyncTaskMethodBuilder((Exception)new ILogger((Exception)/*Error near IL_0104: Stack underflow*/, (string)17));
				case 6:
					if (obj != null)
					{
					}
					return ((CrashReason, string)?)new AsyncTaskMethodBuilder((IAsyncStateMachine)new IAsyncStateMachine((IAsyncStateMachine)17));
				case 2:
					((Authenticator._003CReceiveAsync_003Ed__9*)P_0)->MoveNext();
					if (((TcpListener)/*Error near IL_0141: Stack underflow*/).AcceptTcpClientAsync() == null)
					{
						*(FeverInstaller._003CFeverRequest_003Ed__15<_0021_00210>*)(&obj) = default;
						obj2 = 0;
						if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.listener)->_003C_003E4__this == null)
						{
							obj2 = 0;
						}
						continue;
					}
					obj = 3;
					break;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static (CrashReason, string)? 혀(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778851, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
		return ((CrashReason, string)?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static (CrashReason, string)? _FFFD(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778850, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
		return ((CrashReason, string)?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static (CrashReason, string)? _FFFD(object P_0, object P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0053: Expected I4, but got Obj
		//IL_0189: Expected VT, but got Obj
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected Obj, but got Unknown
		//IL_0137: Expected Obj, but got I4
		//IL_013c: Expected I4, but got Obj
		//IL_013d: Expected VT, but got Obj
		//IL_0065: Expected Obj, but got I4
		//IL_006d: Expected Obj, but got I4
		//IL_012a: Expected Obj, but got I4
		//IL_01a2: Expected Obj, but got I4
		//IL_0099: Expected native int or pointer, but got Obj
		//IL_0167->IL00d0: Incompatible stack heights: 0 vs 1
		//IL_01bb->IL00d0: Incompatible stack heights: 0 vs 1
		//IL_00ec->IL0026: Incompatible stack heights: 2 vs 1
		//IL_012f->IL0022: Incompatible stack heights: 1 vs 0
		//IL_0111->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00f7->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00a3->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0157->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ae->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0162->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 9;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 5:
					((Authenticator)18).Listener = ((Authenticator)P_0).Listener;
					((TcpListener)((object[])(object)Task.Run((Func<Task?>)0))[0]).Start();
					new AsyncTaskMethodBuilder(ref *(TStateMachine*)10);
					return ((CrashReason, string)?)new AsyncTaskMethodBuilder();
				case 8:
					GC.SuppressFinalize(((Authenticator)/*Error near IL_0085: Stack underflow*/).ReceiveAuthenticationDataAsync(P_0));
					if ((int)/*Error near IL_008f: Stack underflow*/ != 0)
					{
						obj2 = 0;
						if ((int)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003E4__this)->_003C_003Eu__1 == 0)
						{
							obj2 = 3;
						}
						continue;
					}
					if (P_1 == null)
					{
						obj2 = 4;
						if (FeverInstaller.McBedrock__BackingField == null)
						{
							obj2 = 1;
						}
						continue;
					}
					goto default;
				case 2:
					((Authenticator._003CListenAsync_003Ed__7*)Authenticator.PatchUser())->MoveNext();
					((Authenticator._003CListenAsync_003Ed__7*)18)->SetStateMachine((IAsyncStateMachine)P_1);
					((TaskAwaiter*)/*Error near IL_00c5: Stack underflow*/)->GetResult();
					return ((CrashReason, string)?)new AsyncTaskMethodBuilder((Exception)new ILogger((Exception)/*Error near IL_00ca: Stack underflow*/, (string)/*Error near IL_00ca: Stack underflow*/));
				case 4:
				case 7:
					obj = null;
					_ = 0;
					if ((int)((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003C_003E1__state)->_003C_003Et__builder == 0)
					{
						_ = 1;
					}
					continue;
				case 9:
					((Authenticator._003CReceiveAsync_003Ed__9*)P_0)->MoveNext();
					if (((TcpListener)/*Error near IL_0102: Stack underflow*/).AcceptTcpClientAsync() == null)
					{
						obj2 = 8;
						continue;
					}
					goto case 5;
				default:
					if ((Authenticator._003CReceiveAsync_003Ed__9.ReflectAdvancedEnumerator() ? ((TaskAwaiter<TcpClient>*)1) : ((TaskAwaiter<TcpClient>*)null))->GetResult() != null)
					{
						obj = 6;
						break;
					}
					goto case 4;
				case 3:
					return ((CrashReason, string)?)(object)new Encoding((byte[])/*Error near IL_013c: Stack underflow*/, (int)/*Error near IL_013c: Stack underflow*/, (int)new Encoding((string)15));
				case 1:
					return ((CrashReason, string)?)obj;
				case 6:
					((FeverInstaller)P_1).Dispose();
					((Stream)/*Error near IL_0194: Stack underflow*/).Write((byte[])/*Error near IL_0194: Stack underflow*/, (int)/*Error near IL_0194: Stack underflow*/, (int)/*Error near IL_0194: Stack underflow*/);
					if ((int)/*Error near IL_0199: Stack underflow*/ == 0)
					{
						obj = 7;
						break;
					}
					goto case 2;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static (CrashReason, string)? _FFFD(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778849, new IntPtr(2737337582444L), 15))(null, 0, new IntPtr(0L));
		return ((CrashReason, string)?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _E000(object P_0, object P_1, object P_2)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778848, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _E100(object P_0, object P_1, object P_2)
	{
		//IL_0029: Expected Obj, but got I
		//IL_005a: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 4020, 1790778783, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 3, 1790778783, new IntPtr(2737337595964L), 15);
		}
		return ((delegate*<object, object, object, object>)obj)(P_0, P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static byte _EC00(object P_0, nint P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0073: Expected I4, but got Obj
		//IL_01df: Expected Obj, but got I4
		//IL_00a5: Expected I4, but got Obj
		//IL_0259: Expected I4, but got Obj
		//IL_0139: Expected Obj, but got I4
		//IL_01ed: Expected Obj, but got I4
		//IL_0217: Expected I4, but got Obj
		//IL_0219: Expected Obj, but got I4
		//IL_00e9: Expected native int or pointer, but got Obj
		//IL_0090->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01b5->IL009f: Incompatible stack heights: 1 vs 0
		//IL_018b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_015f->IL0124: Incompatible stack heights: 0 vs 1
		//IL_0200->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0282->IL0124: Incompatible stack heights: 0 vs 1
		//IL_025e->IL0124: Incompatible stack heights: 0 vs 1
		//IL_02a6->IL0124: Incompatible stack heights: 0 vs 1
		//IL_019b->IL0124: Incompatible stack heights: 0 vs 1
		//IL_014f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01f2->IL0022: Incompatible stack heights: 1 vs 0
		//IL_00d3->IL0026: Incompatible stack types: I4 vs Obj
		//IL_009b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01c9->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00b9->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0272->IL0026: Incompatible stack types: I4 vs Obj
		//IL_024e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_022d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01a5->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00f3->IL0026: Incompatible stack heights: 2 vs 1
		//IL_015a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01d4->IL0026: Incompatible stack heights: 2 vs 1
		//IL_027d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0238->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00fe->IL0026: Incompatible stack heights: 2 vs 1
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 5;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 3:
					Unsafe.Write((void*)P_1, obj);
					obj2 = 2;
					if ((int)((Authenticator._003CListenAsync_003Ed__7*)Authenticator._003CListenAsync_003Ed__7._003C_003E1__state)->_003C_003Et__builder != 0)
					{
						obj2 = 2;
					}
					break;
				case 2:
					return 1;
				case 7:
					((Authenticator)/*Error near IL_00a5: Stack underflow*/).StartListening((int)P_0);
					((TcpListener)/*Error near IL_00aa: Stack underflow*/).Start();
					if ((int)/*Error near IL_00af: Stack underflow*/ != 0)
					{
						obj2 = 6;
						break;
					}
					goto case 1;
				case 1:
					if (((AsyncTaskMethodBuilder*)((Authenticator)/*Error near IL_00bf: Stack underflow*/).ListenAuthenticationConnectAsync(P_0))->Task != null)
					{
						obj2 = 9;
						break;
					}
					goto default;
				case 17:
					if ((int)AsyncTaskMethodBuilder.Create() != 0)
					{
						return 1;
					}
					_ = 1;
					if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.listener)->_003C_003E4__this == null)
					{
						_ = 3;
					}
					break;
				case 16:
					return 0;
				case 6:
				case 9:
				case 12:
					((Authenticator._003CListenAsync_003Ed__7*)P_0)->MoveNext();
					((Authenticator._003CListenAsync_003Ed__7*)/*Error near IL_012f: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)P_0);
					((ILogger)/*Error near IL_0139: Stack underflow*/).Error((Exception)/*Error near IL_0139: Stack underflow*/, (string)Authenticator._003CListenAsync_003Ed__7.DecorateExpandableParser());
					obj = (object)/*Error near IL_013b: Stack underflow*/;
					obj2 = 5;
					if (Authenticator._003CReceiveAsync_003Ed__9.CheckCustomChain == null)
					{
						obj2 = 11;
					}
					break;
				case 5:
					Unsafe.Write((void*)P_1, null);
					obj2 = 4;
					break;
				case 15:
					((Authenticator._003CReceiveAsync_003Ed__9*)P_0)->MoveNext();
					if (((TcpListener)/*Error near IL_0196: Stack underflow*/).AcceptTcpClientAsync() == null)
					{
						obj2 = 16;
						break;
					}
					goto case 6;
				case 4:
					if ((Authenticator._003CReceiveAsync_003Ed__9.ReflectAdvancedEnumerator() ? ((TaskAwaiter<TcpClient>*)1) : ((TaskAwaiter<TcpClient>*)null))->GetResult() != null)
					{
						_ = 12;
						if (((FeverInstaller)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.ReflectMixedGateway)._003CfeverVersion_003EP == null)
						{
							_ = 9;
						}
						break;
					}
					goto case 7;
				default:
					if (((TcpClient)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.DecorateFlexibleProfiler()).GetStream() == null)
					{
						goto end_IL_0026;
					}
					goto case 6;
				case 8:
					Unsafe.Write((void*)P_1, obj);
					obj2 = 13;
					break;
				case 13:
					return 1;
				case 14:
					((FeverInstaller)/*Error near IL_0208: Stack underflow*/)._002Ector((string)/*Error near IL_0208: Stack underflow*/, (string)/*Error near IL_0208: Stack underflow*/, (string)P_0);
					obj = ((Stream)/*Error near IL_0217: Stack underflow*/).Read((byte[])/*Error near IL_0217: Stack underflow*/, (int)/*Error near IL_0217: Stack underflow*/, (int)FeverInstaller.McBedrock.Client);
					obj2 = 17;
					if (((FeverInstaller._003CFeverRequest_003Ed__15<>)FeverInstaller._003CFeverRequest_003Ed__15<>._003C_003Et__builder)._003C_003E4__this != null)
					{
						obj2 = 14;
					}
					break;
				case 11:
					((RestClientOptions)obj)._002Ector();
					if ((int)/*Error near IL_0244: Stack underflow*/ != 0)
					{
						obj2 = 14;
						break;
					}
					goto case 8;
				case 10:
					((RestClientOptions)/*Error near IL_0259: Stack underflow*/).AutomaticDecompression = (DecompressionMethods)((FeverInstaller)P_0).GetFeverAppVersionAsync();
					if ((int)/*Error near IL_025e: Stack underflow*/ == 0)
					{
						obj2 = 13;
						if (((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14)FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14._003C_003Et__builder)._003C_003E4__this == null)
						{
							obj2 = 15;
						}
						break;
					}
					goto case 6;
				}
				continue;
				end_IL_0026:
				break;
			}
			obj = 10;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static byte _ED00(object P_0, nint P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778782, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _EE00(object P_0, IReadOnlyList<string> P_1, uint P_2)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778781, new IntPtr(2737337582444L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _EF00(object P_0, IReadOnlyList<string> P_1, uint P_2)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_004e: Expected I4, but got Obj
		//IL_0062: Expected Obj, but got I4
		//IL_0073: Expected native int or pointer, but got Obj
		//IL_007d->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0088->IL0026: Incompatible stack heights: 2 vs 1
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				return ((Authenticator)obj).Listener;
			case 1:
				((Authenticator)/*Error near IL_0048: Stack underflow*/).Listener = (TcpListener?)P_1;
				((Authenticator)/*Error near IL_004e: Stack underflow*/).StartListening((int)P_0);
				obj = (object)/*Error near IL_0050: Stack underflow*/;
				obj = ((Authenticator)P_0).ListenAsync();
				obj = (obj = ((Authenticator)obj).ListenAuthenticationConnectAsync((object)P_2));
				_ = 0;
				if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.listener)->_003C_003E4__this == null)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _F000(object P_0, IReadOnlyList<string> P_1, uint P_2)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778780, new IntPtr(2737337583484L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _F100(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778779, new IntPtr(2737337590764L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _F200(object P_0, object P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0042: Expected VT, but got Obj
		//IL_0120: Expected VT, but got Obj
		//IL_0141: Expected Obj, but got I
		//IL_0147: Expected VT, but got Obj
		//IL_0082: Expected I, but got Obj
		//IL_0178: Expected Obj, but got I
		//IL_0120->IL0120: Incompatible stack heights: 4 vs 2
		//IL_0147->IL0147: Incompatible stack heights: 2 vs 1
		//IL_015c->IL0173: Incompatible stack heights: 1 vs 3
		//IL_0184->IL0055: Incompatible stack heights: 2 vs 1
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		int num;
		Authenticator authenticator;
		TcpClient client;
		object second;
		switch ((int)obj)
		{
		case 1:
			{
				((ILogger)/*Error near IL_0042: Stack underflow*/).Debug<_0021_00210>((string)/*Error near IL_0042: Stack underflow*/, (_0021_00210)P_0);
				if ((int)/*Error near IL_0047: Stack underflow*/ == 0)
				{
					num = 3;
					goto IL_0055;
				}
				goto IL_00f7;
			}
			IL_0055:
			while (true)
			{
				object obj2;
				switch (num)
				{
				case 4:
					((Func<Task>)/*Error near IL_0082: Stack underflow*/)._002Ector((object)/*Error near IL_0082: Stack underflow*/, (nint)obj);
					obj2 = Task.Run((Func<Task?>)/*Error near IL_0087: Stack underflow*/);
					goto IL_0185;
				case 3:
					obj = null;
					num = 0;
					if (Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton == null)
					{
						num = 0;
					}
					continue;
				case 2:
					if (obj == null)
					{
						num = 1;
						if ((int)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003E1__state)->_003C_003Et__builder != 0)
						{
							num = 1;
						}
						continue;
					}
					goto case 4;
				case 6:
					goto end_IL_0055;
				case 1:
					{
						obj2 = null;
						goto IL_0185;
					}
					IL_0185:
					obj = obj2;
					num = 5;
					if (FeverInstaller.McBedrock__BackingField == null)
					{
						num = 4;
					}
					continue;
				}
				goto end_IL_0026;
				continue;
				end_IL_0055:
				break;
			}
			goto IL_00f7;
			IL_00f7:
			GC.SuppressFinalize(P_1);
			authenticator = Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003E4__this;
			if (authenticator == null)
			{
				_ = Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003Eu__1;
				_ = (delegate*<Authenticator>)(&Authenticator.PatchUser);
				Authenticator._003CReceiveAsync_003Ed__9._003C_003Et__builder = (AsyncTaskMethodBuilder)new Task();
			}
			((AsyncTaskMethodBuilder<_00210>*)/*Error near IL_0125: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter<RestResponse<EntityFeverResponse<_00210>>>*)P_0, ref *(FeverInstaller._003CFeverRequest_003Ed__15<_00210>*)authenticator);
			client = Authenticator._003CReceiveAsync_003Ed__9.client;
			if (client == null)
			{
				_ = Authenticator._003CReceiveAsync_003Ed__9._003C_003Eu__1;
				Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003C_003Et__builder = (AsyncTaskMethodBuilder)new IAsyncStateMachine((IAsyncStateMachine)__ldftn(Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.SetStateMachine));
			}
			((AsyncTaskMethodBuilder<EntityFeverManifestInfo>*)/*Error near IL_014c: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter<EntityFeverManifestInfo>*)/*Error near IL_014c: Stack underflow*/, ref *(FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13*)client);
			if (Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003C_003E4__this == null)
			{
				_ = Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003Cstream_003E5__2;
				second = (FeverInstaller._003CfeverVersion_003EP = new Encoding());
			}
			obj = ((IEnumerable<byte>)(delegate*<object>)(&Authenticator._003CReceiveAsync_003Ed__9.DecorateConvertibleParameter)).Concat((IEnumerable<byte>)second);
			_ = 2;
			goto IL_0055;
			end_IL_0026:
			break;
		}
		return obj;
	}
}
