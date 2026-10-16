using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Mass.Game.Launcher.Entities.Fever;
using RestSharp;
using Serilog;

namespace Mass.Game.Launcher.Paths;

public class GamePath
{
	public readonly string Root;

	public readonly string Resources;

	public readonly string Data;

	public readonly string Files;

	public readonly string Cache;

	public readonly string Game;

	public readonly string GameAuthenticationDllSource;

	public readonly string PatchMcpSource;

	private static object CheckGeneralStrategy;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe GamePath()
	{
		//IL_001a: Expected VT, but got Obj
		//IL_003f: Expected Obj, but got I4
		//IL_0072: Expected I4, but got Obj
		//IL_0079: Expected native int or pointer, but got Obj
		//IL_01a0: Expected native int or pointer, but got Obj
		//IL_01b4: Expected Obj, but got VT
		//IL_00ee: Expected native int or pointer, but got Obj
		//IL_00f8: Expected Ref, but got VT
		//IL_010b: Expected Obj, but got I4
		//IL_0112: Expected native int or pointer, but got Obj
		//IL_011c: Expected Ref, but got VT
		//IL_00b3: Expected native int or pointer, but got Obj
		//IL_00bd: Expected Obj, but got I4
		//IL_00c7: Expected Obj, but got I4
		//IL_00d6: Expected native int or pointer, but got Obj
		//IL_0156: Expected I4, but got Obj
		//IL_0156: Expected I4, but got Obj
		//IL_015b: Expected VT, but got I4
		//IL_017a: Expected I4, but got Obj
		//IL_0189: Expected native int or pointer, but got Obj
		//IL_00a6->IL004d: Incompatible stack types: I4 vs Obj
		//IL_01be->IL004d: Incompatible stack types: I4 vs Obj
		//IL_013a->IL004d: Incompatible stack types: I4 vs Obj
		//IL_00e0->IL004d: Incompatible stack types: I4 vs Obj
		//IL_0165->IL004d: Incompatible stack types: I4 vs Obj
		//IL_0193->IL004d: Incompatible stack types: I4 vs Obj
		//IL_00b1->IL004d: Incompatible stack types: I4 vs Obj
		//IL_0145->IL004d: Incompatible stack types: I4 vs Obj
		//IL_00eb->IL004d: Incompatible stack types: I4 vs Obj
		//IL_019e->IL004d: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		((ILogger)/*Error near IL_001a: Stack underflow*/).Debug<_0021_00210>((string)/*Error near IL_001a: Stack underflow*/, (_0021_00210)this);
		if ((int)/*Error near IL_001a: Stack underflow*/ == 0)
		{
			((Func<Task>)/*Error near IL_0026: Stack underflow*/)._002Ector((object)/*Error near IL_0026: Stack underflow*/, (nint)/*Error near IL_0026: Stack underflow*/);
		}
		Unsafe.Write(&((Authenticator._003CListenAsync_003Ed__7*)(nint)/*Error near IL_002b: Stack underflow*/)->_003C_003E4__this, /*Error near IL_002b: Stack underflow*/);
		((TcpListener)this).Start();
		object obj = 7;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				default:
					GC.SuppressFinalize(((Authenticator)/*Error near IL_0088: Stack underflow*/).ReceiveAuthenticationDataAsync(((Authenticator)this).ReceiveAsync(Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton)));
					Unsafe.Write(&((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)/*Error near IL_0092: Stack underflow*/)->_003C_003E4__this, /*Error near IL_0092: Stack underflow*/);
					obj2 = 2;
					if (Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler == null)
					{
						obj2 = 3;
					}
					continue;
				case 4:
					((Authenticator._003CListenAsync_003Ed__7*)this)->SetStateMachine((IAsyncStateMachine)((Authenticator._003CReceiveAsync_003Ed__9*)(nint)this)->_003C_003E1__state);
					((ILogger)/*Error near IL_00c7: Stack underflow*/).Error((Exception)/*Error near IL_00c7: Stack underflow*/, (string)Authenticator._003CListenAsync_003Ed__7.DecorateExpandableParser());
					Unsafe.Write(&((Authenticator._003CReceiveAsync_003Ed__9*)(nint)/*Error near IL_00cc: Stack underflow*/)->_003C_003Eu__1, /*Error near IL_00cc: Stack underflow*/);
					obj2 = 0;
					if (((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)Authenticator._003CReceiveAsync_003Ed__9.CheckCustomChain)->_003C_003E1__state == 0)
					{
						obj2 = 0;
					}
					continue;
				case 5:
					return;
				case 2:
					break;
				case 3:
					((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)this)->_003C_003Eu__1)->MoveNext();
					((FeverInstaller)/*Error near IL_0126: Stack underflow*/)._003CappId_003EP = ((Encoding)/*Error near IL_0121: Stack underflow*/).GetBytes((string)(object)this);
					obj2 = 1;
					if (FeverInstaller.McBedrock__BackingField != null)
					{
						obj2 = 0;
					}
					continue;
				case 6:
					Unsafe.Write(&((FeverInstaller._003CFeverRequest_003Ed__15<>*)(nint)/*Error near IL_015b: Stack underflow*/)->_003C_003Et__builder, (AsyncTaskMethodBuilder<T>)((Stream)/*Error near IL_0156: Stack underflow*/).Read((byte[])/*Error near IL_0156: Stack underflow*/, (int)this, (int)((FeverInstaller)((FeverInstaller)this).Client__BackingField).Client));
					obj2 = 2;
					continue;
				case 7:
					((RestClientOptions)((TaskAwaiter<string>*)this)->IsCompleted)._002Ector();
					((RestClientOptions)/*Error near IL_017a: Stack underflow*/).AutomaticDecompression = (DecompressionMethods)((FeverInstaller)/*Error near IL_0175: Stack underflow*/).GetFeverAppVersionAsync();
					Unsafe.Write(&((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14*)(nint)/*Error near IL_017f: Stack underflow*/)->_003C_003Et__builder, /*Error near IL_017f: Stack underflow*/);
					obj2 = 0;
					if ((int)((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14*)(nint)FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14._003C_003E4__this)->_003C_003Eu__1 != 0)
					{
						obj2 = 4;
					}
					continue;
				case 1:
					((FeverInstaller._003CFeverRequest_003Ed__15<>*)this)->SetStateMachine((IAsyncStateMachine)FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14.CheckBasicEncryptor);
					Unsafe.Write(&((FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)(nint)/*Error near IL_01b4: Stack underflow*/)->_003C_003E4__this, (FeverInstaller)AsyncTaskMethodBuilder<EntityFeverManifestInfo>.Create());
					obj2 = 6;
					continue;
				}
				break;
			}
			((Authenticator._003CReceiveAsync_003Ed__9*)((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)this)->_003C_003Et__builder)->MoveNext();
			Unsafe.Write(&((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)/*Error near IL_0102: Stack underflow*/)->_003Cstream_003E5__2, ((TcpListener)this).AcceptTcpClientAsync());
			obj = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ReflectExtendedSorter()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static GamePath CheckWrapper()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00㸀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778380, new IntPtr(2737337563724L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00㼀()
	{
		//IL_001a: Expected Obj, but got I4
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00䀀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778379, new IntPtr(2737337563724L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00䐀()
	{
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
	}
}
