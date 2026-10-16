using System.Runtime.CompilerServices;
using Mass.Game.Proxy.Enums;
using Mass.Game.Proxy.Network.Packet;
using Mass.Game.Proxy.Packets.Common;

namespace Mass.Game.Proxy.Packets.Configuration;

[Packet(EnumConnectionState.Configuration, EnumPacketDirection.Clientbound)]
[PacketVersion(EnumProtocolVersion.V1206, 14)]
[PacketVersion(EnumProtocolVersion.V1218, 14)]
[PacketVersion(EnumProtocolVersion.V1219, 14)]
[PacketVersion(EnumProtocolVersion.V1211, 14)]
public class ClientboundKnownPacksPacket : KnownPacksPacket
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ClientboundKnownPacksPacket(EnumProtocolVersion version)
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ != 0)
		{
		}
	}
}
