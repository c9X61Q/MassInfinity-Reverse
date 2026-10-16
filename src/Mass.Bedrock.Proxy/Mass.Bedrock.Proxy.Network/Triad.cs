using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using DotNetty.Buffers;

namespace Mass.Bedrock.Proxy.Network;

public static class Triad
{
	private static object DecorateScheduledAttribute;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void WriteTriadLE(this IByteBuffer buffer, uint value)
	{
		_FF00_FF00_FF00픀(buffer, value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static uint ReadTriadLE(this IByteBuffer buffer)
	{
		return _FF00_FF00_FF00휀(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ReflectFilteredAuthorizer()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Triad MoveRequester()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00츀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778858, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00케()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00퀀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778859, new IntPtr(2737337523164L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00턀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778860, new IntPtr(2737337514844L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00툀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void _FF00_FF00_FF00픀(object P_0, uint P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0059->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0095->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00ca->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00b5->IL0019: Incompatible stack types: I4 vs Obj
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
				obj2 = P_0;
				_ = (byte)(P_1 >> 8);
				if (3 == 0)
				{
					obj2 = 3;
				}
				break;
			case 1:
				return;
			case 3:
				obj2 = P_0;
				_ = (byte)(P_1 >> 16);
				if (1 == 0)
				{
					obj2 = 1;
				}
				break;
			case 2:
				throw /*Error near IL_0099: Stack underflow*/;
			case 4:
				obj2 = P_0;
				_ = (byte)P_1;
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			case 5:
				if (P_1 <= 16777215)
				{
					obj2 = 4;
					break;
				}
				goto case 2;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00_FF00_FF00혀(object P_0, uint P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778861, new IntPtr(2737337511724L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static uint _FF00_FF00_FF00휀(object P_0)
	{
		//IL_001d: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = P_0;
		obj = P_0;
		return (uint)((object)(P_0 | (object)(obj << 8)) | (object)(obj << 16));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static uint _FF00_FF00_FF00_FFFD(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778862, new IntPtr(2737337527324L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}
}
