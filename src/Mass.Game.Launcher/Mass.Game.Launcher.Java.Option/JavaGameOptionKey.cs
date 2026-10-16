using System;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using Mass.Domain.Desktop.ValueObjects;

namespace Mass.Game.Launcher.Java.Option;

public class JavaGameOptionKey
{
	public readonly string ResourcePacks;

	public readonly string Language;

	public readonly string WindowWidth;

	public readonly string WindowHeight;

	public readonly string GuiScale;

	public readonly string AutoJump;

	public readonly string Narrator;

	public readonly string OnboardAccessibility;

	internal static JavaGameOptionKey ReflectSymbolicWriter;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe JavaGameOptionKey(EnumGameVersion version)
	{
		//IL_001f: Expected VT, but got Obj
		//IL_002a: Expected I4, but got Obj
		//IL_003f: Expected I4, but got Obj
		//IL_005f: Expected VT, but got Obj
		//IL_006f: Expected I4, but got Obj
		//IL_006a: Expected native int or pointer, but got Obj
		//IL_008f: Expected VT, but got Obj
		//IL_008a: Expected native int or pointer, but got Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		Unsafe.Write(&((Authenticator._003CListenAsync_003Ed__7*)(nint)/*Error near IL_001f: Stack underflow*/)->_003C_003Et__builder, (AsyncTaskMethodBuilder)((Authenticator)this).Listener);
		((Authenticator)/*Error near IL_002a: Stack underflow*/).StartListening((int)this);
		Unsafe.Write(&((Authenticator._003CListenAsync_003Ed__7*)(nint)/*Error near IL_002f: Stack underflow*/)->_003C_003Eu__1, /*Error near IL_002f: Stack underflow*/);
		((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)/*Error near IL_003f: Stack underflow*/)->_003C_003E1__state = (int)((Authenticator)/*Error near IL_003a: Stack underflow*/).ListenAuthenticationConnectAsync((object)this);
		Unsafe.Write(&((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)/*Error near IL_004f: Stack underflow*/)->listener, ((Authenticator)/*Error near IL_004a: Stack underflow*/).ReceiveAuthenticationDataAsync((object)this));
		Unsafe.Write(&((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)/*Error near IL_005f: Stack underflow*/)->_003C_003Eu__1, (TaskAwaiter<TcpClient>)((Authenticator)/*Error near IL_005a: Stack underflow*/).HandleAuthentication((string)(object)this));
		((Authenticator._003CReceiveAsync_003Ed__9*)(nint)this)->_003C_003E1__state = (int)Authenticator.PatchUser();
		((Authenticator._003CListenAsync_003Ed__7*)/*Error near IL_007a: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)this);
		Unsafe.Write(&((Authenticator._003CReceiveAsync_003Ed__9*)(nint)/*Error near IL_007f: Stack underflow*/)->_003C_003E4__this, /*Error near IL_007f: Stack underflow*/);
		Unsafe.Write(&((Authenticator._003CReceiveAsync_003Ed__9*)(nint)this)->_003C_003Eu__1, (TaskAwaiter)Authenticator._003CListenAsync_003Ed__7.ObserveTracker());
		((AsyncTaskMethodBuilder*)this)->SetResult();
		int num = 0;
		if ((int)((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003C_003E1__state)->_003C_003Et__builder == 0)
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
	internal static bool DecorateConfigurableDic()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static JavaGameOptionKey ReflectSeparatedObject()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00漀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779293, new IntPtr(2737367907804L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00瀀()
	{
		//IL_001a: Expected Obj, but got I4
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00礀()
	{
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00稀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779292, new IntPtr(2737367895324L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}
}
