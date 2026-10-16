using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using DotNetty.Buffers;

namespace Mass.Bedrock.Proxy.Network;

public static class VarInt
{
	internal static VarInt AddVerifier;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int ReadVarInt32(this IByteBuffer buffer)
	{
		return (int)_FF00_FF00_FF00가(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void WriteVarInt32(this IByteBuffer buffer, int value)
	{
		_FF00_FF00_FF00넀(buffer, (uint)value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static long ReadVarInt64(this IByteBuffer buffer)
	{
		return _FF00_FF00_FF00꼀(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void WriteVarInt64(this IByteBuffer buffer, long value)
	{
		_FF00_FF00_FF00ꨀ(buffer, value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static uint ReadUnsignedVarInt32(this IByteBuffer buffer)
	{
		return _FF00_FF00_FF00딀(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void WriteUnsignedVarInt32(this IByteBuffer buffer, uint value)
	{
		_FF00_FF00_FF00ꘀ(buffer, value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static ulong ReadUnsignedVarInt64(this IByteBuffer buffer)
	{
		return _FF00_FF00_FF00뜀(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void WriteUnsignedVarInt64(this IByteBuffer buffer, ulong value)
	{
		_FF00_FF00_FF00_A700(buffer, value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool RunAnnotation()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static VarInt ParseComparator()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00_FF00_FF00ꔀ(object P_0, uint P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778875, new IntPtr(2737337526284L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void _FF00_FF00_FF00ꘀ(object P_0, uint P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0072->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0082->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0052->IL0019: Incompatible stack heights: 0 vs 1
		//IL_009e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_005d->IL0019: Incompatible stack types: I4 vs Obj
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
			case 3:
				if (P_1 < 128)
				{
					if (5 == 0)
					{
						obj2 = 4;
					}
					break;
				}
				goto default;
			default:
				_ = (byte)(P_1 | 0x80);
				_ = 4;
				break;
			case 2:
				return;
			case 4:
				P_1 >>= 7;
				obj2 = 3;
				break;
			case 5:
				obj2 = P_0;
				_ = (byte)P_1;
				if (1 == 0)
				{
					obj2 = 2;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void _FF00_FF00_FF00_A700(object P_0, ulong P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_004c->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00a0->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0089->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0057->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0073->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 4;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 2:
				P_1 >>= 7;
				if (false)
				{
					obj2 = 0;
				}
				continue;
			case 5:
				obj2 = P_0;
				_ = (byte)P_1;
				if (0 == 0)
				{
					obj2 = 1;
				}
				continue;
			default:
				if (P_1 < 128)
				{
					obj2 = 5;
					continue;
				}
				break;
			case 1:
				return;
			case 3:
				break;
			}
			_ = (byte)(P_1 | 0x80);
			_ = 2;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00_FF00_FF00ꠀ(object P_0, ulong P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778876, new IntPtr(2737337512764L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00_FF00_FF00꤀(object P_0, long P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778877, new IntPtr(2737337512764L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00_FF00_FF00ꨀ(object P_0, long P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778878, new IntPtr(2737337512764L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static uint _FF00_FF00_FF00_AB00(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778879, new IntPtr(2737337519004L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static uint _FF00_FF00_FF00가(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778752, new IntPtr(2737337516924L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static uint _FF00_FF00_FF00관(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778753, new IntPtr(2737337512764L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00글()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778754, new IntPtr(2737337517964L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static long _FF00_FF00_FF00꼀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778755, new IntPtr(2737337516924L), 15))(null, 0, new IntPtr(0L));
		return (long)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static long _FF00_FF00_FF00뀀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778756, new IntPtr(2737337529404L), 15))(null, 0, new IntPtr(0L));
		return (long)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00_FF00_FF00넀(object P_0, uint P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778757, new IntPtr(2737337533564L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00_FF00_FF00눀(object P_0, uint P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778758, new IntPtr(2737337523164L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static uint _FF00_FF00_FF00됀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778759, new IntPtr(2737337512764L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static uint _FF00_FF00_FF00딀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778760, new IntPtr(2737337521084L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static ulong _FF00_FF00_FF00뜀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778761, new IntPtr(2737337515884L), 15))(null, 0, new IntPtr(0L));
		return (ulong)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static ulong _FF00_FF00_FF00렀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778762, new IntPtr(2737337512764L), 15))(null, 0, new IntPtr(0L));
		return (ulong)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00뤀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778763, new IntPtr(2737337512764L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00먀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778764, new IntPtr(2737337528364L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}
}
