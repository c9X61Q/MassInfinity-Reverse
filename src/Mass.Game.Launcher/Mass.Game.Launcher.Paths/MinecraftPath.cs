using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Mass.Application.Extensions;
using Mass.Domain.Desktop.ValueObjects;
using Mass.Game.Launcher.Entities.Fever;
using RestSharp;
using Serilog;

namespace Mass.Game.Launcher.Paths;

public class MinecraftPath
{
	public readonly string Root;

	public readonly string Versions;

	public readonly string Version;

	public readonly string VersionDat;

	public readonly string VersionJson;

	public readonly string VersionJar;

	public readonly string Natives;

	public readonly string GameAuthenticationDll;

	public readonly string Runtime;

	public readonly string Mods;

	public readonly string ModSettings;

	public readonly string WordV;

	public readonly string Libraries;

	public readonly string Assets;

	public readonly string Options;

	public readonly string OptionsShaders;

	internal static MinecraftPath CheckFilteredListener;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe MinecraftPath(string mcPath, EnumGameVersion version)
	{
		//IL_001a: Expected VT, but got Obj
		//IL_0264: Expected native int or pointer, but got Obj
		//IL_026e: Expected Obj, but got VT
		//IL_01da: Expected native int or pointer, but got Obj
		//IL_01f7: Expected Obj, but got I4
		//IL_022f: Expected native int or pointer, but got Obj
		//IL_01a5: Expected native int or pointer, but got Obj
		//IL_01af: Expected Obj, but got VT
		//IL_01b4: Expected I4, but got Obj
		//IL_0159: Expected Obj, but got I4
		//IL_0163: Expected Obj, but got VT
		//IL_0203: Expected VT, but got Obj
		//IL_01fe: Expected native int or pointer, but got Obj
		//IL_0082: Expected native int or pointer, but got Obj
		//IL_008c: Expected I4, but got VT
		//IL_020f: Expected native int or pointer, but got Obj
		//IL_0223: Expected Obj, but got VT
		//IL_021e: Expected native int or pointer, but got Obj
		//IL_0327: Expected native int or pointer, but got Obj
		//IL_030a: Expected native int or pointer, but got Obj
		//IL_0113: Expected native int or pointer, but got Obj
		//IL_011d: Expected Ref, but got VT
		//IL_00d7: Expected native int or pointer, but got Obj
		//IL_00fc: Expected native int or pointer, but got Obj
		//IL_0181: Expected native int or pointer, but got Obj
		//IL_018b: Expected Obj, but got I4
		//IL_0195: Expected Obj, but got I4
		//IL_0190: Expected native int or pointer, but got Obj
		//IL_019e: Expected Obj, but got I4
		//IL_00a2: Expected native int or pointer, but got Obj
		//IL_00ac: Expected Obj, but got I4
		//IL_02a3: Expected Obj, but got I
		//IL_034b: Expected I4, but got Obj
		//IL_035a: Expected native int or pointer, but got Obj
		//IL_016d->IL002d: Incompatible stack heights: 3 vs 1
		//IL_022d->IL002d: Incompatible stack heights: 3 vs 1
		//IL_01a3->IL0029: Incompatible stack heights: 0 vs 1
		//IL_002d->IL002d: Incompatible stack heights: 2 vs 1
		//IL_0341->IL0346: Incompatible stack heights: 0 vs 2
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		((ILogger)/*Error near IL_001a: Stack underflow*/).Debug<_0021_00210>((string)/*Error near IL_001a: Stack underflow*/, (_0021_00210)this);
		int num = 3;
		object obj2 = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				return;
			case 9:
				((Authenticator)this).StartListening((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003Et__builder);
				((TcpListener)/*Error near IL_0091: Stack underflow*/).Start();
				Unsafe.Write(&Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton, /*Error near IL_0096: Stack underflow*/);
				num = 10;
				break;
			case 16:
				GC.SuppressFinalize(((Authenticator)this).ReceiveAuthenticationDataAsync((object)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)this)->_003C_003E1__state));
				Unsafe.Write(&((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)/*Error near IL_00b6: Stack underflow*/)->_003C_003E4__this, /*Error near IL_00b6: Stack underflow*/);
				num = 12;
				if (Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler != null)
				{
					num = 6;
				}
				break;
			case 14:
				((Authenticator._003CListenAsync_003Ed__7*)((Authenticator._003CReceiveAsync_003Ed__9*)(nint)this)->_003C_003E1__state)->SetStateMachine((IAsyncStateMachine)obj2);
				((TaskAwaiter*)this)->GetResult();
				((ILogger)/*Error near IL_00ed: Stack underflow*/).Error((Exception)/*Error near IL_00ed: Stack underflow*/, (string)/*Error near IL_00ed: Stack underflow*/);
				Unsafe.Write(&((Authenticator._003CReceiveAsync_003Ed__9*)(nint)/*Error near IL_00f2: Stack underflow*/)->_003C_003Eu__1, /*Error near IL_00f2: Stack underflow*/);
				num = 1;
				if (((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)Authenticator._003CReceiveAsync_003Ed__9.CheckCustomChain)->_003C_003E1__state != 0)
				{
					num = 0;
				}
				break;
			case 13:
				((Authenticator._003CReceiveAsync_003Ed__9*)((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)this)->_003C_003Et__builder)->MoveNext();
				Unsafe.Write(&((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)/*Error near IL_0127: Stack underflow*/)->_003Cstream_003E5__2, ((TcpListener)this).AcceptTcpClientAsync());
				num = 5;
				if (Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.ReflectMixedGateway != null)
				{
					num = 0;
				}
				break;
			case 7:
				_ = ((FeverInstaller)this)._003CfeverVersion_003EP;
				((FeverInstaller)obj2).Client__BackingField = ((Task<string>)(object)((TcpClient)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.DecorateFlexibleProfiler()).GetStream()).GetAwaiter();
				_ = 14;
				break;
			case 3:
				obj2 = ((TaskAwaiter<string>*)(uint)version)->GetResult();
				num = 8;
				break;
			case 15:
				Unsafe.Write(&((FeverInstaller._003CFeverRequest_003Ed__15<>*)(nint)this)->request, (object)((TaskAwaiter<string>*)((FeverInstaller)((FeverInstaller._003CFeverRequest_003Ed__15<>*)(nint)this)->_003C_003E1__state).InstallAsync())->IsCompleted);
				obj2 = 17;
				break;
			case 6:
				((RestClient)/*Error near IL_01b4: Stack underflow*/)._002Ector((RestClientOptions)/*Error near IL_01b4: Stack underflow*/, (ConfigureHeaders)/*Error near IL_01b4: Stack underflow*/, (ConfigureSerialization)/*Error near IL_01b4: Stack underflow*/, (byte)(int)((FeverInstaller)this).FeverRequest<T>((RestRequest)(object)((FeverInstaller._003CFeverRequest_003Ed__15<>*)(nint)this)->_003C_003Eu__1) != 0);
				Unsafe.Write(&((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14*)(nint)/*Error near IL_01b9: Stack underflow*/)->_003C_003E4__this, /*Error near IL_01b9: Stack underflow*/);
				num = 3;
				if (FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14.CheckBasicEncryptor != null)
				{
					num = 4;
				}
				break;
			case 2:
				Unsafe.Write(&((FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)((FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)(nint)this)->_003C_003E1__state)->info, (FeverInstaller._003CFeverRequest_003Ed__15<>.CheckAdaptableResponder() ? ((AsyncTaskMethodBuilder<EntityFeverManifestInfo>*)1) : ((AsyncTaskMethodBuilder<EntityFeverManifestInfo>*)null))->Task);
				obj2 = 13;
				break;
			case 8:
				Unsafe.Write(&((FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)(nint)this)->_003C_003Eu__1, (TaskAwaiter<RestResponse<EntityFeverManifest>>)mcPath);
				num = 2;
				break;
			case 10:
				_ = FeverInstaller._003CGetFeverManifestAsync_003Ed__12.ReflectReporter;
				Unsafe.Write(&((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13*)(nint)FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14.ReflectRemoteFinder())->_003C_003E4__this, (FeverInstaller)AsyncTaskMethodBuilder<_0021_00210>.Create());
				_ = 16;
				break;
			case 5:
				_ = ((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13*)(nint)this)->version;
				FeverInstaller._003CGetFeverManifestAsync_003Ed__12.ReceiveEnumerator();
				/*Error near IL_0239: Member reference must be method, but was: Field*/;
			default:
				((FeverInstaller._003CInstallAsync_003Ed__11*)this)->SetStateMachine((IAsyncStateMachine)((FeverInstaller._003CInstallAsync_003Ed__11*)(nint)this)->_003C_003Eu__1);
				/*Error near IL_026e: Member reference must be method, but was: Field*/;
			case 17:
				((Rpc)this).Writer__BackingField = (((Rpc)((Rpc)this).NeedCha__BackingField).NeedCha ? ((TaskAwaiter<RestResponse<EntityFeverResponse<_00210>>>*)1) : ((TaskAwaiter<RestResponse<EntityFeverResponse<_00210>>>*)null))->GetResult();
				num = 6;
				if (((Rpc)Rpc.Listener__BackingField)._chaChaEn == null)
				{
					num = 6;
				}
				break;
			case 1:
				((Rpc)this).SendMessage((BinaryWriter)((Rpc)this)._chaChaDe, (object[])obj2);
				((RestRequest)/*Error near IL_02e4: Stack underflow*/)._002Ector((string)/*Error near IL_02e4: Stack underflow*/, (Method)((TaskAwaiter<EntityFeverApp>*)/*Error near IL_02df: Stack underflow*/)->IsCompleted);
				Unsafe.Write(&((Rpc._003CListenAsync_003Ed__34*)(nint)/*Error near IL_02e9: Stack underflow*/)->_003C_003E4__this, /*Error near IL_02e9: Stack underflow*/);
				num = 6;
				if (Rpc._003CListenAsync_003Ed__34.DecorateIterableWriter == null)
				{
					num = 11;
				}
				break;
			case 12:
				((AsyncTaskMethodBuilder<EntityFeverAppVersion>*)((Rpc._003CListenControlConnectAsync_003Ed__35*)(nint)this)->_003C_003E1__state)->SetStateMachine((IAsyncStateMachine)obj2);
				Unsafe.Write(&((Rpc._003CListenControlConnectAsync_003Ed__35*)(nint)/*Error near IL_031b: Stack underflow*/)->listener, this);
				num = 7;
				break;
			case 11:
			{
				Rpc rpc = ((Rpc._003CListenControlConnectAsync_003Ed__35*)(nint)this)->_003C_003E4__this;
				object obj;
				if (version <= EnumGameVersion.V_1_20)
				{
					((Rpc)this).Listener = (TcpListener?)(object)rpc;
				}
				else
				{
					obj = rpc.ListenAsync();
				}
				Unsafe.Write(&((Rpc._003CReceiveAsync_003Ed__28*)(nint)/*Error near IL_0350: Stack underflow*/)->_003C_003Et__builder, (AsyncTaskMethodBuilder)RestResponseExtensions.EnsureSuccessStatusCode<T>((RestResponse<T>)/*Error near IL_034b: Stack underflow*/, (string?)(object)this, (byte)(int)obj != 0));
				num = 0;
				if (((Rpc._003CReceiveAsync_003Ed__28*)(nint)Rpc._003CReceiveAsync_003Ed__28.client)->_003C_003E4__this == null)
				{
					num = 0;
				}
				break;
			}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		return (string)_FF00Ⰰ();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ReflectAutomatedTracker()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static MinecraftPath CheckPassiveFinalizer()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_2B00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778373, new IntPtr(2737337539804L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00Ⰰ()
	{
		//IL_0015: Expected native int or pointer, but got Obj
		//IL_001b: Expected Obj, but got I4
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return ((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00ⴀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778372, new IntPtr(2737337563724L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_2E00()
	{
		//IL_001a: Expected Obj, but got I4
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_2F00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778371, new IntPtr(2737337563724L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00㴀()
	{
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
	}
}
