using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using DotNetty.Buffers;
using Mass.Game.Proxy.Enums;

namespace Mass.Game.Proxy.Network;

public static class ByteArray
{
	private static object DecorateLocalPolicy;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static byte[] ReadAsBytes(this IByteBuffer buffer, int length)
	{
		return (byte[])_FF00_FF00_FF00_FF00脀(buffer, (uint)length);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static byte[] ReadAsBytes(this IByteBuffer buffer, EnumProtocolVersion version)
	{
		return (byte[])_FF00_FF00_FF00_FF00簀(buffer, version);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IByteBuffer WriteAsBytes(this IByteBuffer buffer, byte[] input, EnumProtocolVersion version)
	{
		return (IByteBuffer)_FF00_FF00_FF00_FF00蘀(buffer, input, version);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IByteBuffer ReadAsBuffer(this IByteBuffer buffer)
	{
		return (IByteBuffer)_FF00_FF00_FF00_FF00缀(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ReflectSymbolicRequester()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ByteArray StopStack()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00笀(object P_0, EnumProtocolVersion P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778053, new IntPtr(2737368333948L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00簀(object P_0, EnumProtocolVersion P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0065->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00a5->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0076->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 5;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				obj = P_0;
				obj2 = 3;
				continue;
			case 5:
				if (P_1 > EnumProtocolVersion.V1710)
				{
					obj2 = 4;
					continue;
				}
				break;
			case 2:
			case 3:
				return obj;
			case 1:
				break;
			}
			obj = P_0;
			obj2 = 2;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00紀(object P_0, EnumProtocolVersion P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778052, new IntPtr(2737368325628L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00縀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778055, new IntPtr(2737368305868L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00缀(object P_0)
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00耀(object P_0, uint P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778054, new IntPtr(2737368302748L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00脀(object P_0, uint P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_004a: Expected I4, but got Obj
		//IL_00c8: Expected Obj, but got I4
		//IL_00b6: Expected Obj, but got I4
		//IL_0110: Expected Obj, but got I4
		//IL_00dd->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00a8->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00f9->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00bb->IL0015: Incompatible stack heights: 1 vs 0
		//IL_009a->IL0019: Incompatible stack heights: 4 vs 1
		//IL_0128->IL0019: Incompatible stack heights: 2 vs 1
		//IL_011a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00e8->IL0019: Incompatible stack heights: 2 vs 1
		//IL_007f->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0104->IL0019: Incompatible stack heights: 2 vs 1
		//IL_008a->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 5;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 4:
					if ((int)P_1 <= (nint)obj)
					{
						if (1 == 0)
						{
							obj2 = 1;
						}
						continue;
					}
					goto case 9;
				case 9:
					_ = ref obj;
					_ = 47;
					_ = 2;
					_ = 6;
					continue;
				case 6:
					_ = ref obj;
					_ = 3;
					continue;
				case 8:
					obj = 2;
					break;
				case 5:
					obj = P_0;
					obj = 4;
					break;
				case 3:
					_ = ref obj;
					if (10 == 0)
					{
						_ = 2;
					}
					continue;
				case 7:
					_ = ref obj;
					if (false)
					{
						_ = 0;
					}
					continue;
				case 2:
					return obj;
				default:
					throw ref obj;
				case 1:
					obj = P_1;
					obj2 = 8;
					continue;
				case 10:
					_ = ref obj;
					_ = 7;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00舀(object P_0, uint P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778049, new IntPtr(2737368328748L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00茀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00萀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00蔀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778048, new IntPtr(2737368320428L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00蘀(object P_0, object P_1, EnumProtocolVersion P_2)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_003a: Expected I4, but got Obj
		//IL_0096: Expected Obj, but got I4
		//IL_004f->IL0019: Incompatible stack heights: 2 vs 1
		//IL_009b->IL0015: Incompatible stack heights: 1 vs 0
		//IL_0089->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00ac->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 6;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 1:
				case 5:
					_ = ((Array)P_1).Length;
					_ = 2;
					continue;
				default:
					obj2 = P_0;
					_ = (short)((Array)P_1).Length;
					if (4 == 0)
					{
						obj2 = 0;
					}
					continue;
				case 2:
				case 4:
					break;
				case 6:
					if (P_2 > EnumProtocolVersion.V1710)
					{
						obj2 = 5;
						continue;
					}
					goto default;
				case 3:
					return P_0;
				}
				break;
			}
			obj = 3;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00蜀(object P_0, object P_1, EnumProtocolVersion P_2)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778051, new IntPtr(2737368306908L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}
}
