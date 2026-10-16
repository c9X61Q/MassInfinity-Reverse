using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Mass.Application.Desktop;
using Mass.Application.Desktop.Security;
using Mass.Domain.Desktop.ValueObjects;
using Mass.Domain.Value;
using Mass.Game.Launcher.Entities.Fever;
using RestSharp;
using Serilog;

namespace Mass.Game.Launcher.Java;

public record EntityLaunchJavaGame
{
	[CompilerGenerated]
	protected virtual Type EqualityContract
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (Type)_FF00_FF00_FF00_FF00_FF00_FF00_FF00褀();
		}
	}

	public DesktopSession Session
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (DesktopSession)_FF00_FF00_FF00_FF00_FF00_FF00_FF00넀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		init
		{
			_FF00_FF00_FF00_FF00_FF00_FF00_FF00需(value);
		}
	}

	public string GameId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00_FF00_FF00_FF00_FF00_FF00대();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		init
		{
			_FF00_FF00_FF00_FF00_FF00_FF00_FF00鐀(value);
		}
	}

	public EnumGameType GameType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00_FF00_FF00_FF00_FF00_FF00관();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		init
		{
			_FF00_FF00_FF00_FF00_FF00_FF00_FF00꤀(value);
		}
	}

	public EnumGameVersion GameVersion
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00_FF00_FF00_FF00_FF00_FF00蘀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		init
		{
			_FF00_FF00_FF00_FF00_FF00_FF00_FF00븀(value);
		}
	}

	public string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00_FF00_FF00_FF00_FF00_FF00餀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		init
		{
			_FF00_FF00_FF00_FF00_FF00_FF00_FF00뤀(value);
		}
	}

	public string ServerAddress
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00_FF00_FF00_FF00_FF00_FF00딀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		init
		{
			_FF00_FF00_FF00_FF00_FF00_FF00_FF00뜀(value);
		}
	}

	public int ServerPort
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (int)_FF00_FF00_FF00_FF00_FF00_FF00_FF00밀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		init
		{
			_FF00_FF00_FF00_FF00_FF00_FF00_FF00退((uint)value);
		}
	}

	public SectionValue GameValue
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (SectionValue)_FF00_FF00_FF00_FF00_FF00_FF00_FF00ꨀ();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		init
		{
			_FF00_FF00_FF00_FF00_FF00_FF00_FF00꼀(value);
		}
	}

	public SectionValue? ProxyValue
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (SectionValue?)_FF00_FF00_FF00_FF00_FF00_FF00_FF00ꐀ();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		init
		{
			_FF00_FF00_FF00_FF00_FF00_FF00_FF00뼀(value);
		}
	}

	public bool BlockIrcMessages
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00_FF00_FF00_FF00_FF00_FF00蔀() != 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		init
		{
			_FF00_FF00_FF00_FF00_FF00_FF00_FF00_A700(value ? ((byte)1) : ((byte)0));
		}
	}

	internal static EntityLaunchJavaGame ConcatSingleton;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe EntityLaunchJavaGame(DesktopSession Session, string GameId, EnumGameType GameType, EnumGameVersion GameVersion, string Name, string ServerAddress, int ServerPort, SectionValue GameValue, SectionValue? ProxyValue = null, bool BlockIrcMessages = false)
	{
		//IL_001b: Expected I4, but got Obj
		//IL_0016: Expected native int or pointer, but got Obj
		//IL_0027: Expected VT, but got Obj
		//IL_0022: Expected native int or pointer, but got Obj
		//IL_0033: Expected Obj, but got I4
		//IL_002e: Expected native int or pointer, but got Obj
		//IL_0040: Expected VT, but got I4
		//IL_003b: Expected native int or pointer, but got Obj
		//IL_0048: Expected native int or pointer, but got Obj
		//IL_005a: Expected I4, but got Obj
		//IL_0055: Expected native int or pointer, but got Obj
		//IL_0067: Expected VT, but got I4
		//IL_0062: Expected native int or pointer, but got Obj
		//IL_006f: Expected native int or pointer, but got Obj
		//IL_007c: Expected native int or pointer, but got Obj
		//IL_008e: Expected VT, but got I4
		//IL_0089: Expected native int or pointer, but got Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state = (int)Session;
		Unsafe.Write(&((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003Et__builder, (AsyncTaskMethodBuilder)GameId);
		Unsafe.Write(&((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E4__this, (Authenticator)GameType);
		Unsafe.Write(&((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003Eu__1, (TaskAwaiter)GameVersion);
		Unsafe.Write(&Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton, Name);
		((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)this)->_003C_003E1__state = (int)ServerAddress;
		Unsafe.Write(&((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)this)->_003C_003Et__builder, (AsyncTaskMethodBuilder)ServerPort);
		Unsafe.Write(&((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)this)->listener, GameValue);
		Unsafe.Write(&((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)this)->_003C_003E4__this, ProxyValue);
		Unsafe.Write(&((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)this)->_003C_003Eu__1, (TaskAwaiter<TcpClient>)BlockIrcMessages);
		_ = ((TaskAwaiter*)this)->IsCompleted;
		int num = 0;
		if ((int)((Authenticator._003CReceiveAsync_003Ed__9*)Authenticator._003CReceiveAsync_003Ed__9._003C_003E1__state)->_003C_003Et__builder == 0)
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
	[CompilerGenerated]
	public override string ToString()
	{
		return (string)_FF00_FF00_FF00_FF00_FF00_FF00_FF00윀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	protected virtual bool PrintMembers(StringBuilder builder)
	{
		return _FF00_FF00_FF00_FF00_FF00_FF00_FF00鼀(builder) != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	public override int GetHashCode()
	{
		return (int)_FF00_FF00_FF00_FF00_FF00_FF00_FF00섀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	public virtual bool Equals(EntityLaunchJavaGame? other)
	{
		return _FF00_FF00_FF00_FF00_FF00_FF00_FF00_AB00(other) != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	protected unsafe EntityLaunchJavaGame(EntityLaunchJavaGame original)
	{
		//IL_001a: Expected VT, but got Obj
		//IL_0103: Expected native int or pointer, but got Obj
		//IL_010d: Expected Obj, but got VT
		//IL_0108: Expected native int or pointer, but got Obj
		//IL_00d7: Expected native int or pointer, but got Obj
		//IL_00e1: Expected VT, but got I4
		//IL_00dc: Expected native int or pointer, but got Obj
		//IL_00ed: Expected native int or pointer, but got Obj
		//IL_00f2: Expected native int or pointer, but got Obj
		//IL_012e: Expected native int or pointer, but got Obj
		//IL_0133: Expected native int or pointer, but got Obj
		//IL_0142: Expected native int or pointer, but got Obj
		//IL_00bd: Expected native int or pointer, but got Obj
		//IL_00c7: Expected Obj, but got VT
		//IL_00c2: Expected native int or pointer, but got Obj
		//IL_00d0: Expected Obj, but got I4
		//IL_0159: Expected native int or pointer, but got Obj
		//IL_00a6: Expected native int or pointer, but got Obj
		//IL_00ab: Expected native int or pointer, but got Obj
		//IL_0065: Expected native int or pointer, but got Obj
		//IL_006f: Expected Obj, but got VT
		//IL_006a: Expected native int or pointer, but got Obj
		//IL_0090: Expected native int or pointer, but got Obj
		//IL_009a: Expected VT, but got I4
		//IL_0095: Expected native int or pointer, but got Obj
		//IL_005e: Expected I4, but got Obj
		//IL_0024->IL002d: Incompatible stack types: I4 vs Obj
		//IL_0121->IL002d: Incompatible stack types: I4 vs Obj
		//IL_00eb->IL002d: Incompatible stack types: I4 vs Obj
		//IL_0198->IL002d: Incompatible stack types: I4 vs Obj
		//IL_0101->IL002d: Incompatible stack types: I4 vs Obj
		//IL_014c->IL002d: Incompatible stack types: I4 vs Obj
		//IL_0177->IL002d: Incompatible stack types: I4 vs Obj
		//IL_00ba->IL002d: Incompatible stack types: I4 vs Obj
		//IL_0083->IL002d: Incompatible stack types: I4 vs Obj
		//IL_00a4->IL002d: Incompatible stack types: I4 vs Obj
		//IL_012c->IL002d: Incompatible stack types: I4 vs Obj
		//IL_0157->IL002d: Incompatible stack types: I4 vs Obj
		//IL_0182->IL002d: Incompatible stack types: I4 vs Obj
		//IL_008e->IL002d: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		((ILogger)/*Error near IL_001a: Stack underflow*/).Debug<_0021_00210>((string)/*Error near IL_001a: Stack underflow*/, (_0021_00210)this);
		object obj = 3;
		while (true)
		{
			switch ((int)obj)
			{
			case 9:
				Unsafe.Write(&((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E4__this, (Authenticator)((Authenticator._003CListenAsync_003Ed__7*)(nint)original)->_003C_003Et__builder);
				obj = 10;
				if (Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton != null)
				{
					obj = 4;
				}
				break;
			case 10:
				Unsafe.Write(&((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)this)->_003C_003Et__builder, (AsyncTaskMethodBuilder)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)original)->_003C_003E1__state);
				obj = 5;
				break;
			case 8:
				Unsafe.Write(&((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)this)->_003C_003E4__this, ((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)original)->listener);
				obj = 4;
				break;
			case 4:
				return;
			case 6:
			{
				Unsafe.Write(&Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler, (object)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)original)->_003C_003Eu__1);
				object obj2 = 8;
				obj = obj2;
				break;
			}
			case 1:
				Unsafe.Write(&((Authenticator._003CReceiveAsync_003Ed__9*)(nint)this)->_003C_003Et__builder, (AsyncTaskMethodBuilder)((Authenticator._003CReceiveAsync_003Ed__9*)(nint)original)->_003C_003E1__state);
				obj = 2;
				break;
			case 3:
				Unsafe.Write(&((Authenticator._003CReceiveAsync_003Ed__9*)(nint)this)->client, ((Authenticator._003CReceiveAsync_003Ed__9*)(nint)original)->_003C_003E4__this);
				obj = 7;
				break;
			default:
				Unsafe.Write(&Authenticator._003CReceiveAsync_003Ed__9.CheckCustomChain, (object)((Authenticator._003CReceiveAsync_003Ed__9*)(nint)original)->_003C_003Eu__1);
				obj = 4;
				if ((int)((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003C_003E1__state)->_003C_003Et__builder != 0)
				{
					obj = 9;
				}
				break;
			case 5:
				Unsafe.Write(&((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)this)->_003C_003E4__this, ((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)original)->client);
				obj = 1;
				if ((int)((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003Cstream_003E5__2)->_003C_003Eu__1 != 0)
				{
					obj = 0;
				}
				break;
			case 7:
				((FeverInstaller)this)._003CfeverVersion_003EP = Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.ReflectMixedGateway;
				obj = 0;
				if (((FeverInstaller)FeverInstaller._003CappId_003EP)._003CappVersion_003EP == null)
				{
					obj = 0;
				}
				break;
			case 2:
				((FeverInstaller)this).Client__BackingField = FeverInstaller.McBedrock__BackingField;
				obj = 6;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	public unsafe void Deconstruct(out DesktopSession Session, out string GameId, out EnumGameType GameType, out EnumGameVersion GameVersion, out string Name, out string ServerAddress, out int ServerPort, out SectionValue GameValue, out SectionValue? ProxyValue, out bool BlockIrcMessages)
	{
		_FF00_FF00_FF00_FF00_FF00_FF00_FF00鈀((nint)Unsafe.AsPointer(ref Session), (nint)Unsafe.AsPointer(ref GameId), (nint)Unsafe.AsPointer(ref GameType), (nint)Unsafe.AsPointer(ref GameVersion), (nint)Unsafe.AsPointer(ref Name), (nint)Unsafe.AsPointer(ref ServerAddress), (nint)Unsafe.AsPointer(ref ServerPort), (nint)Unsafe.AsPointer(ref GameValue), (nint)Unsafe.AsPointer(ref ProxyValue), (nint)Unsafe.AsPointer(ref BlockIrcMessages));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ReflectReadableResponder()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static EntityLaunchJavaGame SetState()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00萀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779076, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00蔀()
	{
		//IL_0015: Expected native int or pointer, but got Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (byte)((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe EnumGameVersion _FF00_FF00_FF00_FF00_FF00_FF00_FF00蘀()
	{
		//IL_0015: Expected native int or pointer, but got Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (EnumGameVersion)((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe EnumGameVersion _FF00_FF00_FF00_FF00_FF00_FF00_FF00蜀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779075, new IntPtr(2737337587644L), 15))(null, 0, new IntPtr(0L));
		return (EnumGameVersion)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00蠀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779074, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00褀()
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
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00言()
	{
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return new Authenticator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00謀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779073, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00谀(object P_0)
	{
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		((Authenticator)(object)this).Listener = (TcpListener?)((P_0 is Authenticator._003CListenAuthenticationConnectAsync_003Ed__8) ? P_0 : null);
		return (byte)/*Error near IL_0021: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00贀(object P_0, object P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_008f: Expected I4, but got Obj
		//IL_0072: Expected native int or pointer, but got Obj
		//IL_0056->IL0026: Incompatible stack types: I4 vs Obj
		//IL_007c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0061->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0087->IL0026: Incompatible stack types: I4 vs Obj
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
			case 1:
				if (P_0 == null)
				{
					return 0;
				}
				obj2 = 0;
				if ((int)((Authenticator._003CListenAsync_003Ed__7*)Authenticator._003CListenAsync_003Ed__7._003C_003E1__state)->_003C_003Et__builder == 0)
				{
					obj2 = 0;
				}
				break;
			case 2:
				if (P_0 == P_1)
				{
					return 1;
				}
				obj2 = 1;
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
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00踀()
	{
		//IL_001a: Expected Obj, but got I4
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00輀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779072, new IntPtr(2737337577244L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00退(uint P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00鄀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779135, new IntPtr(2737337579324L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00鈀(nint P_0, nint P_1, nint P_2, nint P_3, nint P_4, nint P_5, nint P_6, nint P_7, nint P_8, nint P_9)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0057: Expected I4, but got Obj
		//IL_00d8: Expected Obj, but got I
		//IL_0088: Expected I4, but got Obj
		//IL_0088: Expected Obj, but got I
		//IL_0101: Expected Obj, but got I
		//IL_0076: Expected Obj, but got I
		//IL_0162: Expected Obj, but got I4
		//IL_0161: Expected native int or pointer, but got Obj
		//IL_00b1: Expected Obj, but got I
		//IL_0065: Expected I4, but got Obj
		//IL_0128: Expected native int or pointer, but got Obj
		//IL_00ed->IL0026: Incompatible stack types: I4 vs Obj
		//IL_009d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0115->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0159->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0081->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0176->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00c6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0146->IL0026: Incompatible stack types: I4 vs Obj
		//IL_006f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0133->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00f8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0120->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0181->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00d1->IL0026: Incompatible stack types: I4 vs Obj
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
			case 9:
				*(int*)P_6 = (int)((Authenticator)this).Listener;
				obj2 = 6;
				break;
			case 4:
				((Authenticator)P_2).Listener = (TcpListener?)(object)this;
				*(_003F*)(nint)/*Error near IL_0077: Stack underflow*/ = /*Error near IL_0077: Stack underflow*/;
				obj2 = 3;
				break;
			case 1:
				((Authenticator)P_0).StartListening((int)this);
				Unsafe.Write((void*)(nint)/*Error near IL_0089: Stack underflow*/, /*Error near IL_0089: Stack underflow*/);
				obj2 = 0;
				if (Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton == null)
				{
					obj2 = 0;
				}
				break;
			case 7:
				return;
			case 6:
				Unsafe.Write((void*)(nint)/*Error near IL_00b2: Stack underflow*/, ((Authenticator)P_7).ReceiveAsync((object)this));
				obj2 = 2;
				if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003Et__builder).listener == null)
				{
					obj2 = 2;
				}
				break;
			default:
				Unsafe.Write((void*)(nint)/*Error near IL_00d9: Stack underflow*/, ((Authenticator)P_1).HandleAuthentication((string)(object)this));
				obj2 = 4;
				if (Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler != null)
				{
					obj2 = 3;
				}
				break;
			case 2:
				((Authenticator._003CListenAsync_003Ed__7*)this)->MoveNext();
				Unsafe.Write((void*)(nint)/*Error near IL_0101: Stack underflow*/, (object)P_8);
				obj2 = 8;
				if (((Authenticator._003CReceiveAsync_003Ed__9)Authenticator._003CReceiveAsync_003Ed__9._003C_003Et__builder)._003C_003E4__this == null)
				{
					obj2 = 2;
				}
				break;
			case 10:
				Unsafe.Write((void*)(nint)this, Authenticator._003CListenAsync_003Ed__7.ObserveTracker());
				_ = 5;
				break;
			case 8:
				((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)this)->MoveNext();
				*(sbyte*)(nint)/*Error near IL_013c: Stack underflow*/ = (sbyte)P_9;
				obj2 = 7;
				break;
			case 3:
				((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)P_3)->SetStateMachine((IAsyncStateMachine)this);
				*(_003F*)(nint)/*Error near IL_014f: Stack underflow*/ = /*Error near IL_014f: Stack underflow*/;
				obj2 = 10;
				break;
			case 5:
				Unsafe.Write((void*)(nint)this, (object)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateGenericStruct());
				_ = 9;
				if (((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003C_003Et__builder).client != null)
				{
					_ = 2;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00錀(nint P_0, nint P_1, nint P_2, nint P_3, nint P_4, nint P_5, nint P_6, nint P_7, nint P_8, nint P_9)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779134, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00鐀(object P_0)
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
				if (((Authenticator._003CListenAsync_003Ed__7)Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this == null)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00销(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779133, new IntPtr(2737337591804L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00阀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779132, new IntPtr(2737337591804L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00需(object P_0)
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00頀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779131, new IntPtr(2737337591804L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00餀()
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
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00騀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779130, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00鼀(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0083: Expected I4, but got Obj
		//IL_0190: Expected Obj, but got Ref
		//IL_0195: Expected I4, but got Obj
		//IL_0195: Expected I4, but got Obj
		//IL_00a8: Expected I4, but got Obj
		//IL_033d: Expected I4, but got Obj
		//IL_034c: Expected Obj, but got Ref
		//IL_02d6: Expected Obj, but got I4
		//IL_01f1: Expected Obj, but got I4
		//IL_0284: Expected Obj, but got I4
		//IL_0219: Expected I4, but got Obj
		//IL_0224: Expected native int or pointer, but got Obj
		//IL_0093: Expected I, but got Obj
		//IL_009d: Expected Obj, but got I4
		//IL_0124: Expected native int or pointer, but got Obj
		//IL_00f9: Expected native int or pointer, but got Obj
		//IL_01a0->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0334->IL0026: Incompatible stack types: I4 vs Obj
		//IL_027b->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0366->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01c1->IL0026: Incompatible stack heights: 3 vs 1
		//IL_01f6->IL0022: Incompatible stack heights: 1 vs 0
		//IL_00d8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0259->IL0026: Incompatible stack types: I4 vs Obj
		//IL_020d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_017a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_022e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01db->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0159->IL0026: Incompatible stack types: I4 vs Obj
		//IL_012e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02cd->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0103->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0371->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01cc->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00e3->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0264->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0239->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0164->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0139->IL0026: Incompatible stack types: I4 vs Obj
		//IL_010e->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 17;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 16:
					((Func<Task>)/*Error near IL_0093: Stack underflow*/)._002Ector((object)/*Error near IL_0093: Stack underflow*/, (nint)((Authenticator)P_0).Listener);
					obj = 8;
					break;
				case 1:
					((Authenticator)/*Error near IL_00a8: Stack underflow*/).StartListening((int)P_0);
					((TcpListener)/*Error near IL_00ad: Stack underflow*/).Start();
					obj2 = 6;
					continue;
				case 9:
					_ = ((AsyncTaskMethodBuilder)(*(BinaryReader*)((Authenticator)(object)(*(BinaryReader*)/*Error near IL_00be: Stack underflow*/)/*cast due to constrained. prefix*/).ListenAuthenticationConnectAsync(P_0))).Task;
					obj2 = 6;
					if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003Et__builder).listener == null)
					{
						obj2 = 7;
					}
					continue;
				case 21:
					((IAsyncStateMachine)((Authenticator)/*Error near IL_00e9: Stack underflow*/).HandleAuthentication((string)P_0)).MoveNext();
					obj2 = 0;
					if (((Authenticator._003CReceiveAsync_003Ed__9*)(nint)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler)->_003C_003E1__state == 0)
					{
						obj2 = 0;
					}
					continue;
				case 19:
					((Authenticator._003CListenAsync_003Ed__7*)/*Error near IL_0114: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)P_0);
					((TaskAwaiter*)/*Error near IL_0119: Stack underflow*/)->GetResult();
					obj2 = 12;
					if ((int)((Authenticator._003CReceiveAsync_003Ed__9*)(nint)Authenticator._003CReceiveAsync_003Ed__9.client)->_003C_003Eu__1 != 0)
					{
						obj2 = 0;
					}
					continue;
				case 18:
					((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)/*Error near IL_013f: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)P_0);
					((IAsyncStateMachine)/*Error near IL_0144: Stack underflow*/).SetStateMachine((IAsyncStateMachine)/*Error near IL_0144: Stack underflow*/);
					obj2 = 9;
					if (((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003C_003Et__builder).client != null)
					{
						obj2 = 20;
					}
					continue;
				case 14:
					((Authenticator._003CReceiveAsync_003Ed__9*)/*Error near IL_016a: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)P_0);
					((Task<TcpClient>)/*Error near IL_016f: Stack underflow*/).GetAwaiter();
					obj2 = 4;
					continue;
				default:
					obj = Authenticator._003CReceiveAsync_003Ed__9.DecorateConvertibleParameter();
					((Encoding)/*Error near IL_0195: Stack underflow*/).GetString((byte[])/*Error near IL_0195: Stack underflow*/, (int)P_0, (int)((Encoding)(object)(*(NetworkStream*)this)/*cast due to constrained. prefix*/).GetBytes((string)(&obj)));
					obj2 = 3;
					continue;
				case 7:
					((Task<string>)(object)(*(BinaryReader*)((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)BinaryReader/*cast due to constrained. prefix*/).HandleNotifier())/*cast due to constrained. prefix*/).GetAwaiter();
					_ = 1;
					if (FeverInstaller.ReflectVisualArgument == null)
					{
						_ = 1;
					}
					continue;
				case 17:
					((Stream)/*Error near IL_01d1: Stack underflow*/).Read((byte[])/*Error near IL_01d1: Stack underflow*/, (int)/*Error near IL_01d1: Stack underflow*/, (int)/*Error near IL_01d1: Stack underflow*/);
					_ = 16;
					continue;
				case 8:
					_ = ((TaskAwaiter<string>)(*(BinaryReader*)((FeverInstaller)(object)(*(BinaryReader*)this)/*cast due to constrained. prefix*/).InstallAsync())).IsCompleted;
					obj = 9;
					break;
				case 13:
					((RestClientOptions)/*Error near IL_0202: Stack underflow*/).UserAgent = (string)(object)((FeverInstaller)P_0).GetFeverManifestInfoAsync((object)this);
					obj2 = 18;
					continue;
				case 15:
					((RestClient)/*Error near IL_0219: Stack underflow*/)._002Ector((RestClientOptions)/*Error near IL_0219: Stack underflow*/, (ConfigureHeaders)/*Error near IL_0219: Stack underflow*/, (ConfigureSerialization)/*Error near IL_0219: Stack underflow*/, (byte)(int)((FeverInstaller)P_0).FeverRequest<T>((RestRequest)(object)this) != 0);
					obj2 = 21;
					if ((int)((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14*)(nint)FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14._003C_003E4__this)->_003C_003Eu__1 == 0)
					{
						obj2 = 12;
					}
					continue;
				case 10:
					((FeverInstaller._003CFeverRequest_003Ed__15<>)(*(BinaryReader*)P_0)/*cast due to constrained. prefix*/).MoveNext();
					((AsyncTaskMethodBuilder<EntityFeverManifest>)BinaryReader/*cast due to constrained. prefix*/).Create();
					obj2 = 15;
					if (((FeverInstaller._003CGetFeverManifestAsync_003Ed__12)FeverInstaller._003CGetFeverManifestAsync_003Ed__12._003C_003Et__builder)._003C_003E4__this == null)
					{
						obj2 = 3;
					}
					continue;
				case 4:
					((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14*)this)->MoveNext();
					AsyncTaskMethodBuilder<EntityFeverAppVersion>.Create();
					_ = 10;
					continue;
				case 12:
					obj = ((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14)BinaryReader/*cast due to constrained. prefix*/).AnalyzeHandler();
					_ = ref obj;
					((AsyncTaskMethodBuilder<_0021_00210>)ChaChaX/*cast due to constrained. prefix*/).Create();
					/*Error near IL_0291: Member reference must be method, but was: Field*/;
				case 20:
					((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13*)this)->MoveNext();
					((AsyncTaskMethodBuilder<_0021_00210>*)/*Error near IL_02c2: Stack underflow*/)->Start<TStateMachine>(ref *(TStateMachine*)P_0);
					obj2 = 2;
					continue;
				case 6:
					obj = FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13.CallGateway();
					_ = ref obj;
					/*Error near IL_02d8: Member reference must be method, but was: Field*/;
				case 2:
					FeverInstaller._003CInstallAsync_003Ed__11.CheckIsolatedElement();
					/*Error near IL_02f9: Member reference must be method, but was: Field*/;
				case 3:
					((Task<RestResponse<EntityFeverResponse<_00210>>>)(object)((Rpc)P_0).Logger).GetAwaiter();
					obj2 = 13;
					continue;
				case 11:
					return 1;
				case 5:
					((Rpc)P_0).NeedCha = (byte)(int)this != 0;
					obj = (object)/*Error near IL_033f: Stack underflow*/;
					((AsyncTaskMethodBuilder<_00210>)(*(ConfigValue*)/*Error near IL_034c: Stack underflow*/)/*cast due to constrained. prefix*/).SetException((Exception)(&obj));
					((AsyncTaskMethodBuilder<_00210>*)/*Error near IL_0351: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)/*Error near IL_0351: Stack underflow*/);
					obj2 = 11;
					if (Rpc.ParseMap != null)
					{
						obj2 = 4;
					}
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00ꀀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779129, new IntPtr(2737337594924L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00ꄀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779128, new IntPtr(2737337583484L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00ꈀ()
	{
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00ꌀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779127, new IntPtr(2737337591804L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00ꐀ()
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
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00ꔀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779126, new IntPtr(2737337591804L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00ꘀ(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779125, new IntPtr(2737337583484L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_A700(byte P_0)
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00ꠀ(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779124, new IntPtr(2737337591804L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00꤀(EnumGameType P_0)
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
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00ꨀ()
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
	internal unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00_AB00(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_006b: Expected I4, but got Obj
		//IL_01d8: Expected native int or pointer, but got Obj
		//IL_01de: Expected native int or pointer, but got Obj
		//IL_01e8: Expected Obj, but got VT
		//IL_00cb: Expected native int or pointer, but got Obj
		//IL_00d1: Expected native int or pointer, but got Obj
		//IL_00db: Expected Ref, but got VT
		//IL_0076: Expected native int or pointer, but got Obj
		//IL_007c: Expected native int or pointer, but got Obj
		//IL_0087: Expected I4, but got VT
		//IL_0110: Expected native int or pointer, but got Obj
		//IL_0116: Expected native int or pointer, but got Obj
		//IL_0120: Expected Obj, but got VT
		//IL_0221: Expected native int or pointer, but got Obj
		//IL_0227: Expected native int or pointer, but got Obj
		//IL_0231: Expected Ref, but got VT
		//IL_026b: Expected native int or pointer, but got Obj
		//IL_0271: Expected native int or pointer, but got Obj
		//IL_014a: Expected native int or pointer, but got Obj
		//IL_0150: Expected native int or pointer, but got Obj
		//IL_0246: Expected native int or pointer, but got Obj
		//IL_024c: Expected native int or pointer, but got Obj
		//IL_0256: Expected Ref, but got VT
		//IL_0091: Expected native int or pointer, but got Obj
		//IL_0097: Expected native int or pointer, but got Obj
		//IL_00a1: Expected Obj, but got VT
		//IL_01f7: Expected native int or pointer, but got Obj
		//IL_029a: Expected native int or pointer, but got Obj
		//IL_00b0: Expected native int or pointer, but got Obj
		//IL_00e0->IL0087: Incompatible stack heights: 1 vs 0
		//IL_0236->IL0087: Incompatible stack heights: 1 vs 0
		//IL_015f->IL0087: Incompatible stack heights: 3 vs 0
		//IL_0193->IL0087: Incompatible stack heights: 2 vs 0
		//IL_0201->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ea->IL0026: Incompatible stack heights: 2 vs 1
		//IL_02a4->IL0026: Incompatible stack types: I4 vs Obj
		//IL_010a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0139->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0240->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0169->IL0026: Incompatible stack heights: 4 vs 1
		//IL_0265->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ba->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01d2->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01a7->IL0026: Incompatible stack heights: 3 vs 1
		//IL_020c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02af->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0144->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c5->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01b2->IL0026: Incompatible stack heights: 3 vs 1
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 5;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 6:
			{
				((ILogger)/*Error near IL_0075: Stack underflow*/).Debug<_0021_00210>((string)/*Error near IL_0075: Stack underflow*/, (_0021_00210)/*Error near IL_0075: Stack underflow*/);
				AsyncTaskMethodBuilder asyncTaskMethodBuilder = ((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003Et__builder;
				((TcpListener)(object)((Authenticator._003CListenAsync_003Ed__7*)(nint)P_0)->_003C_003E4__this).Start();
				return (byte)(int)asyncTaskMethodBuilder;
			}
			default:
				return 0;
			case 13:
			{
				((AsyncTaskMethodBuilder*)/*Error near IL_0090: Stack underflow*/)->Start<TStateMachine>(ref *(TStateMachine*)/*Error near IL_0090: Stack underflow*/);
				int num = ((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)this)->_003C_003E1__state;
				GC.SuppressFinalize(((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)P_0)->_003C_003Et__builder);
				if (num != 0)
				{
					obj2 = 8;
					if ((int)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003E4__this)->_003C_003Eu__1 != 0)
					{
						obj2 = 8;
					}
					break;
				}
				goto default;
			}
			case 2:
			{
				_ = ((TaskAwaiter*)/*Error near IL_00ca: Stack underflow*/)->IsCompleted;
				int num2 = ((Authenticator._003CReceiveAsync_003Ed__9*)(nint)this)->_003C_003E1__state;
				((TaskAwaiter*)((Authenticator._003CReceiveAsync_003Ed__9*)(nint)P_0)->_003C_003Et__builder)->GetResult();
				if (num2 != 0)
				{
					_ = 7;
					break;
				}
				goto default;
			}
			case 5:
				if (this == P_0)
				{
					return 1;
				}
				obj2 = 4;
				break;
			case 7:
				((ILogger)/*Error near IL_010f: Stack underflow*/).Error((Exception)/*Error near IL_010f: Stack underflow*/, (string)/*Error near IL_010f: Stack underflow*/);
				((IAsyncStateMachine)((Authenticator._003CReceiveAsync_003Ed__9*)(nint)this)->_003C_003Eu__1).SetStateMachine((IAsyncStateMachine)Authenticator._003CReceiveAsync_003Ed__9.CheckCustomChain);
				if ((int)/*Error near IL_0125: Stack underflow*/ != 0)
				{
					obj2 = 10;
					if (((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003C_003Et__builder).client != null)
					{
						obj2 = 8;
					}
					break;
				}
				goto default;
			case 11:
				((TcpListener)/*Error near IL_0149: Stack underflow*/).AcceptTcpClientAsync();
				_ = ((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)this)->_003Cstream_003E5__2;
				_ = ((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)P_0)->_003C_003Eu__1;
				if (Encoding.UTF8 != null)
				{
					_ = 12;
					break;
				}
				goto default;
			case 15:
				((Encoding)/*Error near IL_017d: Stack underflow*/).GetBytes((string)/*Error near IL_017d: Stack underflow*/);
				_ = ((FeverInstaller)this)._003CappId_003EP;
				if ((int)((Task<string>)((FeverInstaller)P_0)._003CappVersion_003EP).GetAwaiter() != 0)
				{
					_ = 0;
					if (FeverInstaller.ReflectVisualArgument == null)
					{
						_ = 1;
					}
					break;
				}
				goto default;
			case 14:
				((FeverInstaller)(object)this).Dispose();
				if (!((TaskAwaiter<string>*)((FeverInstaller)P_0).InstallAsync())->IsCompleted)
				{
					obj2 = 3;
					break;
				}
				goto case 11;
			case 1:
				((RestClientOptions)/*Error near IL_01d7: Stack underflow*/)._002Ector();
				((RestClient)/*Error near IL_01e8: Stack underflow*/)._002Ector((RestClientOptions)/*Error near IL_01e8: Stack underflow*/, (ConfigureHeaders)/*Error near IL_01e8: Stack underflow*/, (ConfigureSerialization)(object)((FeverInstaller._003CFeverRequest_003Ed__15<>*)(nint)this)->_003C_003Eu__1, (byte)((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14*)(nint)P_0)->_003C_003E1__state != 0);
				if ((int)/*Error near IL_01ed: Stack underflow*/ == 0)
				{
					obj2 = 0;
					if ((int)((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14*)(nint)FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14._003C_003E4__this)->_003C_003Eu__1 != 0)
					{
						obj2 = 0;
					}
					break;
				}
				goto case 2;
			case 8:
				((AsyncTaskMethodBuilder<EntityFeverManifest>*)/*Error near IL_0220: Stack underflow*/)->Start<TStateMachine>(ref *(TStateMachine*)/*Error near IL_0220: Stack underflow*/);
				_ = ((FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)(nint)this)->_003C_003E1__state;
				if (((AsyncTaskMethodBuilder<EntityFeverManifestInfo>*)((FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)(nint)P_0)->_003C_003Et__builder)->Task != null)
				{
					_ = 15;
					break;
				}
				goto default;
			case 12:
				((AsyncTaskMethodBuilder<EntityFeverManifestInfo>*)/*Error near IL_0245: Stack underflow*/)->Start<TStateMachine>(ref *(TStateMachine*)/*Error near IL_0245: Stack underflow*/);
				((AsyncTaskMethodBuilder<EntityFeverAppVersion>*)((FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)(nint)this)->_003C_003Eu__1)->Start<TStateMachine>(ref *(TStateMachine*)FeverInstaller._003CGetFeverManifestAsync_003Ed__12.ReflectReporter);
				if ((int)/*Error near IL_025b: Stack underflow*/ != 0)
				{
					obj2 = 13;
					break;
				}
				goto default;
			case 10:
				AsyncTaskMethodBuilder<_0021_00210>.Create();
				_ = ((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13*)(nint)this)->_003C_003E4__this;
				_ = ((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13*)(nint)P_0)->version;
				/*Error near IL_0276: Member reference must be method, but was: Field*/;
			case 4:
				if (P_0 != null)
				{
					obj2 = 14;
					if (((FeverInstaller._003CInstallAsync_003Ed__11*)(nint)FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13.CheckScalableWorker)->_003C_003E1__state != 0)
					{
						obj2 = 7;
					}
					break;
				}
				goto default;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00가(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779123, new IntPtr(2737337597004L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe EnumGameType _FF00_FF00_FF00_FF00_FF00_FF00_FF00관()
	{
		//IL_0015: Expected native int or pointer, but got Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (EnumGameType)((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe EnumGameType _FF00_FF00_FF00_FF00_FF00_FF00_FF00글()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779122, new IntPtr(2737337587644L), 15))(null, 0, new IntPtr(0L));
		return (EnumGameType)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00꼀(object P_0)
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
				if (((Authenticator._003CListenAsync_003Ed__7)Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this == null)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00뀀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779121, new IntPtr(2737337584524L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00넀()
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
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00눀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779120, new IntPtr(2737337597004L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00대()
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
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00됀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779119, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00딀()
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
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00똀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779118, new IntPtr(2737337591804L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00뜀(object P_0)
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00렀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779117, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00뤀(object P_0)
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00먀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779116, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00_FF00_FF00_FF00_FF00묀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779115, new IntPtr(2737337591804L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00_FF00_FF00_FF00_FF00밀()
	{
		//IL_0015: Expected native int or pointer, but got Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (uint)((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00_FF00_FF00_FF00_FF00봀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779114, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00븀(EnumGameVersion P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00뼀(object P_0)
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00쀀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779113, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00_FF00_FF00_FF00_FF00섀()
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
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected Obj, but got Unknown
		//IL_008c: Expected native int or pointer, but got Obj
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected Obj, but got Unknown
		//IL_00a3: Expected native int or pointer, but got Obj
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected Obj, but got Unknown
		//IL_00ba: Expected native int or pointer, but got Obj
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected Obj, but got Unknown
		//IL_00d0: Expected Obj, but got VT
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected Obj, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected I4, but got Unknown
		//IL_00ff: Expected native int or pointer, but got Obj
		//IL_0109: Expected Ref, but got VT
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
		((AsyncTaskMethodBuilder*)/*Error near IL_008b: Stack underflow*/)->SetException((Exception)((/*Error near IL_0080: Stack underflow*/ + /*Error near IL_0080: Stack underflow*/) * -1521134295));
		((IAsyncStateMachine)/*Error near IL_0096: Stack underflow*/).SetStateMachine((IAsyncStateMachine)Authenticator._003CReceiveAsync_003Ed__9.CheckCustomChain);
		((AsyncTaskMethodBuilder*)/*Error near IL_00a2: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)((/*Error near IL_0097: Stack underflow*/ + /*Error near IL_0097: Stack underflow*/) * -1521134295));
		return (uint)((Stream)/*Error near IL_00fe: Stack underflow*/).Read((byte[])/*Error near IL_00fe: Stack underflow*/, (int)/*Error near IL_00fe: Stack underflow*/, (((Task<string>)(((object)((Encoding)((Task<TcpClient>)((/*Error near IL_00ae: Stack underflow*/ + ((TcpListener)(object)((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)this)->client).AcceptTcpClientAsync()) * -1521134295)).GetAwaiter()).GetBytes((string)((((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)this)->_003C_003Eu__1 + Encoding.UTF8) * -1521134295)) + (object)((TcpClient)((FeverInstaller)this)._003CappId_003EP).GetStream()) * -1521134295)).GetAwaiter() + ((TaskAwaiter<string>*)((FeverInstaller)this).Client__BackingField)->GetResult()) * -1521134295) + (((TaskAwaiter<string>*)((FeverInstaller._003CFeverRequest_003Ed__15<>*)(nint)this)->_003C_003Et__builder)->IsCompleted ? 1u : 0u);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00_FF00_FF00_FF00_FF00숀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779112, new IntPtr(2737337597004L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00쌀(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779111, new IntPtr(2737337591804L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00쐀(object P_0, object P_1)
	{
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (((Authenticator)P_1).Listener == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00씀(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779110, new IntPtr(2737337581404L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00윀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 3739, 1790779109, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790779109, new IntPtr(2737337574124L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}
}
