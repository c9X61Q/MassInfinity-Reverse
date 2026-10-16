using System.Runtime.CompilerServices;
using Mass.Game.Proxy.Enums;
using Mass.Game.Proxy.Network.Packet;
using Mass.Game.Proxy.Packets.Common;

namespace Mass.Game.Proxy.Packets.Configuration;

[PacketVersion(EnumProtocolVersion.V1206, 7)]
[PacketVersion(EnumProtocolVersion.V1219, 7)]
[PacketVersion(EnumProtocolVersion.V1211, 7)]
[PacketVersion(EnumProtocolVersion.V1218, 7)]
[Packet(EnumConnectionState.Configuration, EnumPacketDirection.Serverbound)]
public class ServerboundKnownPacksPacket : KnownPacksPacket
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ServerboundKnownPacksPacket(EnumProtocolVersion version)
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ != 0)
		{
		}
	}
}
