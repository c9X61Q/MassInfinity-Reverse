using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using DotNetty.Buffers;
using Mass.Game.Proxy.Enums;

namespace Mass.Game.Proxy.Protocols.FakeForge.FmlHandshake;

public static class FmlHandshakeMessageCodec
{
	internal static FmlHandshakeMessageCodec CheckHiddenProfiler;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static FmlHandshakeMessage ReadFmlHandshakeMessage(this IByteBuffer buffer, EnumProtocolVersion version)
	{
		return (FmlHandshakeMessage)_FF00_FF00_FF00_FF00ⴀ(buffer, version);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IByteBuffer WriteFmlHandshakeMessage(this IByteBuffer buffer, FmlHandshakeMessage message, EnumProtocolVersion version)
	{
		return (IByteBuffer)_FF00_FF00_FF00_FF00_3000(buffer, message, version);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ReflectAdjustableFactory()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static FmlHandshakeMessageCodec DecorateGenericCompressor()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_2500()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779377, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_2600()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_2700()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779376, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_2800()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_2900()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779379, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00Ⰰ(object P_0, EnumProtocolVersion P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779378, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00ⴀ(object P_0, EnumProtocolVersion P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0066: Expected I4, but got Obj
		//IL_011a: Expected I4, but got Obj
		//IL_01a1->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00e0->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0194->IL0019: Incompatible stack types: I4 vs Obj
		//IL_016b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01af->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01fe->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00f8->IL0019: Incompatible stack heights: 0 vs 1
		//IL_01ef->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00c4->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0126->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0209->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0103->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0131->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 16;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 9:
				if ((nint)obj != 254)
				{
					obj2 = 3;
					continue;
				}
				goto case 14;
			case 10:
				obj = (object)/*Error near IL_00d6: Stack underflow*/;
				obj2 = 8;
				continue;
			case 3:
				if ((nint)obj != 255)
				{
					if (17 == 0)
					{
						obj2 = 16;
					}
					continue;
				}
				goto case 13;
			case 15:
				switch ((int)obj)
				{
				case 2:
					break;
				default:
					goto IL_011a;
				case 1:
					goto IL_0140;
				case 0:
					goto IL_0194;
				case 3:
					goto IL_01de;
				}
				goto case 10;
			case 1:
			case 17:
				goto IL_0140;
			case 2:
			case 6:
			case 8:
			case 11:
			case 12:
				return P_0;
			case 14:
				obj = (object)/*Error near IL_0161: Stack underflow*/;
				obj2 = 11;
				continue;
			case 13:
				obj = (object)/*Error near IL_018a: Stack underflow*/;
				obj2 = 12;
				continue;
			case 7:
				goto IL_0194;
			case 16:
				obj = P_0;
				obj2 = 15;
				continue;
			case 4:
				goto IL_01de;
				IL_01de:
				if (P_1 <= EnumProtocolVersion.V1710)
				{
					break;
				}
				obj2 = 5;
				continue;
				IL_0194:
				obj = (object)/*Error near IL_0197: Stack underflow*/;
				obj2 = 6;
				continue;
				IL_0140:
				_ = ref obj;
				_ = 28;
				_ = 1;
				_ = ref obj;
				_ = ref obj;
				throw ref obj;
				IL_011a:
				if (9 != 0)
				{
					obj2 = 5;
				}
				continue;
			}
			obj = (object)/*Error near IL_01f2: Stack underflow*/;
			if (2 != 0)
			{
				obj2 = 2;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_2E00(object P_0, EnumProtocolVersion P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779341, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_3000(object P_0, object P_1, EnumProtocolVersion P_2)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_007a: Expected I4, but got Obj
		//IL_0208: Expected Obj, but got I4
		//IL_0258: Expected Obj, but got I4
		//IL_0116: Expected Obj, but got I4
		//IL_024b: Expected Obj, but got I4
		//IL_01ce: Expected Obj, but got I4
		//IL_0214->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0262->IL0019: Incompatible stack types: I4 vs Obj
		//IL_022e->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0122->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0255->IL0019: Incompatible stack types: I4 vs Obj
		//IL_008e->IL0019: Incompatible stack heights: 2 vs 1
		//IL_01da->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0184->IL0019: Incompatible stack heights: 0 vs 1
		//IL_021f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00e8->IL0019: Incompatible stack types: I4 vs Obj
		//IL_016b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_013e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01a0->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0239->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00a1->IL0019: Incompatible stack heights: 0 vs 1
		//IL_012d->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01e5->IL0019: Incompatible stack types: I4 vs Obj
		//IL_018f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00ac->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 12;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 20:
				_ = 13;
				break;
			case 14:
				if (P_1 != null)
				{
					if (true)
					{
						obj2 = 4;
					}
					break;
				}
				goto case 8;
			case 2:
				if (P_1 != null)
				{
					obj2 = 6;
					break;
				}
				goto case 14;
			case 15:
			case 22:
				obj = 3;
				if (5 != 0)
				{
					obj2 = 5;
				}
				break;
			case 11:
				if (P_1 == null)
				{
					obj2 = 10;
					break;
				}
				goto case 19;
			case 10:
				if (P_1 != null)
				{
					obj2 = 22;
					break;
				}
				goto case 2;
			case 8:
			case 9:
				throw P_1;
			default:
				obj = obj;
				if (20 != 0)
				{
					obj2 = 19;
				}
				break;
			case 12:
				if (P_1 == null)
				{
					obj2 = 11;
					break;
				}
				goto case 21;
			case 21:
				obj = 1;
				if (6 != 0)
				{
					obj2 = 18;
				}
				break;
			case 1:
			case 6:
				obj = 255;
				if (false)
				{
					obj2 = 0;
				}
				break;
			case 13:
				if (10 == 0)
				{
					_ = 16;
				}
				break;
			case 19:
				obj = 2;
				obj2 = 17;
				break;
			case 4:
			case 7:
				obj = 3;
				obj2 = 3;
				break;
			case 16:
				return P_0;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_3100(object P_0, object P_1, EnumProtocolVersion P_2)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779340, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}
}
