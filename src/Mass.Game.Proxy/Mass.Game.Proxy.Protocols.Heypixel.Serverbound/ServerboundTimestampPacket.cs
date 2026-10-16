using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using MsgPack;

namespace Mass.Game.Proxy.Protocols.Heypixel.Serverbound;

public class ServerboundTimestampPacket : HeypixelPacket
{
	internal static ServerboundTimestampPacket FillReg;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ServerboundTimestampPacket(HeypixelProtocol protocol)
	{
		//IL_0033: Expected I4, but got Obj
		//IL_0021->IL002a: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		HeypixelProtocol heypixelProtocol = protocol;
		if (0 == 0)
		{
			heypixelProtocol = (HeypixelProtocol)0;
		}
		switch ((int)heypixelProtocol)
		{
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Write(Packer packer)
	{
		였(packer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SelectExecutor()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ServerboundTimestampPacket ReflectSimpleAnnotation()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object 섀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778597, new IntPtr(2737367939004L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object 숀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object 쌀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778596, new IntPtr(2737367939004L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte 쐀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte 씀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778599, new IntPtr(2737367939004L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 였(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
		//IL_004b->IL0019: Incompatible stack types: I4 vs Ref
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		ref object reference = ref *(object*)obj;
		while (true)
		{
			switch ((uint)Unsafe.AsPointer(ref reference))
			{
			default:
				return;
			case 0u:
				return;
			case 1u:
				obj = P_0;
				reference = ref obj;
				if (0 == 0)
				{
					reference = ref *(object*)null;
				}
				break;
			}
		}
	}
}
