using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using DotNetty.Buffers;

namespace Mass.Game.Proxy.Network;

public static class VarLong
{
	internal static VarLong ReflectInterruptibleFactory;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static long ReadVarLong(this IByteBuffer buffer)
	{
		return _FF00_FF00_FF00_FF00_2100(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IByteBuffer WriteVarLong(this IByteBuffer buffer, long input)
	{
		return (IByteBuffer)_FF00_FF00_FF00_FF00Ḁ(buffer, input);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CheckCustomizableCompressor()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static VarLong CheckInternalResponder()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00ᴀ(object P_0, long P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776632, new IntPtr(2737368317308L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00Ḁ(object P_0, long P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_003a: Expected I4, but got Obj
		//IL_00ec->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00c7->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00d2->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0077->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00ab->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00b6->IL0019: Incompatible stack types: I4 vs Obj
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
				obj2 = P_0;
				_ = P_1;
				if (false)
				{
					obj2 = 0;
				}
				break;
			default:
				return P_0;
			case 2:
			case 6:
				if ((P_1 & -128) != 0L)
				{
					if (5 == 0)
					{
						obj2 = 5;
					}
					break;
				}
				goto case 4;
			case 3:
				P_1 >>>= 7;
				if (5 != 0)
				{
					obj2 = 6;
				}
				break;
			case 1:
			case 5:
				_ = (P_1 & 0x7F) | 0x80;
				_ = 3;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00ἀ()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long _FF00_FF00_FF00_FF00_2100(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_003e: Expected I4, but got Obj
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected Obj, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected Obj, but got Unknown
		//IL_0068: Expected Obj, but got I4
		//IL_00c1: Expected Obj, but got I8
		//IL_00ce: Expected I8, but got Obj
		//IL_0065->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00f1->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0074->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00cb->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00fc->IL0019: Incompatible stack types: I4 vs Obj
		//IL_007f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00e1->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00b2->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00bd->IL0019: Incompatible stack types: I4 vs Obj
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
			{
				object obj3 = obj;
				long num = obj & 0x7F;
				object obj4 = obj;
				obj = obj4 + 1;
				obj = obj3 | (num << obj4 * 7);
				obj2 = 7;
				continue;
			}
			case 2:
				obj = 0;
				if (1 == 0)
				{
					obj2 = 1;
				}
				continue;
			case 5:
				throw /*Error near IL_009e: Stack underflow*/;
			case 4:
				if (obj == null)
				{
					if (0 == 0)
					{
						obj2 = 6;
					}
					continue;
				}
				break;
			case 3:
				obj = 0;
				obj2 = 2;
				continue;
			case 6:
				return (long)obj;
			case 7:
				if ((nint)obj <= 10)
				{
					obj2 = 4;
					continue;
				}
				goto case 5;
			case 1:
				break;
			}
			obj = P_0;
			if (false)
			{
				obj2 = 0;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_2200()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776635, new IntPtr(2737368315228L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_2300()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}
}
