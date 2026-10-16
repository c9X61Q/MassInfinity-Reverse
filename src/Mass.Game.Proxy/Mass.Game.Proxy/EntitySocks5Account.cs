using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

namespace Mass.Game.Proxy;

public record EntitySocks5Account
{
	[CompilerGenerated]
	protected virtual Type EqualityContract
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (Type)_FF00_FF00_FF00_FF00_FF00_FF00쀀();
		}
	}

	public string Username
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00_FF00_FF00_FF00_FF00관();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		init
		{
			_FF00_FF00_FF00_FF00_FF00_FF00됀(value);
		}
	}

	public string Password
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00_FF00_FF00_FF00_FF00_AB00();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		init
		{
			_FF00_FF00_FF00_FF00_FF00_FF00뜀(value);
		}
	}

	private static object AttachElement;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EntitySocks5Account(string Username, string Password)
	{
		//IL_0042: Expected I4, but got Obj
		//IL_0030->IL0039: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		EntitySocks5Account entitySocks5Account = this;
		if (0 == 0)
		{
			entitySocks5Account = (EntitySocks5Account)0;
		}
		switch ((int)entitySocks5Account)
		{
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	public override string ToString()
	{
		return (string)_FF00_FF00_FF00_FF00_FF00_FF00봀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	protected virtual bool PrintMembers(StringBuilder builder)
	{
		return _FF00_FF00_FF00_FF00_FF00_FF00넀(builder) != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	public override int GetHashCode()
	{
		return (int)_FF00_FF00_FF00_FF00_FF00_FF00씀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	public virtual bool Equals(EntitySocks5Account? other)
	{
		return _FF00_FF00_FF00_FF00_FF00_FF00눀(other) != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	protected EntitySocks5Account(EntitySocks5Account original)
	{
		//IL_003a: Expected I4, but got Obj
		//IL_0020->IL0029: Incompatible stack types: I4 vs Obj
		//IL_004f->IL0029: Incompatible stack heights: 2 vs 1
		//IL_006a->IL0029: Incompatible stack heights: 2 vs 1
		//IL_005a->IL0029: Incompatible stack heights: 2 vs 1
		//IL_0075->IL0029: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		EntitySocks5Account entitySocks5Account = this;
		if (0 == 0)
		{
			entitySocks5Account = (EntitySocks5Account)0;
		}
		while (true)
		{
			switch ((int)entitySocks5Account)
			{
			default:
				if (2 == 0)
				{
					_ = 2;
				}
				break;
			case 2:
				if (1 == 0)
				{
					_ = 1;
				}
				break;
			case 1:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	public unsafe void Deconstruct(out string Username, out string Password)
	{
		_FF00_FF00_FF00_FF00_FF00_FF00쌀((nint)Unsafe.AsPointer(ref Username), (nint)Unsafe.AsPointer(ref Password));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ReflectScopePolicy()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static EntitySocks5Account RunWriter()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00ꘀ(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778674, new IntPtr(2737367919244L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FF00_FF00_A700(object P_0, object P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_0071: Expected I4, but got Obj
		//IL_0085->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0046->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0051->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 1:
				if (P_0 != P_1)
				{
					if (0 == 0)
					{
						obj2 = 0;
					}
					break;
				}
				return 1;
			case 2:
				return (byte)(int)P_1;
			case 3:
				return 0;
			default:
				if (P_0 == null)
				{
					obj2 = 3;
					break;
				}
				goto case 2;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00ꠀ(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778637, new IntPtr(2737367919244L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FF00_FF00꤀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00ꨀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778636, new IntPtr(2737367919244L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_FF00_AB00()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00가()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778639, new IntPtr(2737367919244L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_FF00관()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00뀀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778638, new IntPtr(2737367919244L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected byte _FF00_FF00_FF00_FF00_FF00_FF00넀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0048: Expected Obj, but got I4
		//IL_005d->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00af->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00a2->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0086->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0068->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00ba->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
				case 1:
					break;
				case 3:
					if (false)
					{
						obj2 = 0;
					}
					continue;
				case 5:
					return 1;
				case 2:
					obj2 = P_0;
					if (3 == 0)
					{
						obj2 = 5;
					}
					continue;
				default:
					obj2 = P_0;
					if (0 == 0)
					{
						obj2 = 1;
					}
					continue;
				case 4:
					if (3 == 0)
					{
						obj2 = 2;
					}
					continue;
				}
				break;
			}
			obj = 2;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00_FF00_FF00_FF00_FF00눀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_003a: Expected I4, but got Obj
		//IL_0072: Expected I4, but got Obj
		//IL_00cf->IL0087: Incompatible stack heights: 1 vs 0
		//IL_0092->IL006b: Incompatible stack heights: 1 vs 0
		//IL_0051->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0087->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00e6->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00a9->IL0019: Incompatible stack types: I4 vs Obj
		//IL_005c->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 5;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 4:
				if (P_0 != null)
				{
					if (0 == 0)
					{
						obj2 = 0;
					}
					break;
				}
				goto case 1;
			case 3:
				return (byte)(int)P_0;
			case 1:
			case 6:
				return 0;
			case 5:
				if (this == P_0)
				{
					return 1;
				}
				obj2 = 4;
				break;
			case 2:
				obj2 = this;
				if (P_0 == null)
				{
					if (1 == 0)
					{
						obj2 = 0;
					}
					break;
				}
				goto case 3;
			default:
				obj2 = this;
				if (P_0 == null)
				{
					if (6 != 0)
					{
						obj2 = 6;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00대(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778633, new IntPtr(2737367919244L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00됀(object P_0)
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
				if (false)
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00딀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778632, new IntPtr(2737367925484L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00똀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778635, new IntPtr(2737367927564L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00뜀(object P_0)
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00렀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778634, new IntPtr(2737367919244L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00뤀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778629, new IntPtr(2737367921324L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FF00_FF00먀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00묀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778628, new IntPtr(2737367919244L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00봀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 10405, 1790778631, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778631, new IntPtr(2737367919244L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00븀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778630, new IntPtr(2737367897404L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_FF00뼀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected object _FF00_FF00_FF00_FF00_FF00_FF00쀀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_000a: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00섀(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778625, new IntPtr(2737367920284L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FF00_FF00숀(object P_0, object P_1)
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (P_1 == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00쌀(nint P_0, nint P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		//IL_005b->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0040->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0066->IL0019: Incompatible stack types: I4 vs Obj
		//IL_004b->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 2:
				return;
			case 1:
				Unsafe.Write((void*)P_0, this);
				if (false)
				{
					obj2 = 0;
				}
				break;
			default:
				Unsafe.Write((void*)P_1, this);
				if (2 == 0)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00쐀(nint P_0, nint P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778624, new IntPtr(2737367920284L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint _FF00_FF00_FF00_FF00_FF00_FF00씀()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected I4, but got Unknown
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (uint)((this * -1521134295 + this) * -1521134295 + this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00_FF00_FF00_FF00였()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778627, new IntPtr(2737367923404L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00_FF00_FF00_FF00_FF00윀(object P_0)
	{
		//IL_000c: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00저(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778626, new IntPtr(2737367929644L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}
}
