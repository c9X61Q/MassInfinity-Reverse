using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using DotNetty.Buffers;

namespace Mass.Game.Proxy.Network;

public static class Utf8String
{
	private static object ReplaceTransformer;

	private static int Utf8MaxBytes(int length)
	{
		return length * 4;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string ReadString(this IByteBuffer buffer, int max = 32767)
	{
		return (string)_FF00_FF00_FF00_FF00䌀(buffer, (uint)max);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IByteBuffer WriteString(this IByteBuffer buffer, string input, int max = 32767)
	{
		return (IByteBuffer)_FF00_FF00_FF00_FF00䔀(buffer, input, (uint)max);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool LoadMap()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Utf8String CheckFilteredStruct()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00䈀(object P_0, uint P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776618, new IntPtr(2737368307948L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00䌀(object P_0, uint P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0072: Expected I4, but got Obj
		//IL_00a4: Expected Obj, but got I4
		//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
		//IL_022b->IL0019: Incompatible stack heights: 4 vs 1
		//IL_0128->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00bd->IL0019: Incompatible stack heights: 3 vs 1
		//IL_01db->IL0019: Incompatible stack heights: 2 vs 1
		//IL_01eb->IL0019: Incompatible stack heights: 4 vs 1
		//IL_021b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0176->IL0019: Incompatible stack heights: 2 vs 1
		//IL_010e->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00a0->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0087->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00ae->IL0019: Incompatible stack types: I4 vs Ref
		//IL_0165->IL0019: Incompatible stack heights: 2 vs 1
		//IL_01cd->IL0019: Incompatible stack types: I4 vs Ref
		//IL_0202->IL0019: Incompatible stack types: Obj vs Ref
		//IL_0157->IL0019: Incompatible stack types: I4 vs Ref
		//IL_01a7->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0181->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0119->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0092->IL0019: Incompatible stack types: I4 vs Ref
		//IL_020d->IL0019: Incompatible stack types: I4 vs Ref
		//IL_01b2->IL0019: Incompatible stack types: I4 vs Ref
		//IL_0192->IL0019: Incompatible stack types: I4 vs Ref
		//IL_00d6->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00e1->IL0019: Incompatible stack types: I4 vs Ref
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 19;
		ref object reference = ref *(object*)obj;
		while (true)
		{
			switch ((uint)Unsafe.AsPointer(ref reference))
			{
			case 18u:
				obj = P_0;
				if (2 != 0)
				{
					reference = ref *(object*)11;
				}
				break;
			case 17u:
				_ = ref obj;
				_ = 16;
				break;
			case 19u:
				obj = P_1;
				reference = ref *(object*)18;
				break;
			case 4u:
				_ = ref obj;
				_ = 20;
				break;
			case 15u:
				throw ref obj;
			case 12u:
				if ((nint)obj < 0)
				{
					if (false)
					{
						reference = ref *(object*)1;
					}
				}
				else
				{
					obj = P_0;
					reference = ref *(object*)10;
				}
				break;
			case 16u:
				_ = ref obj;
				if (7 == 0)
				{
					_ = 4;
				}
				break;
			case 3u:
				_ = ref obj;
				_ = 6;
				break;
			case 10u:
				if (Unsafe.As<object, UIntPtr>(ref obj) <= Unsafe.As<object, UIntPtr>(ref obj))
				{
					reference = ref *(object*)8;
					break;
				}
				goto default;
			case 20u:
				_ = ref obj;
				_ = 3;
				break;
			case 14u:
				_ = ref obj;
				if (17 != 0)
				{
					_ = 15;
				}
				break;
			case 1u:
				throw /*Error near IL_0184: Stack underflow*/;
			case 11u:
				if (Unsafe.As<object, UIntPtr>(ref obj) <= Unsafe.As<object, UIntPtr>(ref obj))
				{
					if (12 == 0)
					{
						reference = ref *(object*)1;
					}
					break;
				}
				goto case 9u;
			case 2u:
				reference = ref obj;
				if (1 == 0)
				{
					reference = ref *(object*)14;
				}
				break;
			case 6u:
				_ = ref obj;
				_ = 15;
				break;
			case 9u:
				_ = ref obj;
				_ = 78;
				_ = 2;
				_ = 13;
				break;
			case 7u:
				throw ref obj;
			case 8u:
				obj = obj;
				reference = ref *(object*)P_0;
				if (2 != 0)
				{
					reference = ref *(object*)5;
				}
				break;
			case 13u:
				_ = ref obj;
				_ = 4;
				break;
			default:
				_ = ref obj;
				_ = 47;
				_ = 2;
				_ = 2;
				break;
			case 5u:
			{
				object obj2 = obj;
				if ((nint)obj2 > (int)P_1)
				{
					_ = ref obj;
					_ = 63;
					_ = 2;
					_ = ref obj;
					_ = ref obj;
					_ = ref obj;
					_ = ref obj;
					_ = ref obj;
					throw ref obj;
				}
				return obj2;
			}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00䔀(object P_0, object P_1, uint P_2)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_006a: Expected I4, but got Obj
		//IL_0094: Expected Obj, but got I4
		//IL_01b0: Expected Obj, but got I4
		//IL_0159: Expected Obj, but got I4
		//IL_00af: Expected Obj, but got I4
		//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
		//IL_01e0->IL0019: Incompatible stack heights: 3 vs 1
		//IL_009e->IL0019: Incompatible stack types: I4 vs Ref
		//IL_01b5->IL0015: Incompatible stack heights: 1 vs 0
		//IL_00c7->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0080->IL0019: Incompatible stack heights: 3 vs 1
		//IL_015e->IL0015: Incompatible stack heights: 1 vs 0
		//IL_01c7->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0090->IL0019: Incompatible stack heights: 4 vs 1
		//IL_010b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00e0->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00fb->IL0019: Incompatible stack types: I4 vs Ref
		//IL_01fb->IL0019: Incompatible stack types: I4 vs Ref
		//IL_00d2->IL0019: Incompatible stack heights: 2 vs 1
		//IL_01d2->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0197->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0131->IL0019: Incompatible stack types: I4 vs Ref
		//IL_0176->IL0019: Incompatible stack types: Obj vs Ref
		//IL_0212->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0116->IL0019: Incompatible stack heights: 2 vs 1
		//IL_014c->IL0019: Incompatible stack types: I4 vs Ref
		//IL_01a2->IL0019: Incompatible stack types: I4 vs Ref
		//IL_0181->IL0019: Incompatible stack types: I4 vs Ref
		//IL_021d->IL0019: Incompatible stack types: I4 vs Ref
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 13;
		while (true)
		{
			ref object reference = ref *(object*)obj;
			while (true)
			{
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				case 9u:
					_ = ref obj;
					_ = ((Array)obj).Length;
					_ = 14;
					continue;
				case 12u:
					_ = ref obj;
					_ = 38;
					_ = 2;
					_ = 17;
					continue;
				case 6u:
					obj = P_2;
					reference = ref *(object*)15;
					continue;
				case 13u:
					if ((nint)P_1 > (int)P_2)
					{
						obj = 12;
						break;
					}
					obj = P_1;
					if (6 != 0)
					{
						reference = ref *(object*)6;
					}
					continue;
				case 4u:
					return P_0;
				case 8u:
					_ = ref obj;
					if (18 == 0)
					{
						_ = 7;
					}
					continue;
				case 18u:
					_ = ref obj;
					_ = 16;
					continue;
				default:
					reference = ref obj;
					if (9 != 0)
					{
						reference = ref *(object*)5;
					}
					continue;
				case 16u:
					_ = ref obj;
					if (10 == 0)
					{
						_ = 1;
					}
					continue;
				case 14u:
					reference = ref obj;
					if (2 != 0)
					{
						reference = ref *(object*)1;
					}
					continue;
				case 17u:
					reference = ref obj;
					if (2 != 0)
					{
						reference = ref *(object*)8;
					}
					continue;
				case 10u:
					_ = ref obj;
					obj = 5;
					break;
				case 1u:
					throw ref obj;
				case 5u:
					throw ref obj;
				case 7u:
					obj = 4;
					break;
				case 11u:
					_ = ref obj;
					_ = 41;
					_ = 2;
					if (0 == 0)
					{
						_ = 0;
					}
					continue;
				case 2u:
					_ = ref obj;
					_ = 3;
					continue;
				case 3u:
					reference = ref obj;
					if (1 == 0)
					{
						reference = ref *(object*)1;
					}
					continue;
				case 15u:
					if (((Array)obj).Length <= (nint)obj)
					{
						_ = ((Array)obj).Length;
						reference = ref *(object*)P_0;
						if (1 == 0)
						{
							reference = ref *(object*)7;
						}
					}
					else if (2 != 0)
					{
						reference = ref *(object*)11;
					}
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00䘀(object P_0, object P_1, uint P_2)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776613, new IntPtr(2737368314188L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00䜀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00䠀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776612, new IntPtr(2737368313148L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00䤀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}
}
