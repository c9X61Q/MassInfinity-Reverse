using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using Mass.Game.Launcher.Cpp;
using Mass.Game.Launcher.Entities.Fever;
using RestSharp;

namespace Mass.Game.Launcher.Paths;

public class CppGamePath : GamePath
{
	public readonly string BedrockLauncherFile;

	public readonly string BedrockLauncher;

	public readonly string BedrockHash;

	public readonly string Bedrock;

	public readonly string GameZip;

	public readonly string BePackCache;

	public readonly string BeMain;

	public readonly string AppData;

	public readonly string GameRuntime;

	public readonly string ConfigFile;

	public readonly string ErrorLog;

	private static object CheckDetachedBridge;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe CppGamePath(EntityLaunchCppGame args)
	{
		//IL_0023: Expected Obj, but got I4
		//IL_0066: Expected I4, but got Obj
		//IL_0118: Expected native int or pointer, but got Obj
		//IL_00d8: Expected native int or pointer, but got Obj
		//IL_00e7: Expected native int or pointer, but got Obj
		//IL_0173: Expected I4, but got Obj
		//IL_0173: Expected I4, but got Obj
		//IL_0182: Expected native int or pointer, but got Obj
		//IL_01d9: Expected native int or pointer, but got Obj
		//IL_01ed: Expected I4, but got Obj
		//IL_013e: Expected I4, but got Obj
		//IL_020e: Expected native int or pointer, but got Obj
		//IL_0229: Expected native int or pointer, but got Obj
		//IL_00a2: Expected native int or pointer, but got Obj
		//IL_0199: Expected native int or pointer, but got Obj
		//IL_01ad: Expected VT, but got Obj
		//IL_01a8: Expected native int or pointer, but got Obj
		//IL_01b9: Expected native int or pointer, but got Obj
		//IL_01cd: Expected Obj, but got VT
		//IL_01c8: Expected native int or pointer, but got Obj
		//IL_006d: Expected native int or pointer, but got Obj
		//IL_0077: Expected I4, but got VT
		//IL_00f8: Expected native int or pointer, but got Obj
		//IL_010c: Expected Obj, but got I4
		//IL_0136->IL0031: Incompatible stack heights: 4 vs 2
		//IL_00f6->IL0031: Incompatible stack heights: 1 vs 2
		//IL_018c->IL0031: Incompatible stack heights: 1 vs 2
		//IL_0201->IL0031: Incompatible stack heights: 1 vs 2
		//IL_0157->IL0031: Incompatible stack heights: 1 vs 2
		//IL_0242->IL0031: Incompatible stack types: I4 vs Obj
		//IL_00ca->IL0031: Incompatible stack heights: 1 vs 2
		//IL_01b7->IL0031: Incompatible stack heights: 1 vs 2
		//IL_01d7->IL0031: Incompatible stack heights: 1 vs 2
		//IL_0095->IL0031: Incompatible stack heights: 1 vs 2
		//IL_0116->IL0031: Incompatible stack heights: 3 vs 2
		//IL_0197->IL0031: Incompatible stack heights: 1 vs 2
		//IL_020c->IL0031: Incompatible stack heights: 1 vs 2
		//IL_0162->IL0031: Incompatible stack heights: 1 vs 2
		//IL_024d->IL0031: Incompatible stack types: I4 vs Obj
		//IL_00d5->IL0031: Incompatible stack heights: 1 vs 2
		//IL_00a0->IL0031: Incompatible stack heights: 1 vs 2
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		TcpListener? listener = ((Authenticator)(object)this).Listener;
		object obj = 5;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 10:
				((Authenticator)(object)this).StartListening((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003Et__builder);
				listener.Start();
				Unsafe.Write(&Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton, /*Error near IL_0081: Stack underflow*/);
				_ = 1;
				if ((int)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003E1__state)->_003C_003Et__builder != 0)
				{
					_ = 0;
				}
				break;
			case 7:
				((IAsyncStateMachine)((Authenticator)(object)this).HandleAuthentication((string)(object)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)this)->listener)).MoveNext();
				Unsafe.Write(&Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler, listener);
				_ = 4;
				if ((int)((Authenticator._003CReceiveAsync_003Ed__9*)Authenticator._003CReceiveAsync_003Ed__9._003C_003E1__state)->_003C_003Et__builder == 0)
				{
					_ = 11;
				}
				break;
			case 4:
				return;
			case 1:
				((AsyncTaskMethodBuilder*)((Authenticator._003CReceiveAsync_003Ed__9*)(nint)this)->_003C_003E4__this)->SetException((Exception)Authenticator._003CListenAsync_003Ed__7.ObserveTracker());
				Unsafe.Write(&Authenticator._003CReceiveAsync_003Ed__9.CheckCustomChain, this);
				_ = 2;
				break;
			case 11:
				Unsafe.Write(&((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)this)->_003C_003E1__state)->_003C_003E4__this, (Authenticator)((TaskAwaiter<TcpClient>*)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.ReflectRandomReporter())->IsCompleted);
				_ = 4;
				break;
			default:
				_ = ((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)this)->_003Cstream_003E5__2;
				((FeverInstaller)Authenticator._003CReceiveAsync_003Ed__9.DecorateConvertibleParameter())._003CfeverVersion_003EP = Encoding.UTF8;
				_ = 10;
				break;
			case 5:
				((FeverInstaller)/*Error near IL_0143: Stack underflow*/)._003CappVersion_003EP = ((Encoding)/*Error near IL_013e: Stack underflow*/).GetString((byte[])(object)listener, (int)this, 26);
				_ = 0;
				if (((FeverInstaller)FeverInstaller.McBedrock__BackingField).Client__BackingField == null)
				{
					_ = 0;
				}
				break;
			case 2:
				((FeverInstaller)FeverInstaller.ReflectVisualArgument).Dispose();
				((Stream)/*Error near IL_0173: Stack underflow*/).Write((byte[])/*Error near IL_0173: Stack underflow*/, (int)listener, (int)this);
				Unsafe.Write(&((FeverInstaller._003CFeverRequest_003Ed__15<>*)(nint)/*Error near IL_0178: Stack underflow*/)->_003C_003E4__this, /*Error near IL_0178: Stack underflow*/);
				_ = 2;
				if ((int)((FeverInstaller._003CFeverRequest_003Ed__15<>*)(nint)FeverInstaller._003CFeverRequest_003Ed__15<>.request)->_003C_003Eu__1 == 0)
				{
					_ = 3;
				}
				break;
			case 8:
			{
				int num = ((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14*)(nint)this)->_003C_003E1__state;
				FeverInstaller._002Ecctor();
				((RestClient)num).Dispose();
				Unsafe.Write(&((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14*)(nint)listener)->_003C_003Eu__1, (TaskAwaiter<EntityFeverApp>)this);
				_ = 9;
				break;
			}
			case 9:
				((FeverInstaller._003CFeverRequest_003Ed__15<>*)this)->SetStateMachine((IAsyncStateMachine)FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14.CheckBasicEncryptor);
				Unsafe.Write(&((FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)(nint)listener)->_003C_003E4__this, (FeverInstaller)AsyncTaskMethodBuilder<EntityFeverManifestInfo>.Create());
				_ = 6;
				break;
			case 3:
				((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14*)this)->SetStateMachine((IAsyncStateMachine)((FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)(nint)this)->info);
				((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13*)(nint)/*Error near IL_01ed: Stack underflow*/)->_003C_003E1__state = (int)((AsyncTaskMethodBuilder<EntityFeverAppVersion>*)listener)->Task;
				_ = 8;
				if (((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13)FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13._003C_003Et__builder)._003C_003E4__this != null)
				{
					_ = 6;
				}
				break;
			case 6:
			{
				EntityFeverAppVersion entityFeverAppVersion = ((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13*)(nint)this)->version;
				object obj3 = FeverInstaller._003CGetFeverManifestAsync_003Ed__12.ReceiveEnumerator();
				((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13*)args)->MoveNext();
				((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13*)obj3)->SetStateMachine((IAsyncStateMachine)args);
				Unsafe.Write(&((FeverInstaller._003CInstallAsync_003Ed__11*)(nint)this)->_003C_003E4__this, ((AsyncTaskMethodBuilder<_0021_00210>*)entityFeverAppVersion)->Task);
				obj2 = 7;
				if ((int)((FeverInstaller._003CInstallAsync_003Ed__11)FeverInstaller._003CInstallAsync_003Ed__11._003C_003Eu__1)._003C_003Eu__2 == 0)
				{
					obj2 = 5;
				}
				break;
			}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ReflectDetailedCommand()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CppGamePath DecorateDividedConsumer()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00簀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778382, new IntPtr(2737337563724L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00紀()
	{
		//IL_001a: Expected Obj, but got I4
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00蜀()
	{
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00蠀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778381, new IntPtr(2737337545004L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}
}
