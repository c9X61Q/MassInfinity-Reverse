using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using DotNetty.Buffers;

namespace Mass.Bedrock.Proxy.Network;

public static class TexturePackCodec
{
	private static object GetList;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static TexturePack ReadTexturePack(this IByteBuffer buffer)
	{
		return (TexturePack)_FF00_FF00_FF00_FFFD(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void WriteTexturePack(this IByteBuffer buffer, TexturePack texturePack)
	{
		_FF00_FF00_FF00_E100(buffer, texturePack);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ReflectCentralLogger()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static TexturePackCodec CheckStatelessConnection()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FFFD()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778852, new IntPtr(2737337514844L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FFFD()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FFFD()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778853, new IntPtr(2737337514844L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FFFD()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778854, new IntPtr(2737337523164L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FFFD()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FFFD()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778855, new IntPtr(2737337510684L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FFFD(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 2059, 1790778856, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778856, new IntPtr(2737337510684L), 15);
		}
		return ((delegate*<object, object>)obj)(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00_FF00_FF00_E000(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778857, new IntPtr(2737337521084L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void _FF00_FF00_FF00_E100(object P_0, object P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_004a: Expected I4, but got Obj
		//IL_006d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0120->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00f6->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00ce->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00be->IL0019: Incompatible stack heights: 3 vs 1
		//IL_005d->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0106->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00e7->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00b0->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0078->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00d9->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0111->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0094->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 6;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 7:
				_ = 8;
				break;
			case 1:
				if (0 == 0)
				{
					_ = 4;
				}
				break;
			case 10:
				obj2 = P_0;
				if (false)
				{
					obj2 = 0;
				}
				break;
			default:
				obj2 = P_0;
				if (true)
				{
					obj2 = 9;
				}
				break;
			case 6:
				_ = 5;
				break;
			case 5:
				if (2 == 0)
				{
					_ = 3;
				}
				break;
			case 9:
				_ = 2;
				break;
			case 4:
				_ = 10;
				break;
			case 8:
				if (true)
				{
					_ = 1;
				}
				break;
			case 3:
				_ = 7;
				break;
			case 2:
				return;
			}
		}
	}
}
