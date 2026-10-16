using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using Mass.Application.Desktop;
using Mass.Domain.Desktop.ValueObjects;
using Mass.Domain.Value;

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
	public EntityLaunchJavaGame(DesktopSession Session, string GameId, EnumGameType GameType, EnumGameVersion GameVersion, string Name, string ServerAddress, int ServerPort, SectionValue GameValue, SectionValue? ProxyValue = null, bool BlockIrcMessages = false)
	{
		//IL_0089: Expected I4, but got Obj
		//IL_0077->IL0080: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		EntityLaunchJavaGame entityLaunchJavaGame = this;
		if (0 == 0)
		{
			entityLaunchJavaGame = (EntityLaunchJavaGame)0;
		}
		switch ((int)entityLaunchJavaGame)
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
	protected EntityLaunchJavaGame(EntityLaunchJavaGame original)
	{
		//IL_0097: Expected Obj, but got I4
		//IL_00c8->IL001c: Incompatible stack heights: 3 vs 2
		//IL_00aa->IL001c: Incompatible stack heights: 4 vs 2
		//IL_0117->IL001c: Incompatible stack heights: 4 vs 2
		//IL_00b8->IL001c: Incompatible stack heights: 4 vs 2
		//IL_00e3->IL001c: Incompatible stack heights: 3 vs 2
		//IL_00fe->IL001c: Incompatible stack heights: 3 vs 2
		//IL_0089->IL001c: Incompatible stack heights: 4 vs 2
		//IL_0062->IL001c: Incompatible stack heights: 3 vs 2
		//IL_007b->IL001c: Incompatible stack heights: 4 vs 2
		//IL_00d3->IL001c: Incompatible stack heights: 3 vs 2
		//IL_00ee->IL001c: Incompatible stack heights: 3 vs 2
		//IL_001c->IL001c: Incompatible stack heights: 4 vs 2
		//IL_0109->IL001c: Incompatible stack heights: 3 vs 2
		//IL_006d->IL001c: Incompatible stack heights: 3 vs 2
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		while (true)
		{
			switch (3)
			{
			case 9:
				if (10 != 0)
				{
					_ = 4;
				}
				break;
			case 10:
				_ = 5;
				break;
			case 8:
				_ = 4;
				break;
			case 4:
				return;
			case 6:
			{
				object obj = 8;
				break;
			}
			case 1:
				_ = 2;
				break;
			case 3:
				_ = 7;
				break;
			default:
				if (4 != 0)
				{
					_ = 9;
				}
				break;
			case 5:
				if (true)
				{
					_ = 0;
				}
				break;
			case 7:
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			case 2:
				_ = 6;
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
	internal byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00蔀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal EnumGameVersion _FF00_FF00_FF00_FF00_FF00_FF00_FF00蘀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (EnumGameVersion)(int)this;
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
	protected object _FF00_FF00_FF00_FF00_FF00_FF00_FF00褀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_000a: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_FF00_FF00言()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00謀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779073, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00谀(object P_0)
	{
		//IL_000c: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00贀(object P_0, object P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		//IL_006e: Expected I4, but got Obj
		//IL_0041->IL0019: Incompatible stack heights: 0 vs 1
		//IL_005f->IL0019: Incompatible stack heights: 0 vs 1
		//IL_004c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_006a->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 2;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 1:
				if (P_0 != null)
				{
					if (0 == 0)
					{
						obj2 = 0;
					}
					break;
				}
				return 0;
			case 2:
				if (P_0 != P_1)
				{
					if (1 == 0)
					{
						obj2 = 0;
					}
					break;
				}
				return 1;
			default:
				return (byte)(int)P_1;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00踀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00輀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779072, new IntPtr(2737337577244L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_FF00退(uint P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_003b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0046->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		while (true)
		{
			switch ((int)obj)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				if (false)
				{
					_ = 0;
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
		//IL_0010: Expected Obj, but got I4
		//IL_004a: Expected I4, but got Obj
		//IL_00fe: Expected I4, but got Obj
		//IL_0062: Expected I4, but got Obj
		//IL_00ef: Expected I4, but got Obj
		//IL_0054: Expected I4, but got Obj
		//IL_00b4->IL0019: Incompatible stack heights: 0 vs 1
		//IL_007c->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00d0->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0108->IL0019: Incompatible stack types: I4 vs Obj
		//IL_006c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0119->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0099->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00f9->IL0019: Incompatible stack types: I4 vs Obj
		//IL_005e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00ea->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00bf->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0087->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00db->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0124->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00a4->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 9:
				*(int*)P_6 = (int)this;
				obj2 = 6;
				break;
			case 4:
				*(int*)P_2 = (int)this;
				obj2 = 3;
				break;
			case 1:
				Unsafe.Write((void*)P_0, this);
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			case 7:
				return;
			case 6:
				Unsafe.Write((void*)P_7, this);
				if (2 == 0)
				{
					obj2 = 2;
				}
				break;
			default:
				Unsafe.Write((void*)P_1, this);
				if (4 != 0)
				{
					obj2 = 3;
				}
				break;
			case 2:
				Unsafe.Write((void*)P_8, this);
				if (8 == 0)
				{
					obj2 = 2;
				}
				break;
			case 10:
				Unsafe.Write((void*)P_4, this);
				obj2 = 5;
				break;
			case 8:
				*(sbyte*)P_9 = (sbyte)(int)this;
				obj2 = 7;
				break;
			case 3:
				*(int*)P_3 = (int)this;
				obj2 = 10;
				break;
			case 5:
				Unsafe.Write((void*)P_5, this);
				if (9 != 0)
				{
					obj2 = 2;
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
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_FF00鐀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_003b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0046->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		while (true)
		{
			switch ((int)obj)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				if (0 == 0)
				{
					_ = 0;
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
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_FF00需(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_003a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0045->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		while (true)
		{
			switch ((int)obj)
			{
			default:
				return;
			case 1:
				if (0 == 0)
				{
					_ = 0;
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
	internal object _FF00_FF00_FF00_FF00_FF00_FF00_FF00餀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00騀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779130, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00鼀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0076: Expected I4, but got Obj
		//IL_015f: Expected Obj, but got I4
		//IL_0088: Expected Obj, but got I4
		//IL_012a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_009b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_020f->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0228->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01b9->IL0019: Incompatible stack heights: 2 vs 1
		//IL_01ff->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0164->IL0015: Incompatible stack heights: 1 vs 0
		//IL_00ab->IL0019: Incompatible stack heights: 0 vs 1
		//IL_019f->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0173->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0115->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0151->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00fc->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00e1->IL0019: Incompatible stack heights: 0 vs 1
		//IL_01ea->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00c6->IL0019: Incompatible stack heights: 0 vs 1
		//IL_021a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_024c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0146->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00b6->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01aa->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01db->IL0019: Incompatible stack types: I4 vs Obj
		//IL_018f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0107->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00ec->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00d1->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
					obj = 8;
					break;
				case 1:
					obj2 = 6;
					continue;
				case 9:
					if (6 == 0)
					{
						obj2 = 7;
					}
					continue;
				case 21:
					if (0 == 0)
					{
						obj2 = 0;
					}
					continue;
				case 19:
					if (12 != 0)
					{
						obj2 = 0;
					}
					continue;
				case 18:
					if (9 != 0)
					{
						obj2 = 20;
					}
					continue;
				case 14:
					obj2 = 4;
					continue;
				default:
					obj = this;
					_ = ref obj;
					_ = 3;
					continue;
				case 7:
					obj2 = P_0;
					if (1 == 0)
					{
						obj2 = 1;
					}
					continue;
				case 17:
					obj2 = 16;
					continue;
				case 8:
					obj = 9;
					break;
				case 13:
					_ = 18;
					continue;
				case 15:
					obj2 = P_0;
					if (21 == 0)
					{
						obj2 = 12;
					}
					continue;
				case 10:
					if (15 == 0)
					{
						obj2 = 3;
					}
					continue;
				case 4:
					_ = 10;
					continue;
				case 12:
					obj2 = P_0;
					obj = this;
					_ = ref obj;
					if (2 == 0)
					{
						obj2 = 14;
					}
					continue;
				case 20:
					_ = 2;
					continue;
				case 6:
					obj = this;
					_ = ref obj;
					_ = 19;
					continue;
				case 2:
					if (5 == 0)
					{
						obj2 = 5;
					}
					continue;
				case 3:
					obj2 = 13;
					continue;
				case 11:
					return 1;
				case 5:
					obj2 = P_0;
					obj = this;
					_ = ref obj;
					if (11 != 0)
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
	internal static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00ꈀ()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00ꌀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779127, new IntPtr(2737337591804L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_FF00_FF00ꐀ()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
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
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_A700(byte P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_003a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0045->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		while (true)
		{
			switch ((int)obj)
			{
			default:
				return;
			case 1:
				if (0 == 0)
				{
					_ = 0;
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
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_FF00꤀(EnumGameType P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_003a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0045->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		while (true)
		{
			switch ((int)obj)
			{
			default:
				return;
			case 1:
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_FF00_FF00ꨀ()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00_AB00(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_005e: Expected I4, but got Obj
		//IL_006a: Expected I4, but got Obj
		//IL_014c->IL0090: Incompatible stack heights: 1 vs 0
		//IL_009b->IL006a: Incompatible stack heights: 1 vs 0
		//IL_00d0->IL006a: Incompatible stack heights: 1 vs 0
		//IL_017d->IL006a: Incompatible stack heights: 1 vs 0
		//IL_01a7->IL0063: Incompatible stack heights: 1 vs 0
		//IL_00f2->IL006a: Incompatible stack heights: 1 vs 0
		//IL_0192->IL006a: Incompatible stack heights: 1 vs 0
		//IL_0079->IL006a: Incompatible stack heights: 1 vs 0
		//IL_0137->IL00e7: Incompatible stack heights: 1 vs 0
		//IL_0116->IL006a: Incompatible stack heights: 1 vs 0
		//IL_00a5->IL0019: Incompatible stack heights: 2 vs 1
		//IL_01c3->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00c5->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0187->IL0019: Incompatible stack heights: 2 vs 1
		//IL_01b1->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00fc->IL0019: Incompatible stack heights: 2 vs 1
		//IL_019c->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0141->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0163->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01ce->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00e7->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0090->IL0019: Incompatible stack types: I4 vs Obj
		//IL_012d->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 5;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 6:
				return (byte)(int)P_0;
			default:
				return 0;
			case 13:
				obj2 = this;
				if (P_0 != null)
				{
					if (8 != 0)
					{
						obj2 = 8;
					}
					break;
				}
				goto default;
			case 2:
				if (P_0 != null)
				{
					_ = 7;
					break;
				}
				goto default;
			case 5:
				if (this == P_0)
				{
					return 1;
				}
				obj2 = 4;
				break;
			case 7:
				obj2 = this;
				if (P_0 != null)
				{
					if (10 != 0)
					{
						obj2 = 8;
					}
					break;
				}
				goto default;
			case 11:
				if (P_0 != null)
				{
					_ = 12;
					break;
				}
				goto default;
			case 15:
				obj2 = this;
				if (P_0 != null)
				{
					if (0 == 0)
					{
						obj2 = 1;
					}
					break;
				}
				goto default;
			case 14:
				if (P_0 == null)
				{
					_ = 3;
					break;
				}
				goto case 11;
			case 1:
				obj2 = this;
				if (P_0 == null)
				{
					if (false)
					{
						obj2 = 0;
					}
					break;
				}
				goto case 2;
			case 8:
				if (P_0 != null)
				{
					_ = 15;
					break;
				}
				goto default;
			case 12:
				if (P_0 != null)
				{
					_ = 13;
					break;
				}
				goto default;
			case 10:
				if (P_0 == null)
				{
					_ = 9;
					break;
				}
				goto case 6;
			case 4:
				if (P_0 != null)
				{
					if (14 != 0)
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
	internal EnumGameType _FF00_FF00_FF00_FF00_FF00_FF00_FF00관()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (EnumGameType)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe EnumGameType _FF00_FF00_FF00_FF00_FF00_FF00_FF00글()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779122, new IntPtr(2737337587644L), 15))(null, 0, new IntPtr(0L));
		return (EnumGameType)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_FF00꼀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_003b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0046->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		while (true)
		{
			switch ((int)obj)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				if (0 == 0)
				{
					_ = 0;
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
	internal object _FF00_FF00_FF00_FF00_FF00_FF00_FF00넀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00눀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779120, new IntPtr(2737337597004L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_FF00_FF00대()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00됀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779119, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_FF00_FF00딀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00똀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779118, new IntPtr(2737337591804L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_FF00뜀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_003a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0045->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		while (true)
		{
			switch ((int)obj)
			{
			default:
				return;
			case 1:
				if (0 == 0)
				{
					_ = 0;
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
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_FF00뤀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_003a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0045->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		while (true)
		{
			switch ((int)obj)
			{
			default:
				return;
			case 1:
				if (0 == 0)
				{
					_ = 0;
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
	internal uint _FF00_FF00_FF00_FF00_FF00_FF00_FF00밀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (uint)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00_FF00_FF00_FF00_FF00봀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779114, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_FF00븀(EnumGameVersion P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_003b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0046->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		while (true)
		{
			switch ((int)obj)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				if (false)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_FF00뼀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_003a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0045->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		while (true)
		{
			switch ((int)obj)
			{
			default:
				return;
			case 1:
				if (0 == 0)
				{
					_ = 0;
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
	internal uint _FF00_FF00_FF00_FF00_FF00_FF00_FF00섀()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected I4, but got Unknown
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (uint)((((((((((this * -1521134295 + this) * -1521134295 + this) * -1521134295 + this) * -1521134295 + this) * -1521134295 + this) * -1521134295 + this) * -1521134295 + this) * -1521134295 + this) * -1521134295 + this) * -1521134295 + this);
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
	internal static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00쐀(object P_0, object P_1)
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (P_1 == null) ? ((byte)1) : ((byte)0);
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
