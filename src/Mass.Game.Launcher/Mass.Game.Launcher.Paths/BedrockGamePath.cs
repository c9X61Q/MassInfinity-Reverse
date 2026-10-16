using System;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Mass.Game.Launcher.Paths;

public class BedrockGamePath : GamePath
{
	public readonly string NeteaseData;

	public readonly string Launcher;

	internal static BedrockGamePath StartTemplate;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe BedrockGamePath(string install, string startup)
	{
		//IL_0020: Expected I, but got Obj
		//IL_0032: Expected native int or pointer, but got Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		((Func<Task>)/*Error near IL_0020: Stack underflow*/)._002Ector((object)this, (nint)((Authenticator)(object)install).Listener);
		Unsafe.Write(&((Authenticator._003CListenAsync_003Ed__7*)(nint)/*Error near IL_0025: Stack underflow*/)->_003C_003E4__this, /*Error near IL_0025: Stack underflow*/);
		((TcpListener)(object)startup).Start();
		Unsafe.Write(&Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton, install);
		((Authenticator)/*Error near IL_0042: Stack underflow*/).ReceiveAsync((object)this);
		int num = 0;
		if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003Et__builder).listener == null)
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
	public unsafe static BedrockGamePath? GetBedrockPath()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0057: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 146, 1790778391, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778391, new IntPtr(2737337551244L), 15);
		}
		return (BedrockGamePath?)((delegate*<object>)obj)();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DecorateSequentialContainer()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static BedrockGamePath DecorateSetConverter()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00栀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778390, new IntPtr(2737337563724L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00椀()
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_02d7: Expected Obj, but got I4
		//IL_02e1: Expected native int or pointer, but got Obj
		//IL_018f: Expected Obj, but got I4
		//IL_023e: Expected Obj, but got I4
		//IL_00a4: Expected I4, but got Obj
		//IL_0233: Expected Ref, but got VT
		//IL_02eb->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0058->IL0067: Incompatible stack types: I4 vs Obj
		//IL_02f6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01e4->IL0067: Incompatible stack types: I4 vs Obj
		//IL_0063->IL0067: Incompatible stack types: I4 vs Obj
		//IL_01ef->IL0067: Incompatible stack types: I4 vs Obj
		//IL_01fa->IL01fa: Incompatible stack types: I4 vs Obj
		//IL_0128->IL0067: Incompatible stack types: I4 vs Obj
		//IL_0152->IL0067: Incompatible stack heights: 2 vs 1
		//IL_0206->IL0067: Incompatible stack types: I4 vs Obj
		//IL_00de->IL0067: Incompatible stack types: I4 vs Obj
		//IL_0178->IL0067: Incompatible stack types: I4 vs Obj
		//IL_0228->IL0067: Incompatible stack types: I4 vs Obj
		//IL_0133->IL0067: Incompatible stack types: I4 vs Obj
		//IL_015d->IL0067: Incompatible stack heights: 2 vs 1
		//IL_0183->IL0067: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			object obj3;
			object obj5;
			switch ((int)obj2)
			{
			default:
				if (obj == null)
				{
					obj3 = 3;
					if ((int)((Authenticator._003CListenAsync_003Ed__7*)Authenticator._003CListenAsync_003Ed__7._003C_003E1__state)->_003C_003Et__builder == 0)
					{
						obj3 = 0;
					}
					goto IL_0067;
				}
				goto IL_01b8;
			case 1:
				obj = ((TaskAwaiter<string>*)((FeverInstaller)/*Error near IL_02d0: Stack underflow*/).InstallAsync())->IsCompleted;
				obj2 = 0;
				if ((int)((FeverInstaller._003CFeverRequest_003Ed__15<>*)(nint)FeverInstaller._003CFeverRequest_003Ed__15<>.request)->_003C_003Eu__1 == 0)
				{
					obj2 = 0;
				}
				continue;
			case 2:
				break;
				IL_0067:
				while (true)
				{
					object obj4;
					switch ((int)obj3)
					{
					case 4:
						if (obj == null)
						{
							obj3 = 11;
							continue;
						}
						goto case 8;
					case 11:
					case 12:
						obj = null;
						obj3 = 2;
						if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003Et__builder).listener != null)
						{
							obj3 = 7;
						}
						continue;
					default:
						obj = new Authenticator((string)obj);
						_ = 1;
						if (Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler == null)
						{
							_ = 0;
						}
						continue;
					case 8:
						if (obj != null)
						{
							obj3 = 0;
							if ((int)((Authenticator._003CReceiveAsync_003Ed__9*)Authenticator._003CReceiveAsync_003Ed__9._003C_003E1__state)->_003C_003Et__builder == 0)
							{
								obj3 = 0;
							}
							continue;
						}
						goto case 11;
					case 3:
						obj = null;
						obj = 6;
						goto IL_0063;
					case 5:
						break;
					case 10:
						goto IL_01ef;
					case 9:
					{
						((Authenticator._003CReceiveAsync_003Ed__9*)/*Error near IL_020d: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)obj);
						TaskAwaiter<TcpClient> awaiter = ((Task<TcpClient>)/*Error near IL_0212: Stack underflow*/).GetAwaiter();
						if ((int)awaiter == 0)
						{
							obj3 = 2;
							continue;
						}
						obj4 = ((TaskAwaiter<TcpClient>*)awaiter)->GetResult();
						goto IL_0233;
					}
					case 2:
						obj4 = null;
						goto IL_0233;
					case 1:
					case 6:
					case 7:
						goto end_IL_0026;
						IL_0233:
						obj = obj4;
						obj = 4;
						goto IL_0063;
						IL_0063:
						obj3 = obj;
						continue;
					}
					break;
				}
				goto IL_01b8;
				IL_01ef:
				obj5 = null;
				goto IL_01fa;
				IL_01fa:
				obj = obj5;
				obj3 = 9;
				goto IL_0067;
				IL_01b8:
				((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)obj)->MoveNext();
				((AsyncTaskMethodBuilder*)/*Error near IL_01c4: Stack underflow*/)->SetResult();
				if ((int)/*Error near IL_01c4: Stack underflow*/ == 0)
				{
					obj3 = 2;
					if ((int)((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003C_003E1__state)->_003C_003Et__builder != 0)
					{
						obj3 = 10;
					}
					goto IL_0067;
				}
				obj5 = ((TaskAwaiter<TcpClient>*)/*Error near IL_01fa: Stack underflow*/)->IsCompleted;
				goto IL_01fa;
				end_IL_0026:
				break;
			}
			break;
		}
		return obj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00樀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778389, new IntPtr(2737337563724L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00欀()
	{
		//IL_001a: Expected Obj, but got I4
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00氀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778388, new IntPtr(2737337565804L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00渀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778387, new IntPtr(2737337563724L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00漀()
	{
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00瀀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778386, new IntPtr(2737337535644L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}
}
