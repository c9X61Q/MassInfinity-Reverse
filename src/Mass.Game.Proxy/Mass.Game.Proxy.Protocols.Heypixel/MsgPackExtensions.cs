using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using MsgPack;

namespace Mass.Game.Proxy.Protocols.Heypixel;

public static class MsgPackExtensions
{
	private static object ReflectMonoContext;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string ReadString(this Unpacker unpacker)
	{
		return (string)_FF00_FF00_FF00_FF00쀀(unpacker);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Guid ReadGuid(this Unpacker unpacker, bool encrypt = false)
	{
		return MsgPackExtensions._FF00_FF00_FF00_FF00_FFFD((object)unpacker, encrypt ? ((byte)1) : ((byte)0));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static long ReadInt64(this Unpacker unpacker)
	{
		return _FF00_FF00_FF00_FF00툀(unpacker);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int ReadInt32(this Unpacker unpacker)
	{
		return (int)_FF00_FF00_FF00_FF00뼀(unpacker);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void WriteString(this Packer packer, string value)
	{
		_FF00_FF00_FF00_FF00묀(packer, value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void WriteEncrypted(this Packer packer, Guid password, string value)
	{
		_FF00_FF00_FF00_FF00팀(packer, password, value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void WriteGuid(this Packer packer, Guid value, bool encrypt = false)
	{
		_FF00_FF00_FF00_FF00쬀(packer, value, encrypt ? ((byte)1) : ((byte)0));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void WriteInt64(this Packer packer, long value)
	{
		_FF00_FF00_FF00_FF00준(packer, value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void WriteUInt64(this Packer packer, ulong value)
	{
		MsgPackExtensions._FF00_FF00_FF00_FF00_FFFD((object)packer, value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void WriteUInt16(this Packer packer, ushort value)
	{
		_FF00_FF00_FF00_FF00픀(packer, value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void WriteDouble(this Packer packer, double value)
	{
		_FF00_FF00_FF00_FF00숀(packer, value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void WriteFloat(this Packer packer, float value)
	{
		_FF00_FF00_FF00_FF00씀(packer, value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void WriteBool(this Packer packer, bool value)
	{
		_FF00_FF00_FF00_FF00봀(packer, value ? ((byte)1) : ((byte)0));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void WriteUInt32(this Packer packer, uint value)
	{
		_FF00_FF00_FF00_FF00휀(packer, value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void WriteInt32(this Packer packer, int value)
	{
		_FF00_FF00_FF00_FF00퀀(packer, (uint)value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void WriteByte(this Packer packer, byte value)
	{
		_FF00_FF00_FF00_FF00촀(packer, value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void WriteArrayLength(this Packer packer, int length)
	{
		_FF00_FF00_FF00_FF00윀(packer, (uint)length);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void WriteArray<T>(this Packer packer, T[] value)
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void WriteDictionary<TKey, TValue>(this Packer packer, Dictionary<TKey, TValue> value) where TKey : notnull
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DecorateOrderedMapper()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static MsgPackExtensions ReflectVisualPolicy()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00_FF00_FF00_FF00먀(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778544, new IntPtr(2737367937964L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void _FF00_FF00_FF00_FF00묀(object P_0, object P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_0046->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
				obj2 = P_0;
				if (false)
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
	internal unsafe static void _FF00_FF00_FF00_FF00밀(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778547, new IntPtr(2737367937964L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void _FF00_FF00_FF00_FF00봀(object P_0, byte P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_0047->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
				obj2 = P_0;
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00_FF00_FF00_FF00븀(object P_0, byte P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778546, new IntPtr(2737367937964L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static uint _FF00_FF00_FF00_FF00뼀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_007d: Expected Obj, but got Ref
		//IL_0047->IL0019: Incompatible stack heights: 0 vs 1
		//IL_006d->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0052->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0078->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0089->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0094->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 3:
				return (uint)(&obj);
			case 1:
				obj = P_0;
				if (false)
				{
					obj2 = 0;
				}
				continue;
			case 2:
				throw /*Error near IL_007a: Stack underflow*/;
			}
			if (&obj == null)
			{
				if (2 != 0)
				{
					obj2 = 2;
				}
				continue;
			}
			obj = (object)(&obj);
			if (false)
			{
				obj2 = 3;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00쀀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 9898, 1790778509, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778509, new IntPtr(2737367941084L), 15);
		}
		return ((delegate*<object, object>)obj)(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00섀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778508, new IntPtr(2737367942124L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void _FF00_FF00_FF00_FF00숀(object P_0, double P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_0047->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
				obj2 = P_0;
				if (false)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00_FF00_FF00_FF00쌀(object P_0, double P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778511, new IntPtr(2737367937964L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00_FF00_FF00_FF00쐀(object P_0, float P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778510, new IntPtr(2737367937964L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void _FF00_FF00_FF00_FF00씀(object P_0, float P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_0047->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
				obj2 = P_0;
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00_FF00_FF00_FF00였(object P_0, float P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778505, new IntPtr(2737367942124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void _FF00_FF00_FF00_FF00윀(object P_0, uint P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_0046->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
				obj2 = P_0;
				if (false)
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
	internal unsafe static void _FF00_FF00_FF00_FF00저(object P_0, uint P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778504, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void _FF00_FF00_FF00_FF00준(object P_0, long P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_0047->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
				obj2 = P_0;
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void _FF00_FF00_FF00_FF00쬀(object P_0, Guid P_1, byte P_2)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_007d: Expected Obj, but got VT
		//IL_0080: Expected Obj, but got VT
		//IL_0059->IL0019: Incompatible stack heights: 11 vs 1
		//IL_008c->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0097->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00aa->IL0019: Incompatible stack heights: 2 vs 1
		//IL_006b->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00b5->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0076->IL0019: Incompatible stack types: I4 vs Obj
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
				_ = ref obj;
				_ = 3;
				_ = 2;
				_ = ref obj;
				_ = ref obj;
				_ = ref obj;
				_ = ref obj;
				_ = 4;
				break;
			case 3:
				if (P_2 != 0)
				{
					if (2 != 0)
					{
						obj2 = 1;
					}
					break;
				}
				_ = ref P_1;
				if (true)
				{
					_ = 0;
				}
				break;
			case 1:
				return;
			case 2:
			{
				Guid guid = P_1;
				obj = guid;
				obj = guid;
				if (false)
				{
					obj2 = 0;
				}
				break;
			}
			case 4:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00_FF00_FF00_FF00찀(object P_0, byte P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778507, new IntPtr(2737367937964L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void _FF00_FF00_FF00_FF00촀(object P_0, byte P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_0047->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
				obj2 = P_0;
				if (false)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00_FF00_FF00_FF00츀(object P_0, byte P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778506, new IntPtr(2737367937964L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00케()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void _FF00_FF00_FF00_FF00퀀(object P_0, uint P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_0046->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
				obj2 = P_0;
				if (false)
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
	internal unsafe static void _FF00_FF00_FF00_FF00턀(object P_0, uint P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778501, new IntPtr(2737367937964L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static long _FF00_FF00_FF00_FF00툀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_007d: Expected Obj, but got Ref
		//IL_0086: Expected Obj, but got I4
		//IL_0047->IL0019: Incompatible stack heights: 0 vs 1
		//IL_006d->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0052->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0078->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 3:
					return (nint)(&obj);
				case 1:
					obj = P_0;
					if (0 == 0)
					{
						obj2 = 0;
					}
					continue;
				default:
					if (&obj != null)
					{
						break;
					}
					if (2 != 0)
					{
						obj2 = 2;
					}
					continue;
				case 2:
					throw /*Error near IL_007a: Stack underflow*/;
				}
				break;
			}
			obj = (object)(&obj);
			obj = 3;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void _FF00_FF00_FF00_FF00팀(object P_0, Guid P_1, object P_2)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_003d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0048->IL0019: Incompatible stack heights: 2 vs 1
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
	internal unsafe static void _FF00_FF00_FF00_FF00퐀(object P_0, Guid P_1, object P_2)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778500, new IntPtr(2737367937964L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void _FF00_FF00_FF00_FF00픀(object P_0, ushort P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_0047->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
				obj2 = P_0;
				if (false)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00_FF00_FF00_FF00혀(object P_0, ushort P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778503, new IntPtr(2737367937964L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void _FF00_FF00_FF00_FF00휀(object P_0, uint P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_0047->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
				obj2 = P_0;
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static Guid _FF00_FF00_FF00_FF00_FFFD(object P_0, byte P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778502, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		return (Guid)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Guid _FF00_FF00_FF00_FF00_FFFD(object P_0, byte P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_002f: Expected VT, but got Obj
		//IL_0033: Expected VT, but got Obj
		//IL_0045->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0050->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				return (Guid)P_0;
			case 1:
				if (P_1 == 0)
				{
					return (Guid)P_0;
				}
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FFFD()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778497, new IntPtr(2737367937964L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FFFD()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00_FF00_FF00_FF00_FFFD(object P_0, ulong P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778496, new IntPtr(2737367942124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void _FF00_FF00_FF00_FF00_FFFD(object P_0, ulong P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_0047->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
				obj2 = P_0;
				if (false)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}
}
