using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using DotNetty.Buffers;
using Mass.Game.Proxy.Enums;
using Mass.Game.Proxy.Minecraft;
using Mass.Game.Proxy.Network.Packet;
using Mass.Game.Proxy.Packets.Common;

namespace Mass.Game.Proxy.Packets.Play;

[Packet(EnumConnectionState.Play, EnumPacketDirection.Serverbound)]
[PacketVersion(EnumProtocolVersion.V1181, 10)]
[PacketVersion(EnumProtocolVersion.V1710, 23)]
[PacketVersion(EnumProtocolVersion.V1201, 13)]
[PacketVersion(EnumProtocolVersion.V1206, 18)]
[PacketVersion(EnumProtocolVersion.V1211, 18)]
[PacketVersion(EnumProtocolVersion.V1122, 9)]
[PacketVersion(EnumProtocolVersion.V189, 23)]
public class ServerboundPluginMessagePacket : PluginMessagePacket
{
	private static object CheckGroupedProgram;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ServerboundPluginMessagePacket(EnumProtocolVersion version)
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		int num = (int)version;
		if (0 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ServerboundPluginMessagePacket(EnumProtocolVersion version, string channel, IByteBuffer data)
	{
		//IL_004f->IL002a: Incompatible stack heights: 3 vs 2
		//IL_0068->IL002a: Incompatible stack heights: 4 vs 2
		//IL_005a->IL002a: Incompatible stack heights: 3 vs 2
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		int num = (int)version;
		if (false)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				return;
			case 1:
				_ = 2;
				continue;
			}
			if (1 == 0)
			{
				_ = 1;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool Handle(Connection connection)
	{
		return _FF00_FF00_FF00_2900(connection) != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DecorateAccessibleTemplate()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ServerboundPluginMessagePacket CancelStrategy()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_2500()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777597, new IntPtr(2737368327708L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_2600()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_2700()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777596, new IntPtr(2737368327708L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_2800()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00_FF00_2900(object P_0)
	{
		//IL_000e: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_2A00(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777599, new IntPtr(2737368320428L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}
}
