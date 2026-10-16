using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using DotNetty.Buffers;
using Mass.Game.Proxy.Enums;

namespace Mass.Game.Proxy.Network;

public static class Uuid
{
	private static object ReflectAutomatedReporter;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Guid ReadUuid(this IByteBuffer buffer, EnumProtocolVersion version)
	{
		return _FF00_FF00_FF00_FF00㨀(buffer, version);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IByteBuffer WriteUuid(this IByteBuffer buffer, Guid uuid, EnumProtocolVersion version)
	{
		return (IByteBuffer)_FF00_FF00_FF00_FF00㘀(buffer, uuid, version);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DecoratePassiveChain()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Uuid DecorateExternalEnumerator()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00㔀(object P_0, Guid P_1, EnumProtocolVersion P_2)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776615, new IntPtr(2737368327708L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00㘀(object P_0, Guid P_1, EnumProtocolVersion P_2)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_004d->IL0019: Incompatible stack heights: 3 vs 1
		//IL_006e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00a1->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00ac->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 2;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				_ = ref P_1;
				_ = 32767;
				_ = 4;
				break;
			case 3:
			case 4:
				return P_0;
			case 1:
				obj2 = P_0;
				_ = ref P_1;
				if (3 == 0)
				{
					obj2 = 0;
				}
				break;
			case 2:
				if (P_2 >= EnumProtocolVersion.V1181)
				{
					if (true)
					{
						obj2 = 0;
					}
					break;
				}
				goto default;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00㜀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776614, new IntPtr(2737368317308L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00㠀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00㤀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776609, new IntPtr(2737368320428L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Guid _FF00_FF00_FF00_FF00㨀(object P_0, EnumProtocolVersion P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		//IL_0083: Expected VT, but got I4
		//IL_0081->IL0081: Incompatible stack heights: 3 vs 2
		//IL_0070->IL0019: Incompatible stack heights: 0 vs 1
		//IL_007b->IL0019: Incompatible stack types: I4 vs Obj
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
				break;
			case 1:
				if (P_1 >= EnumProtocolVersion.V1181)
				{
					if (0 == 0)
					{
						obj2 = 0;
					}
					continue;
				}
				goto case 2;
			default:
				_ = 16;
				_ = 0;
				break;
			}
			break;
		}
		return (Guid)36;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00㬀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}
}
