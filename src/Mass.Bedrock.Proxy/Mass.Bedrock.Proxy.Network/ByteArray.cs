using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using DotNetty.Buffers;

namespace Mass.Bedrock.Proxy.Network;

public static class ByteArray
{
	private static object QueryAuthenticator;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static byte[] ReadAsBytes(this IByteBuffer buffer)
	{
		return (byte[])_FF00_FF00_FF00_FF00䘀(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static byte[] ReadAsBytes(this IByteBuffer buffer, int length)
	{
		return (byte[])_FF00_FF00_FF00_FF00䤀(buffer, (uint)length);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SolveSchema()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ByteArray CheckEditableParameter()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00㼀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778662, new IntPtr(2737337525244L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00䀀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00䄀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778663, new IntPtr(2737337524204L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00䈀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778664, new IntPtr(2737337514844L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00䌀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00䐀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778665, new IntPtr(2737337514844L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00䔀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778666, new IntPtr(2737337510684L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00䘀(object P_0)
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00䤀(object P_0, uint P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_004a: Expected I4, but got Obj
		//IL_0066: Expected Obj, but got I4
		//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
		//IL_0110->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00ff->IL0019: Incompatible stack heights: 4 vs 1
		//IL_00bb->IL0019: Incompatible stack types: Obj vs Ref
		//IL_005d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00ef->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00d6->IL0019: Incompatible stack heights: 0 vs 1
		//IL_011b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00c6->IL0019: Incompatible stack types: I4 vs Ref
		//IL_008e->IL0019: Incompatible stack types: I4 vs Ref
		//IL_012f->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00e1->IL0019: Incompatible stack types: I4 vs Ref
		//IL_0070->IL0019: Incompatible stack types: I4 vs Ref
		//IL_013a->IL0019: Incompatible stack types: I4 vs Ref
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 7;
		ref object reference = ref *(object*)obj;
		while (true)
		{
			switch ((uint)Unsafe.AsPointer(ref reference))
			{
			case 3u:
				_ = ref obj;
				_ = 4;
				break;
			case 8u:
				throw ref obj;
			case 9u:
				obj = P_1;
				reference = ref *(object*)2;
				break;
			case 10u:
				return obj;
			case 5u:
				reference = ref obj;
				if (false)
				{
					reference = ref *(object*)null;
				}
				break;
			case 2u:
				reference = ref *(object*)P_0;
				if (9 != 0)
				{
					reference = ref *(object*)10;
				}
				break;
			case 7u:
				obj = P_0;
				if (6 != 0)
				{
					reference = ref *(object*)3;
				}
				break;
			case 4u:
				_ = ref obj;
				_ = 5;
				break;
			case 1u:
				_ = ref obj;
				_ = 47;
				_ = 2;
				_ = 3;
				break;
			default:
				_ = ref obj;
				if (8 == 0)
				{
					_ = 6;
				}
				break;
			case 6u:
				if ((int)P_1 <= (nint)obj)
				{
					if (9 != 0)
					{
						reference = ref *(object*)6;
					}
					break;
				}
				goto case 1u;
			}
		}
	}
}
