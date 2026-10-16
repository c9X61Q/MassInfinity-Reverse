using System;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Serilog;

namespace Mass.Game.Launcher.Java.LanGame;

public sealed class WebRtcCompressor
{
	private readonly object _deflater;

	private readonly object _inflater;

	private readonly object _decompressBuffer;

	private readonly object _compressBuffer;

	internal static WebRtcCompressor EncryptInterpreter;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe byte[] Decompress(byte[] data)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 840, 1790777454, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790777454, new IntPtr(2737367918204L), 15);
		}
		return (byte[])((delegate*<object, object, object>)obj)(this, data);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe byte[] Compress(byte[] data)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 841, 1790777453, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790777453, new IntPtr(2737367885964L), 15);
		}
		return (byte[])((delegate*<object, object, object>)obj)(this, data);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Reset()
	{
		_FF00_FF00_FF00_FF00_FF00ⴀ();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe WebRtcCompressor()
	{
		//IL_001b: Expected VT, but got I4
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected VT, but got Unknown
		//IL_0030: Expected VT, but got Obj
		//IL_0045: Expected I4, but got Obj
		//IL_0040: Expected native int or pointer, but got Obj
		//IL_0055: Expected native int or pointer, but got Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		Unsafe.Write(&((Authenticator._003CListenAsync_003Ed__7*)(nint)/*Error near IL_0020: Stack underflow*/)->_003C_003Et__builder, (AsyncTaskMethodBuilder)new ILogger((string)(object)this, (_0021_00210)(-1)));
		Unsafe.Write(&((Authenticator._003CListenAsync_003Ed__7*)(nint)/*Error near IL_0030: Stack underflow*/)->_003C_003Eu__1, (TaskAwaiter)new Task((Func<Task?>)(object)this));
		((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)this)->_003C_003E1__state = (int)new ILogger[1024];
		Unsafe.Write(&((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)this)->listener, new int[1024]);
		((TcpListener)this).Dispose();
		int num = 0;
		if (Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler == null)
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
	internal static bool ScanNode()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static WebRtcCompressor InitFunction()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_2800(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777452, new IntPtr(2737367897404L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_2900(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_003a: Expected native int or pointer, but got Obj
		//IL_0045: Expected I, but got Obj
		//IL_0045: Expected Obj, but got I4
		//IL_004f: Expected native int or pointer, but got Obj
		//IL_0083: Expected native int or pointer, but got Obj
		//IL_00bf: Expected native int or pointer, but got Obj
		//IL_00c5: Expected native int or pointer, but got Obj
		//IL_00d1: Expected Obj, but got VT
		//IL_00da: Expected Obj, but got I4
		//IL_0100: Expected I4, but got Obj
		//IL_010c: Expected Ref, but got VT
		//IL_0118: Expected native int or pointer, but got Obj
		//IL_018b: Expected native int or pointer, but got Obj
		//IL_0144: Expected native int or pointer, but got Obj
		//IL_014a: Expected native int or pointer, but got Obj
		//IL_0154: Expected Obj, but got VT
		//IL_0156: Expected Obj, but got VT
		//IL_013e: Expected Obj, but got I4
		//IL_00a1->IL0068: Incompatible stack heights: 2 vs 1
		//IL_00ac->IL0068: Incompatible stack heights: 2 vs 1
		//IL_0122->IL00e3: Incompatible stack heights: 1 vs 2
		//IL_01a2->IL00e3: Incompatible stack heights: 6 vs 2
		//IL_016a->IL00e3: Incompatible stack heights: 1 vs 2
		//IL_012d->IL00e3: Incompatible stack heights: 1 vs 2
		//IL_0175->IL00e3: Incompatible stack heights: 1 vs 2
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		switch ((int)obj)
		{
		case 1:
		{
			((Func<Task>)/*Error near IL_0045: Stack underflow*/)._002Ector((object)((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state, (nint)P_0);
			int num = 0;
			if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 == 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				default:
					_ = ((AsyncTaskMethodBuilder*)Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton)->Task;
					_ = 1;
					if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003Et__builder).listener == null)
					{
						_ = 0;
					}
					continue;
				case 1:
					obj = new TcpListener();
					num = 2;
					continue;
				case 2:
				{
					TaskAwaiter<TcpClient> taskAwaiter = ((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)this)->_003C_003Eu__1;
					obj = ((Task)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler).GetAwaiter();
					obj = 4;
					while (true)
					{
						object obj2 = obj;
						while (true)
						{
							switch ((int)obj2)
							{
							case 2:
								((AsyncTaskMethodBuilder*)/*Error near IL_010c: Stack underflow*/)->AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref *(TAwaiter*)taskAwaiter, ref *(TStateMachine*)obj);
								obj = (object)/*Error near IL_010e: Stack underflow*/;
								_ = 0;
								if (((Authenticator._003CReceiveAsync_003Ed__9*)(nint)Authenticator._003CReceiveAsync_003Ed__9._003C_003E4__this)->client == null)
								{
									_ = 0;
								}
								continue;
							case 1:
							case 4:
								if ((nint)obj <= 0)
								{
									goto end_IL_00e3;
								}
								goto case 3;
							case 5:
								((IAsyncStateMachine)((Authenticator._003CReceiveAsync_003Ed__9*)(nint)this)->_003C_003Eu__1).SetStateMachine((IAsyncStateMachine)Authenticator._003CReceiveAsync_003Ed__9.CheckCustomChain);
								obj = taskAwaiter;
								_ = 0;
								if (((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003C_003Et__builder).client == null)
								{
									_ = 1;
								}
								continue;
							case 3:
								_ = ((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)this)->_003C_003E4__this;
								_ = 0;
								((Task<TcpClient>)obj).GetAwaiter();
								_ = 5;
								continue;
							}
							goto end_IL_0068;
							continue;
							end_IL_00e3:
							break;
						}
						obj = 2;
					}
				}
				case 3:
					break;
					end_IL_0068:
					break;
				}
				break;
			}
			break;
		}
		}
		return obj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_2A00(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777451, new IntPtr(2737367919244L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_2B00()
	{
		//IL_001a: Expected Obj, but got I4
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00Ⰰ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777450, new IntPtr(2737367921324L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00ⴀ()
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_0067: Expected native int or pointer, but got Obj
		//IL_003d: Expected native int or pointer, but got Obj
		//IL_0051: Expected native int or pointer, but got Obj
		//IL_0085->IL0026: Incompatible stack heights: 2 vs 1
		//IL_005b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0090->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0066->IL0026: Incompatible stack types: I4 vs Obj
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
			case 1:
				((Func<Task>)/*Error near IL_0047: Stack underflow*/)._002Ector((object)/*Error near IL_0047: Stack underflow*/, (nint)((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state);
				obj2 = 0;
				if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 == 0)
				{
					obj2 = 0;
				}
				break;
			default:
				_ = ((AsyncTaskMethodBuilder*)Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton)->Task;
				_ = 1;
				if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003Et__builder).listener != null)
				{
					_ = 2;
				}
				break;
			case 2:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_2E00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777449, new IntPtr(2737367919244L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_3000(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777448, new IntPtr(2737367919244L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_3100(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_003a: Expected native int or pointer, but got Obj
		//IL_0045: Expected I, but got Obj
		//IL_0045: Expected Obj, but got I4
		//IL_004f: Expected native int or pointer, but got Obj
		//IL_00a6: Expected native int or pointer, but got Obj
		//IL_00ac: Expected native int or pointer, but got Obj
		//IL_00c2: Expected native int or pointer, but got Obj
		//IL_0085: Expected Obj, but got VT
		//IL_0113: Expected native int or pointer, but got Obj
		//IL_0189: Expected native int or pointer, but got Obj
		//IL_018f: Expected native int or pointer, but got Obj
		//IL_019b: Expected Obj, but got VT
		//IL_012a->IL00db: Incompatible stack heights: 4 vs 1
		//IL_01af->IL00db: Incompatible stack heights: 2 vs 1
		//IL_01ba->IL00db: Incompatible stack heights: 2 vs 1
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		switch ((int)obj)
		{
		case 1:
		{
			((Func<Task>)/*Error near IL_0045: Stack underflow*/)._002Ector((object)((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state, (nint)P_0);
			int num = 1;
			if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 == 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					obj = new AsyncTaskMethodBuilder(ref *(TStateMachine*)/*Error near IL_0083: Stack underflow*/);
					num = 0;
					if ((int)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003E1__state)->_003C_003Et__builder != 0)
					{
						num = 0;
					}
					continue;
				default:
				{
					TcpListener tcpListener = ((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)this)->listener;
					((IAsyncStateMachine)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)this)->_003C_003E4__this).MoveNext();
					obj = tcpListener;
					int num2 = 3;
					if (((Authenticator._003CReceiveAsync_003Ed__9*)(nint)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler)->_003C_003E1__state == 0)
					{
						num2 = 1;
					}
					while (true)
					{
						switch (num2)
						{
						case 1:
						case 6:
							_ = ((Authenticator._003CReceiveAsync_003Ed__9*)(nint)this)->_003C_003Et__builder;
							_ = 0;
							((TaskAwaiter*)obj)->GetResult();
							_ = 5;
							continue;
						case 4:
							((ILogger)/*Error near IL_0131: Stack underflow*/).Error((Exception)/*Error near IL_0131: Stack underflow*/, (string)obj);
							obj = (object)/*Error near IL_0133: Stack underflow*/;
							num2 = 2;
							continue;
						default:
							if ((nint)obj > 0)
							{
								num2 = 6;
								if ((int)((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003C_003E1__state)->_003C_003Et__builder != 0)
								{
									num2 = 2;
								}
								continue;
							}
							goto case 4;
						case 5:
							_ = ((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)this)->client;
							obj = ((Task<TcpClient>)(object)((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)this)->_003C_003E4__this).GetAwaiter();
							_ = 0;
							if (Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.ReflectMixedGateway == null)
							{
								_ = 0;
							}
							continue;
						case 2:
							break;
						}
						break;
					}
					break;
				}
				case 2:
					break;
				}
				break;
			}
			break;
		}
		}
		return obj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_3200(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777447, new IntPtr(2737367897404L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_3300()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777446, new IntPtr(2737367919244L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00㐀()
	{
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
	}
}
