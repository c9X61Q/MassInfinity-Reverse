using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using DotNetty.Buffers;

namespace Mass.Game.Proxy.Network;

public static class VarInt
{
	internal static VarInt DecorateOperationalParameter;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetByteSize(int input)
	{
		return (int)_FF00_FF00_FF00_FF00_2B00((uint)input);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool HasContinuationBit(byte input)
	{
		return _FF00_FF00_FF00_FF00_2900(input) != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int ReadVarInt(this IByteBuffer buffer)
	{
		return (int)_FF00_FF00_FF00_FF00_2F00(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int ReadVarInt(byte[] buffer)
	{
		return (int)_FF00_FF00_FF00_FF00_3100(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IByteBuffer WriteVarInt(this IByteBuffer buffer, int input)
	{
		return (IByteBuffer)_FF00_FF00_FF00_FF00_2500(buffer, (uint)input);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CheckVirtualGateway()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static VarInt ReflectIdentifiableProfiler()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_2400(object P_0, uint P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776608, new IntPtr(2737368306908L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_2500(object P_0, uint P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_003a: Expected I4, but got Obj
		//IL_0050->IL0019: Incompatible stack heights: 0 vs 1
		//IL_005b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00c4->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0076->IL0019: Incompatible stack types: I4 vs Obj
		//IL_009c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00cf->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 6;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 1:
				P_1 >>= 7;
				if (3 != 0)
				{
					obj2 = 1;
				}
				break;
			case 4:
				obj2 = P_0;
				if (2 != 0)
				{
					obj2 = 1;
				}
				break;
			case 2:
				return P_0;
			default:
				obj2 = P_0;
				_ = (P_1 & 0x7F) | 0x80;
				if (1 == 0)
				{
					obj2 = 1;
				}
				break;
			case 3:
			case 6:
				if ((P_1 & 0xFFFFFF80u) != 0)
				{
					if (0 == 0)
					{
						obj2 = 0;
					}
					break;
				}
				goto case 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_2600(object P_0, uint P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776611, new IntPtr(2737368304828L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_2700()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_2800()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776610, new IntPtr(2737368320428L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_2900(byte P_0)
	{
		return ((P_0 & 0x80) == 128) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_2A00(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776637, new IntPtr(2737368306908L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static uint _FF00_FF00_FF00_FF00_2B00(uint P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0054: Expected Obj, but got I4
		//IL_006e: Expected I4, but got Obj
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got I4
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected Obj, but got Unknown
		//IL_0060->IL0019: Incompatible stack heights: 0 vs 1
		//IL_006b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0080->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00b8->IL0019: Incompatible stack heights: 0 vs 1
		//IL_008b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00c3->IL0019: Incompatible stack types: I4 vs Obj
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
				default:
					if ((nint)obj < 5)
					{
						break;
					}
					goto end_IL_0019;
				case 2:
					obj = 1;
					if (1 == 0)
					{
						obj2 = 1;
					}
					continue;
				case 4:
					return (uint)(int)obj;
				case 3:
					return 5u;
				case 5:
					break;
				}
				if ((P_0 & (uint)(-1 << obj * 7)) != 0)
				{
					obj++;
					if (false)
					{
						obj2 = 0;
					}
				}
				else if (1 == 0)
				{
					obj2 = 4;
				}
				continue;
				end_IL_0019:
				break;
			}
			obj = 3;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static uint _FF00_FF00_FF00_FF00Ⰰ(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776636, new IntPtr(2737368318348L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static uint _FF00_FF00_FF00_FF00_2E00(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776639, new IntPtr(2737368313148L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static uint _FF00_FF00_FF00_FF00_2F00(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_003e: Expected I4, but got Obj
		//IL_009d: Expected I4, but got Obj
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected Obj, but got Unknown
		//IL_00dd: Expected Obj, but got I4
		//IL_0083: Expected Obj, but got I4
		//IL_00cf->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0066->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00e7->IL0019: Incompatible stack types: I4 vs Obj
		//IL_008f->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00f9->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00da->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0071->IL0019: Incompatible stack types: I4 vs Obj
		//IL_009a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00b4->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00bf->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 7;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 4:
			{
				object obj3 = obj;
				_003F val = obj & 0x7F;
				object obj4 = obj;
				obj = obj4 + 1;
				obj = obj3 | (val << ((obj4 * 7) & 0x1F));
				if (1 == 0)
				{
					obj2 = 0;
				}
				break;
			}
			case 7:
				obj = 0;
				if (4 != 0)
				{
					obj2 = 6;
				}
				break;
			case 3:
				return (uint)(int)obj;
			case 5:
				throw /*Error near IL_00a0: Stack underflow*/;
			default:
				obj = P_0;
				if (0 == 0)
				{
					obj2 = 4;
				}
				break;
			case 6:
				obj = 0;
				obj2 = 2;
				break;
			case 1:
				if ((nint)obj <= 5)
				{
					if (obj != null)
					{
						if (0 == 0)
						{
							obj2 = 0;
						}
						break;
					}
					goto case 3;
				}
				obj2 = 5;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static uint _FF00_FF00_FF00_FF00_3000(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776638, new IntPtr(2737368304828L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static uint _FF00_FF00_FF00_FF00_3100(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_004a: Expected I4, but got Obj
		//IL_00b1: Expected Obj, but got I4
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected Obj, but got Unknown
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected Obj, but got Unknown
		//IL_0071: Expected Obj, but got I4
		//IL_0141: Expected Obj, but got I4
		//IL_00e7: Expected I4, but got Obj
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got Unknown
		//IL_0095: Expected Obj, but got I4
		//IL_00bd->IL0019: Incompatible stack heights: 0 vs 1
		//IL_013e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_007d->IL0019: Incompatible stack heights: 0 vs 1
		//IL_014b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00c8->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0063->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0088->IL0019: Incompatible stack types: I4 vs Obj
		//IL_009f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00fb->IL0019: Incompatible stack types: I4 vs Obj
		//IL_006e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0112->IL0019: Incompatible stack heights: 0 vs 1
		//IL_011d->IL0019: Incompatible stack types: I4 vs Obj
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
				if ((nint)obj <= 5)
				{
					if (8 != 0)
					{
						obj2 = 4;
					}
					break;
				}
				goto case 1;
			case 5:
				obj = 0;
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			case 3:
				throw /*Error near IL_008a: Stack underflow*/;
			case 9:
			{
				object obj5 = obj;
				obj = obj5 + 1;
				obj = ((byte[])P_0)[obj5];
				obj2 = 4;
				break;
			}
			default:
				obj = 0;
				if (4 == 0)
				{
					obj2 = 10;
				}
				break;
			case 7:
				return (uint)(int)obj;
			case 10:
				if ((nint)obj < ((Array)P_0).Length)
				{
					obj2 = 9;
					break;
				}
				goto case 3;
			case 1:
				throw /*Error near IL_00fe: Stack underflow*/;
			case 8:
				if (obj == null)
				{
					if (4 == 0)
					{
						obj2 = 7;
					}
					break;
				}
				goto case 10;
			case 4:
			{
				object obj3 = obj;
				_003F val = obj & 0x7F;
				object obj4 = obj;
				obj = obj4 + 1;
				obj = obj3 | (val << ((obj4 * 7) & 0x1F));
				obj2 = 2;
				break;
			}
			case 6:
				obj = 0;
				obj2 = 5;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_3200()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_3300()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776633, new IntPtr(2737368313148L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}
}
