using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

namespace Mass.Game.Proxy;

public record EntitySocks5
{
	[CompilerGenerated]
	protected virtual Type EqualityContract
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (Type)_FF00_FF00_FF00_FF00_FF00_FF00ꀀ();
		}
	}

	public string Address
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00_FF00_FF00_FF00_FF00頀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		init
		{
			_FF00_FF00_FF00_FF00_FF00_FF00蜀(value);
		}
	}

	public int Port
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (int)_FF00_FF00_FF00_FF00_FF00_FF00耀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		init
		{
			_FF00_FF00_FF00_FF00_FF00_FF00騀((uint)value);
		}
	}

	public EntitySocks5Account? Account
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (EntitySocks5Account?)_FF00_FF00_FF00_FF00_FF00_FF00鄀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		init
		{
			_FF00_FF00_FF00_FF00_FF00_FF00退(value);
		}
	}

	private static object DecorateDynamicModule;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EntitySocks5(string Address, int Port, EntitySocks5Account? Account = null)
	{
		//IL_004a: Expected I4, but got Obj
		//IL_0038->IL0041: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		EntitySocks5 entitySocks = this;
		if (false)
		{
			entitySocks = (EntitySocks5)0;
		}
		switch ((int)entitySocks)
		{
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe static EntitySocks5? Parse(string? format)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 78, 1790778653, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778653, new IntPtr(2737367920284L), 15);
		}
		return (EntitySocks5?)((delegate*<object, object>)obj)(format);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	public override string ToString()
	{
		return (string)_FF00_FF00_FF00_FF00_FF00_FF00鴀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	protected virtual bool PrintMembers(StringBuilder builder)
	{
		return _FF00_FF00_FF00_FF00_FF00_FF00謀(builder) != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	public override int GetHashCode()
	{
		return (int)_FF00_FF00_FF00_FF00_FF00_FF00鸀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	public virtual bool Equals(EntitySocks5? other)
	{
		return _FF00_FF00_FF00_FF00_FF00_FF00鐀(other) != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	protected EntitySocks5(EntitySocks5 original)
	{
		//IL_0012: Expected Obj, but got I4
		//IL_0035: Expected I4, but got Obj
		//IL_0049->IL0020: Incompatible stack heights: 4 vs 2
		//IL_0059->IL0020: Incompatible stack heights: 3 vs 2
		//IL_0074->IL0020: Incompatible stack heights: 3 vs 2
		//IL_0064->IL0020: Incompatible stack heights: 3 vs 2
		//IL_007f->IL0020: Incompatible stack heights: 3 vs 2
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 2;
		while (true)
		{
			switch ((int)obj)
			{
			case 1:
				return;
			default:
				_ = 3;
				break;
			case 2:
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			case 3:
				if (1 == 0)
				{
					_ = 1;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	public unsafe void Deconstruct(out string Address, out int Port, out EntitySocks5Account? Account)
	{
		_FF00_FF00_FF00_FF00_FF00_FF00舀((nint)Unsafe.AsPointer(ref Address), (nint)Unsafe.AsPointer(ref Port), (nint)Unsafe.AsPointer(ref Account));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ReflectConcreteEvent()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static EntitySocks5 DecorateConnectedWrapper()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00_FF00_FF00_FF00缀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778652, new IntPtr(2737367921324L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint _FF00_FF00_FF00_FF00_FF00_FF00耀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (uint)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00脀(nint P_0, nint P_1, nint P_2)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778655, new IntPtr(2737367899484L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00舀(nint P_0, nint P_1, nint P_2)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_0061: Expected I4, but got Obj
		//IL_0052->IL0019: Incompatible stack heights: 0 vs 1
		//IL_006d->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0041->IL0019: Incompatible stack types: I4 vs Obj
		//IL_005d->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0078->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 3;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				return;
			case 3:
				Unsafe.Write((void*)P_0, this);
				obj2 = 2;
				break;
			case 0:
				return;
			case 1:
				Unsafe.Write((void*)P_2, this);
				if (false)
				{
					obj2 = 0;
				}
				break;
			case 2:
				*(int*)P_1 = (int)this;
				if (1 == 0)
				{
					obj2 = 1;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00茀(nint P_0, nint P_1, nint P_2)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778654, new IntPtr(2737367926524L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00萀(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778649, new IntPtr(2737367921324L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FF00_FF00蔀(object P_0, object P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_0070: Expected I4, but got Obj
		//IL_0045->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0085->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0050->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 3;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 2:
				if (P_0 == null)
				{
					if (false)
					{
						obj2 = 1;
					}
					break;
				}
				goto default;
			default:
				return (byte)(int)P_1;
			case 1:
				return 0;
			case 3:
				if (P_0 == P_1)
				{
					return 1;
				}
				obj2 = 2;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00蘀(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778648, new IntPtr(2737367921324L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00蜀(object P_0)
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
	protected byte _FF00_FF00_FF00_FF00_FF00_FF00謀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_003e: Expected I4, but got Obj
		//IL_00c5->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0088->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0095->IL0019: Incompatible stack types: I4 vs Obj
		//IL_006f->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00a5->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00e1->IL0019: Incompatible stack types: I4 vs Obj
		//IL_007a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_005f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00b0->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 4;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 6:
				obj2 = P_0;
				if (2 == 0)
				{
					obj2 = 7;
				}
				break;
			case 5:
				if (2 == 0)
				{
					obj2 = 1;
				}
				break;
			case 3:
				obj2 = 6;
				break;
			case 1:
				return 1;
			case 4:
				obj2 = 3;
				break;
			case 7:
				if (false)
				{
					obj2 = 0;
				}
				break;
			default:
				obj = this;
				_ = ref obj;
				_ = 5;
				break;
			case 2:
				obj2 = P_0;
				if (1 == 0)
				{
					obj2 = 1;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00谀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778651, new IntPtr(2737367921324L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FF00_FF00贀(object P_0, object P_1)
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (P_1 == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00踀(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778650, new IntPtr(2737367928604L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_FF00輀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00退(object P_0)
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
	internal object _FF00_FF00_FF00_FF00_FF00_FF00鄀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00鈀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778645, new IntPtr(2737367922364L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00錀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778644, new IntPtr(2737367921324L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00_FF00_FF00_FF00_FF00鐀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_003e: Expected I4, but got Obj
		//IL_00ec: Expected I4, but got Obj
		//IL_00be->IL00ec: Incompatible stack heights: 1 vs 0
		//IL_004e->IL00e5: Incompatible stack heights: 1 vs 0
		//IL_009c->IL00b3: Incompatible stack heights: 1 vs 0
		//IL_00e5->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0076->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00d5->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0065->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00b3->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 6;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 2:
				obj2 = this;
				if (P_0 == null)
				{
					if (0 == 0)
					{
						obj2 = 0;
					}
					break;
				}
				goto case 3;
			case 6:
				if (this == P_0)
				{
					return 1;
				}
				obj2 = 5;
				break;
			case 7:
				obj2 = this;
				if (P_0 == null)
				{
					if (true)
					{
						obj2 = 4;
					}
					break;
				}
				goto case 1;
			case 1:
				obj2 = this;
				if (P_0 != null)
				{
					if (2 != 0)
					{
						obj2 = 2;
					}
					break;
				}
				goto default;
			case 5:
				if (P_0 != null)
				{
					obj2 = 7;
					break;
				}
				goto default;
			case 3:
				return (byte)(int)P_0;
			default:
				return 0;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FF00_FF00销()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00阀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778647, new IntPtr(2737367929644L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00_FF00_FF00_FF00_FF00需(object P_0)
	{
		//IL_000c: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_FF00頀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00餀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778646, new IntPtr(2737367921324L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00騀(uint P_0)
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00鬀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778641, new IntPtr(2737367921324L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00鴀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 10373, 1790778640, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778640, new IntPtr(2737367899484L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint _FF00_FF00_FF00_FF00_FF00_FF00鸀()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected I4, but got Unknown
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (uint)(((this * -1521134295 + this) * -1521134295 + this) * -1521134295 + this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00_FF00_FF00_FF00鼀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778643, new IntPtr(2737367921324L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected object _FF00_FF00_FF00_FF00_FF00_FF00ꀀ()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_000a: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FF00_FF00ꄀ()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00ꐀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778642, new IntPtr(2737367924444L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00ꔀ(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0076: Expected I4, but got Obj
		//IL_020c: Expected Obj, but got I4
		//IL_01cd: Expected Obj, but got I4
		//IL_0245: Expected Obj, but got I4
		//IL_00d4: Expected Obj, but got I4
		//IL_0138: Expected Obj, but got I4
		//IL_0141: Expected Obj, but got I4
		//IL_0216->IL0019: Incompatible stack heights: 3 vs 1
		//IL_01b7->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0156->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01d7->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00a1->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0251->IL0019: Incompatible stack heights: 2 vs 1
		//IL_01c7->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01e4->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00e0->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0146->IL0015: Incompatible stack heights: 2 vs 0
		//IL_026e->IL0019: Incompatible stack heights: 0 vs 1
		//IL_028d->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0101->IL0019: Incompatible stack heights: 0 vs 1
		//IL_008f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_023b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00ac->IL0019: Incompatible stack types: I4 vs Obj
		//IL_025c->IL0019: Incompatible stack heights: 2 vs 1
		//IL_01f7->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00eb->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00ca->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0279->IL0019: Incompatible stack types: I4 vs Obj
		//IL_012f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0298->IL0019: Incompatible stack types: I4 vs Obj
		//IL_010c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0202->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 2;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 8:
				case 10:
					if (((Array)obj).Length == 2)
					{
						obj2 = 14;
						continue;
					}
					goto case 19;
				case 12:
					obj = ((object[])obj)[0];
					if (3 != 0)
					{
						obj2 = 4;
					}
					continue;
				case 21:
					obj2 = obj;
					obj = obj;
					if (8 == 0)
					{
						obj2 = 4;
					}
					continue;
				case 20:
					_ = ((object[])obj)[1];
					_ = 58;
					obj = 0;
					if (3 != 0)
					{
						_ = 1;
					}
					continue;
				case 7:
					if (((Array)obj).Length == 2)
					{
						if (6 != 0)
						{
							obj2 = 12;
						}
						continue;
					}
					goto case 19;
				case 5:
					obj2 = ((object[])obj)[1];
					if (&obj == null)
					{
						if (2 == 0)
						{
							obj2 = 17;
						}
						continue;
					}
					return obj;
				case 1:
					return null;
				case 4:
					obj = ((object[])obj)[1];
					obj2 = 21;
					continue;
				case 3:
				case 16:
					obj = null;
					obj2 = 18;
					continue;
				case 14:
					obj = ((object[])obj)[0];
					obj2 = 5;
					continue;
				case 9:
					obj = ((Array)obj).Length;
					obj2 = 6;
					continue;
				case 15:
					obj = null;
					obj2 = 9;
					continue;
				case 18:
					if (obj == null)
					{
						if (10 != 0)
						{
							obj2 = 1;
						}
						continue;
					}
					goto case 7;
				default:
					_ = ((object[])obj)[0];
					_ = 58;
					obj = 0;
					_ = 20;
					continue;
				case 17:
					throw ((object[])obj)[1];
				case 19:
					throw /*Error near IL_0229: Stack underflow*/;
				case 11:
					if ((nint)obj != 2)
					{
						obj2 = 19;
						continue;
					}
					goto default;
				case 13:
					_ = ((object[])obj)[0];
					_ = 58;
					obj = 0;
					if (8 == 0)
					{
						_ = 16;
					}
					continue;
				case 2:
					break;
				case 6:
					if ((nint)obj != 1)
					{
						if (11 != 0)
						{
							obj2 = 5;
						}
						continue;
					}
					goto case 13;
				}
				if (P_0 != null)
				{
					break;
				}
				if (1 == 0)
				{
					obj2 = 0;
				}
			}
			_ = 64;
			obj = 0;
			obj = 15;
		}
	}
}
