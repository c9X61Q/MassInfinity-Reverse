using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Serilog;

namespace Mass.Game.Launcher.Models;

public record RpcCallBack
{
	[CompilerGenerated]
	protected virtual Type EqualityContract
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (Type)_FF00Ā();
		}
	}

	public Rpc Rpc
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (Rpc)_FF00ἀ();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		init
		{
			_FF00ᰀ(value);
		}
	}

	public BinaryWriter Writer
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (BinaryWriter)_FF00ᴀ();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		init
		{
			_FF00_2100(value);
		}
	}

	public ushort Sid
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00ᤀ();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		init
		{
			_FF00_0E00(value);
		}
	}

	public byte[] Data
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (byte[])_FF00_0900();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		init
		{
			_FF00_0B00(value);
		}
	}

	internal static RpcCallBack ReflectIdentifiableTransmitter;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe RpcCallBack(Rpc Rpc, BinaryWriter Writer, ushort Sid, byte[] Data)
	{
		//IL_001b: Expected I4, but got Obj
		//IL_0016: Expected native int or pointer, but got Obj
		//IL_0027: Expected VT, but got Obj
		//IL_0022: Expected native int or pointer, but got Obj
		//IL_0033: Expected Obj, but got I4
		//IL_002e: Expected native int or pointer, but got Obj
		//IL_0040: Expected VT, but got Obj
		//IL_003b: Expected native int or pointer, but got Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state = (int)Rpc;
		Unsafe.Write(&((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003Et__builder, (AsyncTaskMethodBuilder)Writer);
		Unsafe.Write(&((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E4__this, (Authenticator)Sid);
		Unsafe.Write(&((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003Eu__1, (TaskAwaiter)Data);
		((AsyncTaskMethodBuilder*)/*Error near IL_004b: Stack underflow*/)->Start<TStateMachine>(ref *(TStateMachine*)this);
		int num = 0;
		if ((int)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003E1__state)->_003C_003Et__builder == 0)
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
	public void Send(params object[] values)
	{
		_FF00ᘀ(values);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public T As<T>() where T : new()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	public override string ToString()
	{
		return (string)_FF00Ѐ();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	protected virtual bool PrintMembers(StringBuilder builder)
	{
		return _FF00_1400(builder) != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	public override int GetHashCode()
	{
		return (int)_FF00_2700();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	public virtual bool Equals(RpcCallBack? other)
	{
		return _FF00_2800(other) != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	protected unsafe RpcCallBack(RpcCallBack original)
	{
		//IL_001a: Expected VT, but got Obj
		//IL_0023: Expected Obj, but got I4
		//IL_004a: Expected I4, but got Obj
		//IL_0093: Expected native int or pointer, but got Obj
		//IL_0098: Expected native int or pointer, but got Obj
		//IL_00be: Expected native int or pointer, but got Obj
		//IL_00c8: Expected VT, but got I4
		//IL_00c3: Expected native int or pointer, but got Obj
		//IL_00d1: Expected Obj, but got I4
		//IL_0052: Expected native int or pointer, but got Obj
		//IL_005c: Expected Obj, but got VT
		//IL_0057: Expected native int or pointer, but got Obj
		//IL_007d: Expected native int or pointer, but got Obj
		//IL_0087: Expected VT, but got I4
		//IL_0082: Expected native int or pointer, but got Obj
		//IL_00b1->IL0031: Incompatible stack types: I4 vs Obj
		//IL_0070->IL0031: Incompatible stack types: I4 vs Obj
		//IL_0091->IL0031: Incompatible stack types: I4 vs Obj
		//IL_00bc->IL0031: Incompatible stack types: I4 vs Obj
		//IL_007b->IL0031: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		((ILogger)/*Error near IL_001a: Stack underflow*/).Debug<_0021_00210>((string)/*Error near IL_001a: Stack underflow*/, (_0021_00210)this);
		object obj = 3;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 4:
					return;
				case 2:
					Unsafe.Write(&((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E4__this, (Authenticator)((Authenticator._003CListenAsync_003Ed__7*)(nint)original)->_003C_003Et__builder);
					obj2 = 0;
					if (Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton != null)
					{
						obj2 = 0;
					}
					continue;
				case 3:
					Unsafe.Write(&((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)this)->_003C_003Et__builder, (AsyncTaskMethodBuilder)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)original)->_003C_003E1__state);
					obj2 = 2;
					continue;
				default:
					Unsafe.Write(&((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)this)->_003C_003E4__this, ((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)original)->listener);
					obj2 = 0;
					if (Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler != null)
					{
						obj2 = 1;
					}
					continue;
				case 1:
					break;
				}
				break;
			}
			Unsafe.Write(&((Authenticator._003CReceiveAsync_003Ed__9*)(nint)this)->_003C_003Et__builder, (AsyncTaskMethodBuilder)((Authenticator._003CReceiveAsync_003Ed__9*)(nint)original)->_003C_003E1__state);
			obj = 4;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	public unsafe void Deconstruct(out Rpc Rpc, out BinaryWriter Writer, out ushort Sid, out byte[] Data)
	{
		_FF00က((nint)Unsafe.AsPointer(ref Rpc), (nint)Unsafe.AsPointer(ref Writer), (nint)Unsafe.AsPointer(ref Sid), (nint)Unsafe.AsPointer(ref Data));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool InterruptSorter()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RpcCallBack DecorateCustomizableAnalyzer()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected unsafe object _FF00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778368, new IntPtr(2737337545004L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected unsafe object _FF00Ā()
	{
		//IL_001e: Expected I, but got VT
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		((Func<Task>)/*Error near IL_001e: Stack underflow*/)._002Ector((object)/*Error near IL_001e: Stack underflow*/, (nint)typeof(Authenticator._003CListenAuthenticationConnectAsync_003Ed__8).TypeHandle);
		return (object)/*Error near IL_001f: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected unsafe object _FF00Ȁ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778431, new IntPtr(2737337563724L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00Ѐ()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 4054, 1790778430, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778430, new IntPtr(2737337545004L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00Ԁ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778429, new IntPtr(2737337534604L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_0600(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778428, new IntPtr(2737337538764L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_0700(object P_0)
	{
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		((Authenticator)(object)this).Listener = (TcpListener?)((P_0 is Authenticator._003CListenAuthenticationConnectAsync_003Ed__8) ? P_0 : null);
		return (byte)/*Error near IL_0021: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00ࠀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778427, new IntPtr(2737337546044L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_0900()
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
	internal unsafe object _FF00_0A00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778426, new IntPtr(2737337563724L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_0B00(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_003f: Expected I4, but got Obj
		//IL_003a: Expected native int or pointer, but got Obj
		//IL_0053->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005e->IL0026: Incompatible stack types: I4 vs Obj
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
				return;
			case 1:
				((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state = (int)P_0;
				obj2 = 0;
				if (((Authenticator._003CListenAsync_003Ed__7)Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this == null)
				{
					obj2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_0C00(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778425, new IntPtr(2737337546044L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_0D00(ushort P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778424, new IntPtr(2737337534604L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_0E00(ushort P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_003a: Expected native int or pointer, but got Obj
		//IL_0053->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005e->IL0026: Incompatible stack types: I4 vs Obj
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
				return;
			case 1:
				((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state = P_0;
				obj2 = 0;
				if (((Authenticator._003CListenAsync_003Ed__7)Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this != null)
				{
					obj2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00ༀ(nint P_0, nint P_1, nint P_2, nint P_3)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778423, new IntPtr(2737337563724L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00က(nint P_0, nint P_1, nint P_2, nint P_3)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_00bc: Expected native int or pointer, but got Obj
		//IL_0063: Expected Obj, but got I
		//IL_006e: Expected native int or pointer, but got Obj
		//IL_008a: Expected Obj, but got I
		//IL_0056: Expected Obj, but got I4
		//IL_00c6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0078->IL0026: Incompatible stack types: I4 vs Obj
		//IL_009f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00d1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0083->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00aa->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 4;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 2:
					return;
				case 4:
					break;
				case 1:
					((Authenticator)P_3).Listener = (TcpListener?)(object)this;
					Unsafe.Write((void*)(nint)/*Error near IL_0064: Stack underflow*/, /*Error near IL_0064: Stack underflow*/);
					obj2 = 2;
					if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 != 0)
					{
						obj2 = 2;
					}
					continue;
				case 3:
					Unsafe.Write((void*)(nint)/*Error near IL_008b: Stack underflow*/, ((Authenticator)P_1).ListenAuthenticationConnectAsync((object)this));
					obj2 = 0;
					if ((int)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003E1__state)->_003C_003Et__builder == 0)
					{
						obj2 = 0;
					}
					continue;
				default:
					((Authenticator)this).Dispose();
					*(short*)(nint)/*Error near IL_00b2: Stack underflow*/ = (short)P_2;
					obj2 = 1;
					if ((int)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003E4__this)->_003C_003Eu__1 == 0)
					{
						obj2 = 1;
					}
					continue;
				}
				break;
			}
			Unsafe.Write((void*)P_0, ((Authenticator)this).Listener);
			obj = 3;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00ᄀ(nint P_0, nint P_1, nint P_2, nint P_3)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778422, new IntPtr(2737337563724L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected unsafe byte _FF00_1400(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0053: Expected I4, but got Obj
		//IL_0065: Expected I, but got Obj
		//IL_00c2: Expected native int or pointer, but got Obj
		//IL_0077: Expected I4, but got Obj
		//IL_0087: Expected native int or pointer, but got Obj
		//IL_00ed: Expected native int or pointer, but got Obj
		//IL_012f: Expected native int or pointer, but got Obj
		//IL_0159: Expected Obj, but got I4
		//IL_0199: Expected native int or pointer, but got Obj
		//IL_0070->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00cc->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0091->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00f7->IL0026: Incompatible stack types: I4 vs Obj
		//IL_017f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0139->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0119->IL0026: Incompatible stack types: I4 vs Obj
		//IL_015e->IL0022: Incompatible stack heights: 2 vs 0
		//IL_01a3->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00d7->IL0026: Incompatible stack types: I4 vs Obj
		//IL_009c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0102->IL0026: Incompatible stack types: I4 vs Obj
		//IL_018a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0144->IL0026: Incompatible stack heights: 2 vs 1
		//IL_01ae->IL0026: Incompatible stack types: I4 vs Obj
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
					return 1;
				default:
					((Func<Task>)/*Error near IL_0065: Stack underflow*/)._002Ector((object)/*Error near IL_0065: Stack underflow*/, (nint)((Authenticator)P_0).Listener);
					obj2 = 7;
					continue;
				case 2:
					((Authenticator)P_0).StartListening((int)this);
					((TcpListener)/*Error near IL_007c: Stack underflow*/).Start();
					obj2 = 6;
					if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton)->_003C_003E1__state != 0)
					{
						obj2 = 2;
					}
					continue;
				case 1:
					obj = ((Authenticator)P_0).ReceiveAuthenticationDataAsync((object)this);
					((TcpListener)(object)(*(IPAddress*)(&obj))/*cast due to constrained. prefix*/).Dispose();
					((IAsyncStateMachine)/*Error near IL_00b7: Stack underflow*/).MoveNext();
					obj2 = 0;
					if (((Authenticator._003CReceiveAsync_003Ed__9*)(nint)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler)->_003C_003E1__state == 0)
					{
						obj2 = 0;
					}
					continue;
				case 3:
					((Authenticator._003CListenAsync_003Ed__7*)/*Error near IL_00dd: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)P_0);
					((TaskAwaiter*)/*Error near IL_00e2: Stack underflow*/)->GetResult();
					obj2 = 2;
					if ((int)((Authenticator._003CReceiveAsync_003Ed__9*)(nint)Authenticator._003CReceiveAsync_003Ed__9.client)->_003C_003Eu__1 != 0)
					{
						obj2 = 0;
					}
					continue;
				case 7:
					((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)P_0)->SetStateMachine((IAsyncStateMachine)this);
					((IAsyncStateMachine)/*Error near IL_010e: Stack underflow*/).SetStateMachine((IAsyncStateMachine)/*Error near IL_010e: Stack underflow*/);
					obj2 = 5;
					continue;
				case 6:
					_ = ((TaskAwaiter<TcpClient>*)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.ReflectRandomReporter())->IsCompleted;
					_ = 1;
					if (((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003C_003E4__this)->_003Cstream_003E5__2 == null)
					{
						_ = 1;
					}
					continue;
				case 8:
					break;
				case 4:
					((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)P_0)->SetStateMachine((IAsyncStateMachine)this);
					((Encoding)/*Error near IL_016a: Stack underflow*/).GetString((byte[])/*Error near IL_016a: Stack underflow*/, (int)/*Error near IL_016a: Stack underflow*/, (int)/*Error near IL_016a: Stack underflow*/);
					obj2 = 3;
					if (FeverInstaller.McBedrock__BackingField == null)
					{
						obj2 = 1;
					}
					continue;
				case 9:
					((TcpClient)/*Error near IL_018f: Stack underflow*/).Close();
					obj2 = 1;
					if (((FeverInstaller._003CFeverRequest_003Ed__15<>*)(nint)FeverInstaller.ReflectVisualArgument)->_003C_003E1__state == 0)
					{
						obj2 = 8;
					}
					continue;
				}
				break;
			}
			Authenticator._003CReceiveAsync_003Ed__9.DecorateConvertibleParameter();
			_ = Encoding.UTF8;
			obj = 4;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00ᔀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778421, new IntPtr(2737337563724L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00ᘀ(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_004a: Expected I4, but got Obj
		//IL_005e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0069->IL0026: Incompatible stack types: I4 vs Obj
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
				return;
			case 1:
				((Authenticator)(object)((Authenticator)this).Listener).Listener = (TcpListener?)(object)this;
				((Authenticator)/*Error near IL_004a: Stack underflow*/).StartListening((int)P_0);
				obj2 = 0;
				if (Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton != null)
				{
					obj2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00ᜀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778420, new IntPtr(2737337546044L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ushort _FF00_1800()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778419, new IntPtr(2737337546044L), 15))(null, 0, new IntPtr(0L));
		return (ushort)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ushort _FF00ᤀ()
	{
		//IL_0015: Expected native int or pointer, but got Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (ushort)((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ushort _FF00ᨀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778418, new IntPtr(2737337546044L), 15))(null, 0, new IntPtr(0L));
		return (ushort)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_1B00(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778417, new IntPtr(2737337563724L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00ᰀ(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0040: Expected I4, but got Obj
		//IL_003b: Expected native int or pointer, but got Obj
		//IL_0054->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005f->IL0026: Incompatible stack types: I4 vs Obj
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
				return;
			case 0:
				return;
			case 1:
				((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state = (int)P_0;
				obj2 = 0;
				if (((Authenticator._003CListenAsync_003Ed__7)Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this != null)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00ᴀ()
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
	internal unsafe static byte _FF00Ḁ(object P_0, object P_1)
	{
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (((Authenticator)P_1).Listener == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00ἀ()
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
	internal unsafe void _FF00_2000(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778416, new IntPtr(2737337563724L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_2100(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0040: Expected I4, but got Obj
		//IL_003b: Expected native int or pointer, but got Obj
		//IL_0054->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005f->IL0026: Incompatible stack types: I4 vs Obj
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
				return;
			case 0:
				return;
			case 1:
				((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state = (int)P_0;
				obj2 = 0;
				if (((Authenticator._003CListenAsync_003Ed__7)Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this != null)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_2200(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778415, new IntPtr(2737337546044L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_2300()
	{
		//IL_001a: Expected Obj, but got I4
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_2400()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778414, new IntPtr(2737337546044L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_2500()
	{
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return new Authenticator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_2600(object P_0, object P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_008f: Expected I4, but got Obj
		//IL_0072: Expected native int or pointer, but got Obj
		//IL_007c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0057->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0087->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0062->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 2;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 2:
				if (P_0 == P_1)
				{
					return 1;
				}
				obj2 = 0;
				if ((int)((Authenticator._003CListenAsync_003Ed__7*)Authenticator._003CListenAsync_003Ed__7._003C_003E1__state)->_003C_003Et__builder == 0)
				{
					obj2 = 1;
				}
				break;
			case 1:
				if (P_0 == null)
				{
					return 0;
				}
				obj2 = 0;
				if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 == 0)
				{
					obj2 = 0;
				}
				break;
			default:
				return (byte)(int)((Authenticator)P_0).ListenAuthenticationConnectAsync(P_1);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_2700()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected Obj, but got Unknown
		//IL_0030: Expected native int or pointer, but got Obj
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected native int or pointer, but got Obj
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_005e: Expected native int or pointer, but got Obj
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected Ref, but got Unknown
		//IL_0075: Expected native int or pointer, but got Obj
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected I4, but got Unknown
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		((ILogger)/*Error near IL_0019: Stack underflow*/).Debug<_0021_00210>((string)/*Error near IL_0019: Stack underflow*/, (_0021_00210)/*Error near IL_0019: Stack underflow*/);
		((Authenticator)/*Error near IL_001f: Stack underflow*/).Listener = (TcpListener?)(object)this;
		((TcpListener)(Task.Run((Func<Task?>)/*Error near IL_0024: Stack underflow*/) * -1521134295)).Start();
		_003F val = (/*Error near IL_003b: Stack underflow*/ + ((AsyncTaskMethodBuilder*)Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton)->Task) * -1521134295;
		AsyncTaskMethodBuilder asyncTaskMethodBuilder = AsyncTaskMethodBuilder.Create();
		((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)this)->listener.Dispose();
		((IAsyncStateMachine)((val + asyncTaskMethodBuilder) * -1521134295)).MoveNext();
		((AsyncTaskMethodBuilder*)/*Error near IL_0074: Stack underflow*/)->AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref *(TAwaiter*)/*Error near IL_0074: Stack underflow*/, ref *(TStateMachine*)((/*Error near IL_0069: Stack underflow*/ + ((Task)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler).GetAwaiter()) * -1521134295));
		((ILogger)/*Error near IL_007f: Stack underflow*/).Error((Exception)/*Error near IL_007f: Stack underflow*/, (string)(object)((Authenticator._003CReceiveAsync_003Ed__9*)(nint)this)->_003C_003E4__this);
		return (uint)(/*Error near IL_0080: Stack underflow*/ + /*Error near IL_0080: Stack underflow*/);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_2800(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_004f: Expected I4, but got Obj
		//IL_00b2: Expected native int or pointer, but got Obj
		//IL_00b8: Expected native int or pointer, but got Obj
		//IL_00e8: Expected native int or pointer, but got Obj
		//IL_00ee: Expected native int or pointer, but got Obj
		//IL_00f8: Expected Ref, but got VT
		//IL_0069: Expected native int or pointer, but got Obj
		//IL_006f: Expected native int or pointer, but got Obj
		//IL_0128: Expected native int or pointer, but got Obj
		//IL_012e: Expected native int or pointer, but got Obj
		//IL_0138: Expected Ref, but got VT
		//IL_0088: Expected native int or pointer, but got Obj
		//IL_010d: Expected native int or pointer, but got Obj
		//IL_0146: Expected Obj, but got I4
		//IL_0161->IL00f9: Incompatible stack heights: 1 vs 0
		//IL_00c7->IL00f9: Incompatible stack heights: 1 vs 0
		//IL_013d->IL00ac: Incompatible stack heights: 1 vs 0
		//IL_016b->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00d1->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0092->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0117->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00e2->IL0026: Incompatible stack types: I4 vs Obj
		//IL_014b->IL0022: Incompatible stack heights: 1 vs 0
		//IL_009d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0122->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 7;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 4:
				{
					((ILogger)/*Error near IL_0068: Stack underflow*/).Debug<_0021_00210>((string)/*Error near IL_0068: Stack underflow*/, (_0021_00210)/*Error near IL_0068: Stack underflow*/);
					AsyncTaskMethodBuilder asyncTaskMethodBuilder = ((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003Et__builder;
					((TcpListener)(object)((Authenticator._003CListenAsync_003Ed__7*)(nint)P_0)->_003C_003E4__this).Start();
					if ((int)asyncTaskMethodBuilder == 0)
					{
						obj2 = 0;
						if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton)->_003C_003E1__state != 0)
						{
							obj2 = 0;
						}
						break;
					}
					goto case 3;
				}
				case 2:
				{
					AsyncTaskMethodBuilder.Create();
					TcpListener tcpListener = ((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)this)->listener;
					((IAsyncStateMachine)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)P_0)->_003C_003E4__this).MoveNext();
					if (tcpListener != null)
					{
						_ = 4;
						break;
					}
					goto default;
				}
				case 7:
					if (this == P_0)
					{
						return 1;
					}
					obj2 = 6;
					break;
				case 3:
				{
					_ = ((TaskAwaiter*)/*Error near IL_00e7: Stack underflow*/)->IsCompleted;
					int result = ((Authenticator._003CReceiveAsync_003Ed__9*)(nint)this)->_003C_003E1__state;
					((TaskAwaiter*)((Authenticator._003CReceiveAsync_003Ed__9*)(nint)P_0)->_003C_003Et__builder)->GetResult();
					return (byte)result;
				}
				default:
					return 0;
				case 6:
					if (P_0 != null)
					{
						obj2 = 1;
						if ((int)((Authenticator._003CReceiveAsync_003Ed__9*)(nint)Authenticator._003CReceiveAsync_003Ed__9.client)->_003C_003Eu__1 == 0)
						{
							obj2 = 1;
						}
						break;
					}
					goto default;
				case 8:
					((AsyncTaskMethodBuilder*)/*Error near IL_0127: Stack underflow*/)->SetResult();
					_ = ((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)this)->_003C_003E1__state;
					if (!((TaskAwaiter<TcpClient>*)((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)P_0)->_003C_003Et__builder)->IsCompleted)
					{
						goto end_IL_0026;
					}
					goto case 2;
				case 1:
					((Authenticator._003CReceiveAsync_003Ed__9*)/*Error near IL_0151: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)this);
					if ((Authenticator._003CReceiveAsync_003Ed__9.ReflectAdvancedEnumerator() ? ((TaskAwaiter<TcpClient>*)1) : ((TaskAwaiter<TcpClient>*)null))->GetResult() != null)
					{
						_ = 8;
						break;
					}
					goto default;
				}
				continue;
				end_IL_0026:
				break;
			}
			obj = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_2900(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778413, new IntPtr(2737337539804L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_2A00()
	{
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
	}
}
