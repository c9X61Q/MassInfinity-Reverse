using System;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using Mass.Domain.Desktop.ValueObjects;

namespace Mass.Game.Launcher.Java;

public class JavaLog
{
	public readonly string Disconnect;

	internal static JavaLog DecorateActiveEncryptor;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe JavaLog(EnumGameVersion version)
	{
		//IL_00c8: Expected VT, but got Obj
		//IL_00c3: Expected native int or pointer, but got Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj;
		switch (version)
		{
		case EnumGameVersion.V_1_7_10:
		case EnumGameVersion.V_1_8_9:
		case EnumGameVersion.V_1_12_2:
			obj = ((Authenticator)/*Error near IL_008d: Stack underflow*/).Listener;
			break;
		case EnumGameVersion.V_1_18:
		case EnumGameVersion.V_1_20:
			((Authenticator)/*Error near IL_00a3: Stack underflow*/).Listener = (TcpListener?)/*Error near IL_00a3: Stack underflow*/;
			obj = (object)/*Error near IL_00a5: Stack underflow*/;
			break;
		default:
			((Authenticator)/*Error near IL_00b9: Stack underflow*/).StartListening((int)/*Error near IL_00b9: Stack underflow*/);
			obj = (object)/*Error near IL_00bb: Stack underflow*/;
			break;
		}
		Unsafe.Write(&((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003Eu__1, (TaskAwaiter)obj);
		((AsyncTaskMethodBuilder*)/*Error near IL_00d3: Stack underflow*/)->Start<TStateMachine>(ref *(TStateMachine*)this);
		int num = 0;
		if ((int)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003E1__state)->_003C_003Et__builder != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SearchStruct()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static JavaLog DecorateLiteralFinder()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00紀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779108, new IntPtr(2737337592844L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00縀()
	{
		//IL_001a: Expected Obj, but got I4
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00舀()
	{
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00茀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779107, new IntPtr(2737337581404L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}
}
