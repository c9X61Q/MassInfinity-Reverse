using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Mass.Common.Helpers;
using Mass.Domain.Desktop.ValueObjects;
using Mass.Domain.Value;
using Mass.Game.Launcher.Entities.Fever;
using Mass.Game.Launcher.Java;
using Mass.Game.Launcher.Models;
using Mass.Game.Launcher.Values;
using RestSharp;
using Serilog;

namespace Mass.Game.Launcher.Paths;

public class JavaGamePath : GamePath
{
	public readonly string Java;

	public readonly string JavaUrl;

	public readonly string JavaTarget;

	public readonly string JavaZip;

	public readonly string JavaExe;

	public readonly string GameBase;

	public readonly string GameBaseComponents;

	public readonly string GameBaseMd5;

	public readonly MinecraftPath BaseMinecraft;

	public readonly string GameVersionMd5;

	public readonly string GameCoreLibs;

	public readonly string GameCoreLibMd5;

	public readonly string GameRuntime;

	public readonly string GameRuntimeMd5;

	public readonly string Custom;

	public readonly string CustomOptions;

	public readonly string GameCustom;

	public readonly MinecraftPath Minecraft;

	internal static JavaGamePath ReflectCentralEmitter;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe JavaGamePath(EntityLaunchJavaGame args)
	{
		//IL_0136: Expected native int or pointer, but got Obj
		//IL_0151: Expected Obj, but got I4
		//IL_0151: Expected native int or pointer, but got Obj
		//IL_021a: Expected native int or pointer, but got Obj
		//IL_0229: Expected Ref, but got VT
		//IL_022e: Expected VT, but got Obj
		//IL_0229: Expected native int or pointer, but got Obj
		//IL_0238: Expected native int or pointer, but got Obj
		//IL_01fa: Expected native int or pointer, but got Obj
		//IL_027a: Expected native int or pointer, but got Obj
		//IL_01d6: Expected native int or pointer, but got Obj
		//IL_01e5: Expected native int or pointer, but got VT
		//IL_01f3: Expected Obj, but got I4
		//IL_031e: Expected native int or pointer, but got Obj
		//IL_0332: Expected I4, but got Obj
		//IL_04ab: Expected I4, but got Obj
		//IL_02c8: Expected I4, but got Obj
		//IL_00aa: Expected native int or pointer, but got Obj
		//IL_00b6: Expected Ref, but got VT
		//IL_00bb: Expected I4, but got Obj
		//IL_00b6: Expected native int or pointer, but got Obj
		//IL_024f: Expected native int or pointer, but got Obj
		//IL_0259: Expected Ref, but got VT
		//IL_038b: Expected native int or pointer, but got Obj
		//IL_03a5: Expected native int or pointer, but got Obj
		//IL_03b6: Expected native int or pointer, but got Obj
		//IL_01ad: Expected native int or pointer, but got Obj
		//IL_01b7: Expected Obj, but got VT
		//IL_01cf: Expected Obj, but got I4
		//IL_0187: Expected Obj, but got I4
		//IL_00f6: Expected native int or pointer, but got Obj
		//IL_010b: Expected Ref, but got VT
		//IL_0115: Expected Obj, but got VT
		//IL_0110: Expected native int or pointer, but got VT
		//IL_02f3: Expected native int or pointer, but got Obj
		//IL_037a: Invalid comparison between Unknown and I4
		//IL_04ce: Expected I4, but got Obj
		//IL_04ce: Expected Obj, but got I4
		//IL_04be: Expected I4, but got Obj
		//IL_046c: Expected I4, but got Obj
		//IL_046c: Expected Obj, but got I4
		//IL_04e2: Expected Obj, but got I4
		//IL_0476: Expected I4, but got Obj
		//IL_0476: Expected Obj, but got I
		//IL_0480: Expected Obj, but got I4
		//IL_0434: Expected Obj, but got I
		//IL_0425: Expected I, but got Obj
		//IL_0434: Expected Obj, but got I
		//IL_0242->IL0042: Incompatible stack heights: 1 vs 2
		//IL_0218->IL0042: Incompatible stack heights: 3 vs 2
		//IL_0346->IL0042: Incompatible stack heights: 1 vs 2
		//IL_02e6->IL0042: Incompatible stack heights: 1 vs 2
		//IL_00cf->IL0042: Incompatible stack heights: 1 vs 2
		//IL_03b4->IL0042: Incompatible stack heights: 4 vs 2
		//IL_03e9->IL0042: Incompatible stack heights: 1 vs 2
		//IL_036a->IL03ee: Incompatible stack heights: 2 vs 0
		//IL_01d4->IL003e: Incompatible stack heights: 0 vs 2
		//IL_019b->IL0042: Incompatible stack heights: 1 vs 2
		//IL_0129->IL0042: Incompatible stack heights: 3 vs 2
		//IL_031c->IL0042: Incompatible stack heights: 1 vs 2
		//IL_037f->IL0360: Incompatible stack heights: 0 vs 1
		//IL_00f4->IL0042: Incompatible stack heights: 1 vs 2
		//IL_03fa->IL0042: Incompatible stack heights: 1 vs 2
		//IL_024d->IL0042: Incompatible stack heights: 1 vs 2
		//IL_0042->IL0042: Incompatible stack heights: 3 vs 2
		//IL_0351->IL0042: Incompatible stack heights: 1 vs 2
		//IL_02f1->IL0042: Incompatible stack heights: 1 vs 2
		//IL_00da->IL0042: Incompatible stack heights: 1 vs 2
		//IL_03ee->IL03ee: Incompatible stack heights: 2 vs 0
		//IL_0467->IL046c: Incompatible stack heights: 5 vs 4
		//IL_041b->IL0420: Incompatible stack types: I4 vs Obj
		//IL_0134->IL0042: Incompatible stack heights: 3 vs 2
		//IL_0389->IL0042: Incompatible stack heights: 1 vs 2
		//IL_04ec->IL0042: Incompatible stack heights: 1 vs 2
		//IL_0494->IL0042: Incompatible stack heights: 1 vs 2
		//IL_0439->IL0042: Incompatible stack heights: 1 vs 2
		//IL_049f->IL0042: Incompatible stack heights: 1 vs 2
		//IL_0444->IL0042: Incompatible stack heights: 1 vs 2
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = ((Authenticator)(object)this).Listener;
		int num = 0;
		if (((Authenticator._003CListenAsync_003Ed__7)Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this == null)
		{
			num = 0;
		}
		object obj3 = default;
		while (true)
		{
			switch (num)
			{
			case 11:
				((AsyncTaskMethodBuilder*)((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003Eu__1)->Start<TStateMachine>(ref *(TStateMachine*)obj3);
				((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)obj)->_003C_003E1__state = (int)this;
				_ = 8;
				if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003Et__builder).listener == null)
				{
					_ = 19;
				}
				break;
			default:
				if ((nuint)(nint)((Authenticator)obj).HandleAuthentication((string)(object)args) <= (nuint)1016000u)
				{
					_ = 2;
					break;
				}
				((Rpc._003CListenAsync_003Ed__34*)args)->MoveNext();
				if ((int)/*Error near IL_037f: Stack underflow*/ > 1020000)
				{
					_ = 14;
					break;
				}
				goto case 16;
			case 21:
			{
				TaskAwaiter<TcpClient> taskAwaiter = ((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)this)->_003C_003Eu__1;
				((Authenticator._003CListenAsync_003Ed__7*)((Task)(object)Authenticator.PatchUser()).GetAwaiter())->SetStateMachine((IAsyncStateMachine)args);
				Unsafe.Write(&((Authenticator._003CReceiveAsync_003Ed__9*)(nint)taskAwaiter)->client, (TcpClient)new Authenticator._003CListenAsync_003Ed__7());
				_ = 1;
				if (Authenticator._003CReceiveAsync_003Ed__9.CheckCustomChain == null)
				{
					_ = 1;
				}
				break;
			}
			case 1:
			{
				int num3 = ((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)this)->_003C_003E1__state;
				object obj5 = Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.ReflectRandomReporter();
				((Authenticator._003CReceiveAsync_003Ed__9*)args)->MoveNext();
				((Authenticator._003CReceiveAsync_003Ed__9*)obj5)->SetStateMachine((IAsyncStateMachine)args);
				Unsafe.Write(&((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)this)->_003C_003Eu__1, (TaskAwaiter<string>)((Task<TcpClient>)num3).GetAwaiter());
				num = 0;
				if (((FeverInstaller)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.ReflectMixedGateway)._003CfeverVersion_003EP != null)
				{
					num = 7;
				}
				break;
			}
			case 20:
				((FeverInstaller)(object)this)._002Ector((string)((FeverInstaller)(object)this)._003CappId_003EP, (string)0, (string)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.HandleNotifier());
				((TcpClient)obj).Close();
				FeverInstaller.ReflectVisualArgument = (object)/*Error near IL_0191: Stack underflow*/;
				_ = 22;
				break;
			case 2:
				((FeverInstaller)obj).Dispose();
				goto IL_03ee;
			case 6:
				return;
			case 19:
				((RestClientOptions)/*Error near IL_01c1: Stack underflow*/).UserAgent = (string)(object)((FeverInstaller)obj).GetFeverManifestInfoAsync((object)((FeverInstaller)(object)this).GetFeverManifestAsync((object)((FeverInstaller._003CFeverRequest_003Ed__15<>*)(nint)this)->_003C_003Et__builder));
				((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14*)(nint)/*Error near IL_01c6: Stack underflow*/)->_003C_003E1__state = (int)/*Error near IL_01c6: Stack underflow*/;
				obj3 = 3;
				break;
			case 7:
				Unsafe.Write(&FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14.CheckBasicEncryptor, (FeverInstaller.CheckScopeSummarizer() ? ((AsyncTaskMethodBuilder<EntityFeverManifest>*)1) : ((AsyncTaskMethodBuilder<EntityFeverManifest>*)null))->Task);
				obj3 = 12;
				break;
			case 4:
				Unsafe.Write(&((FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)((FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)(nint)this)->_003C_003E1__state)->info, (FeverInstaller._003CFeverRequest_003Ed__15<>.CheckAdaptableResponder() ? ((AsyncTaskMethodBuilder<EntityFeverManifestInfo>*)1) : ((AsyncTaskMethodBuilder<EntityFeverManifestInfo>*)null))->Task);
				_ = 15;
				break;
			case 3:
				((AsyncTaskMethodBuilder<EntityFeverAppVersion>*)((FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)(nint)this)->_003C_003Eu__1)->Start<TStateMachine>(ref *(FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14.AnalyzeHandler() ? ((TStateMachine*)1) : ((TStateMachine*)null)));
				Unsafe.Write(&((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13*)(nint)obj)->_003C_003Et__builder, (AsyncTaskMethodBuilder<EntityFeverManifestInfo>)this);
				_ = 8;
				if (((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13*)(nint)FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13._003C_003E4__this)->version == null)
				{
					_ = 4;
				}
				break;
			case 12:
				((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13*)((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13*)(nint)this)->_003C_003Eu__1)->MoveNext();
				((AsyncTaskMethodBuilder<_0021_00210>*)obj)->Start<TStateMachine>(ref *(TStateMachine*)this);
				obj = args;
				Unsafe.Write(&((FeverInstaller._003CInstallAsync_003Ed__11*)(FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13.CallGateway() ? 1 : 0))->_003C_003Eu__1, (TaskAwaiter<EntityFeverAppVersion>)new FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13());
				num = 4;
				break;
			case 5:
				_ = ((FeverInstaller._003CInstallAsync_003Ed__11*)(nint)this)->_003C_003Eu__2;
				_ = ref obj3;
				_ = 5;
				_ = 1;
				/*Error near IL_0283: Member reference must be method, but was: Field*/;
			case 10:
				((Rpc)obj)._002Ector((ILogger)(object)this, (byte)(int)((Rpc)(object)this).Listener__BackingField != 0);
				((AsyncTaskMethodBuilder<EntityFeverAppVersion>*)/*Error near IL_02cd: Stack underflow*/)->SetResult((EntityFeverAppVersion)/*Error near IL_02cd: Stack underflow*/);
				Rpc.ParseMap = (object)/*Error near IL_02d2: Stack underflow*/;
				_ = 18;
				if ((int)((Rpc._003CListenAsync_003Ed__34*)Rpc._003CListenAsync_003Ed__34._003C_003E1__state)->_003C_003Et__builder == 0)
				{
					_ = 12;
				}
				break;
			case 22:
			{
				Rpc rpc = ((Rpc._003CListenAsync_003Ed__34*)(nint)this)->_003C_003E4__this;
				((Rpc)(object)args).Dispose();
				((Rpc)(object)this).Writer = rpc.Writer;
				((AsyncTaskMethodBuilder<EntityFeverAppVersion>*)/*Error near IL_030d: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)obj);
				Unsafe.Write(&((Rpc._003CListenControlConnectAsync_003Ed__35*)(nint)/*Error near IL_0312: Stack underflow*/)->listener, /*Error near IL_0312: Stack underflow*/);
				_ = 5;
				break;
			}
			case 8:
				((Rpc)(object)this).Listener = (TcpListener?)(object)((Rpc._003CListenControlConnectAsync_003Ed__35*)(nint)this)->_003C_003E4__this;
				((Rpc._003CReceiveAsync_003Ed__28*)(nint)/*Error near IL_0332: Stack underflow*/)->_003C_003E1__state = (int)((TaskAwaiter<RestResponse<EntityFeverManifest>>*)obj)->GetResult();
				_ = 20;
				if (((Rpc._003CReceiveAsync_003Ed__28)Rpc._003CReceiveAsync_003Ed__28._003C_003Et__builder).client == null)
				{
					_ = 14;
				}
				break;
			case 16:
				Rpc.CheckConnectedDecider();
				goto IL_03ee;
			case 13:
			{
				_ = ((Rpc._003CRemoteCallBackAsync_003Ed__21*)(nint)this)->_003C_003E1__state;
				bool length = Rpc._003CListenAsync_003Ed__34.CheckIntegratedDic();
				((Rpc._003CListenControlConnectAsync_003Ed__35*)Rpc._003CListenAsync_003Ed__34.CheckLocalObject())->MoveNext();
				Unsafe.Write(&Rpc._003CRemoteCallBackAsync_003Ed__21.MeasureCalc, RandomHelper.GetHex(length ? 1 : 0));
				_ = 21;
				break;
			}
			case 15:
				((Rpc._003CReceiveAsync_003Ed__28*)((Rpc._003CSyncChaChaAsync_003Ed__38*)(nint)this)->_003C_003E1__state)->MoveNext();
				((Rpc._003CReceiveAsync_003Ed__28*)this)->SetStateMachine((IAsyncStateMachine)args);
				((AsyncTaskMethodBuilder<EntityFeverManifestInfo>*)/*Error near IL_03cb: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)obj);
				((GameValue)/*Error near IL_03df: Stack underflow*/).MaxConcurrency__BackingField = (((TaskAwaiter<EntityFeverManifest>*)((TaskAwaiter<EntityFeverAppVersion>*)Rpc._003CReceiveAsync_003Ed__28.ReflectVisualAuditor())->GetResult())->IsCompleted ? 1 : 0);
				_ = 9;
				break;
			case 14:
				Rpc._003CRemoteCallBackAsync_003Ed__21.ConvertFilter();
				goto IL_03ee;
			case 18:
			{
				((Rpc._003CSyncChaChaAsync_003Ed__38*)obj3)->MoveNext();
				((Dictionary<ushort, Func<RpcCallBack, Task>>)(object)this)._002Ector();
				object obj4 = ((obj != null) ? Rpc._003CSyncChaChaAsync_003Ed__38.CheckAlphabeticPolicy() : ((object)Rpc._003CSyncChaChaAsync_003Ed__38.DecorateConnectedMapper()));
				((JavaGameValue)/*Error near IL_0425: Stack underflow*/).SetChinese__BackingField = (nint)obj4;
				_ = 17;
				if (((JavaGameValue)JavaGameValue.SetGuiScale__BackingField).GuiScale__BackingField == 0)
				{
					_ = 17;
				}
				break;
			}
			case 17:
			{
				nint num2 = ((JavaGameValue)(object)this).SetSize__BackingField;
				bool flag = CppGameValue.ReflectEditableRecord();
				object obj2 = obj3;
				List<ConfigValue> desktopValue;
				if (((MemberInfo)(object)CppGameValue.CheckLogicalContext()).Name != null)
				{
					desktopValue = GameValue.GetDesktopValue((string)flag, (EnumGameVersion)(int)obj2);
				}
				((ComponentPath)obj).Source = (string)BitConverter.ToUInt16((byte[])(object)this, BitConverter.ToInt16((byte[])num2, (int)GameValue.GetMobileValue((string)(object)desktopValue)));
				_ = 8;
				if (((ComponentPath)(object)ComponentPath.ComponentName).ComponentZip == null)
				{
					_ = 11;
				}
				break;
			}
			case 9:
				{
					((JavaGameValue)(object)this).Reconnect = (byte)(int)((ComponentPath)this).ComponentMd5 != 0;
					if (((JavaGameValue)(object)args).ReconnectDelay != 9)
					{
						((JavaGameValue)obj).ReconnectDelay = (int)args;
					}
					else
					{
						((JavaGameValue)((JavaGameValue)obj).SaveOptions).SaveOptions = (byte)(int)args != 0;
						((BinaryReader)/*Error near IL_04d3: Stack underflow*/)._002Ector((Stream)/*Error near IL_04d3: Stack underflow*/);
						((BinaryWriter)/*Error near IL_04d8: Stack underflow*/)._002Ector((Stream)/*Error near IL_04d8: Stack underflow*/);
					}
					((CppGamePath)/*Error near IL_04e2: Stack underflow*/).BedrockHash = (string)((TcpClient)/*Error near IL_04dd: Stack underflow*/).Connected;
					_ = 6;
					break;
				}
				IL_03ee:
				obj3 = (object)/*Error near IL_03f0: Stack underflow*/;
				_ = 10;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object GetGameVersionNameLower(EnumGameVersion version)
	{
		return _FF00_FF00贀(version);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object GetMd5FileName(EnumGameVersion version, object suffix = "")
	{
		return _FF00_FF00退(version, suffix);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CheckStatelessRunner()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static JavaGamePath DecorateScheduledClient()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00褀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778378, new IntPtr(2737337563724L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00言()
	{
		//IL_001a: Expected Obj, but got I4
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00謀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778377, new IntPtr(2737337563724L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00谀()
	{
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00贀(EnumGameVersion P_0)
	{
		//IL_001a: Expected VT, but got I4
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		((ILogger)/*Error near IL_001a: Stack underflow*/).Debug<_0021_00210>((string)/*Error near IL_001a: Stack underflow*/, (_0021_00210)P_0);
		((Func<Task>)/*Error near IL_001f: Stack underflow*/)._002Ector((object)/*Error near IL_001f: Stack underflow*/, (nint)/*Error near IL_001f: Stack underflow*/);
		return (object)/*Error near IL_0020: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00踀(EnumGameVersion P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778376, new IntPtr(2737337545004L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00輀(EnumGameVersion P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778375, new IntPtr(2737337535644L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00退(EnumGameVersion P_0, object P_1)
	{
		//IL_001a: Expected Obj, but got I4
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		((Authenticator)(object)((Authenticator)P_0).Listener).Listener = (TcpListener?)P_1;
		return Task.Run((Func<Task?>)/*Error near IL_0025: Stack underflow*/);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00鄀(EnumGameVersion P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778374, new IntPtr(2737337563724L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}
}
