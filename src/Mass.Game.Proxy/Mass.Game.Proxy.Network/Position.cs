using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Mass.Game.Proxy.Network;

public readonly struct Position
{
	public readonly long X;

	public readonly long Y;

	public readonly long Z;

	private static object FormatBuilder;

	public long Encoded
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00_FF00匀();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Position(long x, long y, long z)
	{
		//IL_0021: Expected I4, but got I8
		//IL_0040->IL0010: Incompatible stack types: I4 vs I8
		//IL_004e->IL0010: Incompatible stack heights: 4 vs 2
		//IL_005d->IL0010: Incompatible stack heights: 3 vs 2
		//IL_0068->IL0010: Incompatible stack heights: 3 vs 2
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		long num = x;
		if (true)
		{
			num = 1L;
		}
		while (true)
		{
			switch ((int)num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				_ = 2;
				break;
			case 2:
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Position(long encoded)
	{
		//IL_0044: Expected I4, but got I8
		//IL_0032->IL003b: Incompatible stack types: I4 vs I8
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		_ = encoded >> 38;
		_ = encoded << 52 >> 52;
		long num = encoded << 26 >> 38;
		if (0 == 0)
		{
			num = 0L;
		}
		switch ((int)num)
		{
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DecorateGlobalTransmitter()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DecorateDetachedRecommender()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe long _FF00_FF00_FF00_FF00刀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776620, new IntPtr(2737368302748L), 15))(null, 0, new IntPtr(0L));
		return (long)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe long _FF00_FF00_FF00_FF00匀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (long)((((ulong)(nint)Unsafe.AsPointer(ref this) & 0x3FFFFFFuL) << 38) | (((ulong)(nint)Unsafe.AsPointer(ref this) & 0x3FFFFFFuL) << 12) | ((ulong)(nint)Unsafe.AsPointer(ref this) & 0xFFFuL));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00吀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00唀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776623, new IntPtr(2737368324588L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00嘀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}
}
