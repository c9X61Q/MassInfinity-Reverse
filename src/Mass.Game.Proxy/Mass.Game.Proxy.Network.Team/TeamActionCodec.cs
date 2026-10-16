using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using DotNetty.Buffers;
using Mass.Game.Proxy.Enums;

namespace Mass.Game.Proxy.Network.Team;

public static class TeamActionCodec
{
	internal static TeamActionCodec ReflectReadableConnection;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static TeamActionBase ReadTeamAction(this IByteBuffer buffer, EnumProtocolVersion version)
	{
		return (TeamActionBase)_FF00_FF00_FF00_FF00_0D00(buffer, version);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void WriteTeamAction(this IByteBuffer buffer, TeamActionBase action)
	{
		_FF00_FF00_FF00_FF00_0900(buffer, action);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CheckRemoteAttribute()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static TeamActionCodec CreateAnnotation()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00_FF00_FF00_FF00ࠀ(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776680, new IntPtr(2737368325628L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void _FF00_FF00_FF00_FF00_0900(object P_0, object P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_0063->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0049->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0073->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0054->IL0019: Incompatible stack heights: 2 vs 1
		//IL_007e->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		while (true)
		{
			switch ((int)obj)
			{
			case 1:
				_ = 32767;
				if (false)
				{
					_ = 0;
				}
				break;
			default:
				_ = 3;
				break;
			case 2:
				return;
			case 3:
				if (2 == 0)
				{
					_ = 2;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_0A00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776683, new IntPtr(2737368320428L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_0B00()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_0C00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776682, new IntPtr(2737368317308L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_0D00(object P_0, EnumProtocolVersion P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_005a: Expected I4, but got Obj
		//IL_00e7: Expected Obj, but got I4
		//IL_0076: Expected Obj, but got I4
		//IL_0139: Expected Obj, but got I4
		//IL_0102: Expected Obj, but got I4
		//IL_0091: Expected Obj, but got I4
		//IL_0063: Expected Obj, but got I4
		//IL_01a4: Expected I4, but got Obj
		//IL_00f3->IL0019: Incompatible stack heights: 0 vs 1
		//IL_016d->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0143->IL0019: Incompatible stack types: I4 vs Obj
		//IL_010e->IL0019: Incompatible stack heights: 0 vs 1
		//IL_009d->IL0019: Incompatible stack heights: 0 vs 1
		//IL_006d->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00fe->IL0019: Incompatible stack types: I4 vs Obj
		//IL_008d->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0119->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00a8->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01b0->IL0019: Incompatible stack heights: 0 vs 1
		//IL_01bb->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 2;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 11:
				obj = P_1;
				obj2 = 9;
				break;
			case 2:
				obj2 = P_0;
				obj = 32767;
				if (true)
				{
					obj2 = 1;
				}
				break;
			case 5:
				goto IL_008d;
			case 12:
			case 14:
				throw /*Error near IL_00b9: Stack underflow*/;
			case 6:
			case 7:
			case 8:
			case 9:
			case 10:
				return P_0;
			default:
				goto IL_00e3;
			case 4:
				goto IL_00fe;
			case 3:
				goto IL_0135;
			case 1:
				obj = P_0;
				obj2 = 13;
				break;
			case 13:
				{
					switch ((int)obj)
					{
					case 4:
						break;
					case 3:
						goto IL_008d;
					case 2:
						goto IL_00e3;
					case 1:
						goto IL_00fe;
					case 0:
						goto IL_0135;
					default:
						goto IL_01a4;
					}
					goto case 11;
				}
				IL_01a4:
				if (14 == 0)
				{
					obj2 = 4;
				}
				break;
				IL_008d:
				obj = P_1;
				if (6 != 0)
				{
					obj2 = 7;
				}
				break;
				IL_0135:
				obj = P_1;
				obj2 = 10;
				break;
				IL_00fe:
				obj = P_1;
				if (6 == 0)
				{
					obj2 = 2;
				}
				break;
				IL_00e3:
				obj = P_1;
				if (4 == 0)
				{
					obj2 = 8;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_0E00()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}
}
