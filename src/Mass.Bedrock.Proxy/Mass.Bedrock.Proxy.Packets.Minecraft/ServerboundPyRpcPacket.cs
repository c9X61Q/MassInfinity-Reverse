using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Mass.Bedrock.Proxy.Network.Minecraft.Enums;
using Mass.Bedrock.Proxy.Network.Packet;

namespace Mass.Bedrock.Proxy.Packets.Minecraft;

[Packet(EnumPacketDirection.Serverbound, 200u)]
public class ServerboundPyRpcPacket : PyRpcPacket
{
	internal static ServerboundPyRpcPacket DecorateCommonToken;

	public override EnumPacketDirection Direction => EnumPacketDirection.Serverbound;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ServerboundPyRpcPacket()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ != 0)
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ServerboundPyRpcPacket(PyRpcPacketBase packet)
	{
		//IL_0046->IL001c: Incompatible stack heights: 3 vs 2
		//IL_0061->IL001c: Incompatible stack heights: 3 vs 2
		//IL_0051->IL001c: Incompatible stack heights: 3 vs 2
		//IL_006c->IL001c: Incompatible stack heights: 3 vs 2
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		while (true)
		{
			switch (2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				_ = 98247598;
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			case 2:
				if (false)
				{
					_ = 1;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DecorateAdaptableExplorer()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ServerboundPyRpcPacket VisitSubscriber()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00뼀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778733, new IntPtr(2737337512764L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FF00_FF00쀀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FF00_FF00섀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00숀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778734, new IntPtr(2737337509644L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}
}
