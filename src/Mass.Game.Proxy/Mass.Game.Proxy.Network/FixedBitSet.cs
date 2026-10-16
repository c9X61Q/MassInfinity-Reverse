using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Mass.Game.Proxy.Network;

public class FixedBitSet
{
	private readonly object _data;

	internal static FixedBitSet ReflectConcreteComparator;

	public int Length
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (int)_FF00_FF00_FF00_FF00瘀();
		}
	}

	public int ByteLength
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (int)_FF00_FF00_FF00_FF00稀();
		}
	}

	public ReadOnlyMemory<byte> Data
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00_FF00栀();
		}
	}

	public bool this[int index]
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00_FF00眀((uint)index) != 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00_FF00爀((uint)index, value ? ((byte)1) : ((byte)0));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FixedBitSet(int bitLength)
	{
		//IL_003e: Expected I4, but got Obj
		//IL_0020->IL0029: Incompatible stack types: I4 vs Obj
		//IL_0071->IL0029: Incompatible stack heights: 3 vs 1
		//IL_0081->IL0029: Incompatible stack heights: 3 vs 1
		//IL_0056->IL0029: Incompatible stack heights: 0 vs 1
		//IL_0061->IL0029: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		FixedBitSet fixedBitSet = this;
		if (0 == 0)
		{
			fixedBitSet = (FixedBitSet)0;
		}
		while (true)
		{
			switch ((int)fixedBitSet)
			{
			case 2:
				return;
			case 3:
				_ = 2;
				continue;
			case 1:
				throw /*Error near IL_0074: Stack underflow*/;
			}
			if (bitLength <= 0)
			{
				if (false)
				{
					fixedBitSet = (FixedBitSet)1;
				}
			}
			else
			{
				_ = 3;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FixedBitSet(byte[] data, int bitLength)
	{
		//IL_0074: Expected Obj, but got I4
		//IL_0059->IL001c: Incompatible stack heights: 4 vs 2
		//IL_0064->IL001c: Incompatible stack heights: 4 vs 2
		//IL_001c->IL001c: Incompatible stack heights: 4 vs 2
		//IL_00c6->IL001c: Incompatible stack heights: 1 vs 2
		//IL_00d1->IL001c: Incompatible stack heights: 1 vs 2
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		int num = 4;
		while (true)
		{
			switch (num)
			{
			case 5:
				if (1 == 0)
				{
					_ = 0;
				}
				break;
			default:
				throw this;
			case 3:
			{
				object obj = 5;
				break;
			}
			case 6:
				throw this;
			case 7:
				if (data == null)
				{
					if (2 == 0)
					{
						_ = 0;
					}
					break;
				}
				if (data.Length >= bitLength)
				{
					num = 3;
					break;
				}
				goto default;
			case 1:
				return;
			case 2:
				throw this;
			case 4:
				if (bitLength > 0)
				{
					num = 7;
					break;
				}
				goto case 6;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		return (string)_FF00_FF00_FF00_FF00怀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public byte[] ToArray()
	{
		return (byte[])_FF00_FF00_FF00_FF00漀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int FixedBitSetLength(int bitLength)
	{
		return (int)_FF00_FF00_FF00_FF00挀((uint)bitLength);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool QueryPredictor()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static FixedBitSet SolveInterpreter()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00开()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778050, new IntPtr(2737368327708L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00怀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 7762, 1790778077, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778077, new IntPtr(2737368312108L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00愀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778076, new IntPtr(2737368314188L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static uint _FF00_FF00_FF00_FF00戀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778079, new IntPtr(2737368326668L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static uint _FF00_FF00_FF00_FF00挀(uint P_0)
	{
		return (uint)((int)(P_0 + 7) / 8);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static uint _FF00_FF00_FF00_FF00搀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778078, new IntPtr(2737368304828L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal ReadOnlyMemory<byte> _FF00_FF00_FF00_FF00栀()
	{
		//IL_000b: Expected VT, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (ReadOnlyMemory<byte>)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00椀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778073, new IntPtr(2737368322508L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00樀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00欀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778072, new IntPtr(2737368306908L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private object _FF00_FF00_FF00_FF00氀(uint P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		//IL_0057->IL002f: Incompatible stack heights: 1 vs 0
		//IL_006e->IL0019: Incompatible stack types: I4 vs Obj
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
				return (object)/*Error near IL_0031: Stack underflow*/;
			default:
				return (object)/*Error near IL_0033: Stack underflow*/;
			case 1:
				obj2 = this;
				if (P_0 != 0)
				{
					if (0 == 0)
					{
						obj2 = 0;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00洀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778075, new IntPtr(2737368304828L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00渀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778074, new IntPtr(2737368313148L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00漀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00瀀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778069, new IntPtr(2737368325628L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00爀(uint P_0, byte P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0042: Expected I4, but got Obj
		//IL_00b2: Expected Obj, but got I4
		//IL_0089: Expected native int or pointer, but got Obj
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected native int or pointer, but got Obj
		//IL_004f: Expected Obj, but got I4
		//IL_011c: Expected native int or pointer, but got Obj
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected native int or pointer, but got Obj
		//IL_00be->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0078->IL0019: Incompatible stack heights: 0 vs 1
		//IL_005b->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0115->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00dc->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00c9->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00ac->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0083->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0066->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00e7->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0140->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 2;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 4:
				throw /*Error near IL_004a: Stack underflow*/;
			default:
				if (P_1 == 0)
				{
					if (8 == 0)
					{
						obj2 = 8;
					}
					break;
				}
				goto case 7;
			case 7:
			{
				obj2 = this;
				object obj4 = obj;
				*(byte*)(nint)obj4 = (byte)(*(byte*)(nint)obj4 | (byte)(1 << (int)obj));
				if (2 != 0)
				{
					obj2 = 6;
				}
				break;
			}
			case 3:
				return;
			case 5:
				obj = (int)P_0 % 8;
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			case 2:
				if ((int)P_0 >= 0)
				{
					if (true)
					{
						obj2 = 0;
					}
					break;
				}
				goto case 4;
			case 1:
				if ((int)P_0 >= (nint)this)
				{
					obj2 = 4;
					break;
				}
				obj = (int)P_0 / 8;
				if (4 != 0)
				{
					obj2 = 5;
				}
				break;
			case 6:
				return;
			case 8:
			{
				obj2 = this;
				object obj3 = obj;
				*(byte*)(nint)obj3 = (byte)(*(byte*)(nint)obj3 & (byte)(~(1 << (int)obj)));
				if (3 == 0)
				{
					obj2 = 0;
				}
				break;
			}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00猀(uint P_0, byte P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778068, new IntPtr(2737368324588L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00琀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778071, new IntPtr(2737368304828L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00甀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint _FF00_FF00_FF00_FF00瘀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (uint)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00_FF00_FF00眀(uint P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_008d: Expected Obj, but got I4
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected Obj, but got I4
		//IL_0097->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0088->IL0019: Incompatible stack types: I4 vs Obj
		//IL_004f->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00bb->IL0019: Incompatible stack heights: 0 vs 1
		//IL_005a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00c6->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 5;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 1:
				if ((int)P_0 >= (nint)this)
				{
					if (0 == 0)
					{
						obj2 = 0;
					}
				}
				else
				{
					obj = (int)P_0 / 8;
					obj2 = 2;
				}
				break;
			default:
				throw /*Error near IL_0079: Stack underflow*/;
			case 2:
				obj = (int)P_0 % 8;
				obj2 = 3;
				break;
			case 3:
				return ((((byte[])(object)this)[obj] & (1 << (int)obj)) != 0) ? ((byte)1) : ((byte)0);
			case 5:
				if ((int)P_0 < 0)
				{
					if (4 != 0)
					{
						obj2 = 2;
					}
					break;
				}
				goto case 1;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00砀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778070, new IntPtr(2737368301708L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00_FF00礀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778065, new IntPtr(2737368319388L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint _FF00_FF00_FF00_FF00稀()
	{
		//IL_000b: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (uint)(int)this;
	}
}
