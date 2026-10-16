using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using DotNetty.Buffers;

namespace Mass.Game.Proxy.Network;

public static class PositionCodec
{
	internal static PositionCodec ReflectDetailedAnalyzer;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Position ReadPosition(this IByteBuffer buffer)
	{
		return _FF00_FF00_FF00_FF00一(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IByteBuffer WritePosition(this IByteBuffer buffer, Position position)
	{
		return (IByteBuffer)_FF00_FF00_FF00_FF00䬀(buffer, position);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CheckDividedDistributor()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static PositionCodec ReflectGeneralNotifier()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00䨀(object P_0, Position P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776622, new IntPtr(2737368326668L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00䬀(object P_0, Position P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_0048->IL0019: Incompatible stack types: I4 vs Obj
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
				obj2 = P_0;
				_ = ref P_1;
				if (false)
				{
					obj2 = 0;
				}
				break;
			default:
				return P_0;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00䰀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00䴀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776617, new IntPtr(2737368305868L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Position _FF00_FF00_FF00_FF00一(object P_0)
	{
		//IL_000b: Expected VT, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (Position)P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static Position _FF00_FF00_FF00_FF00伀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776616, new IntPtr(2737368307948L), 15))(null, 0, new IntPtr(0L));
		return (Position)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00倀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00儀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776619, new IntPtr(2737368307948L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}
}
