using System.Runtime.CompilerServices;
using DotNetty.Buffers;
using Mass.Game.Proxy.Enums;
using Mass.Game.Proxy.Minecraft;
using Mass.Game.Proxy.Network.Interface;
using Mass.Game.Proxy.Network.Packet;

namespace Mass.Game.Proxy.Packets.Play;

[Packet(EnumConnectionState.Play, EnumPacketDirection.Clientbound)]
[PacketVersion(EnumProtocolVersion.V1219, 116)]
[PacketVersion(EnumProtocolVersion.V1218, 111)]
[PacketVersion(EnumProtocolVersion.V1206, 105)]
[PacketVersion(EnumProtocolVersion.V1211, 105)]
public class ClientboundStartConfigurationPacket : IPacket, IBufferCodec, IBufferSerializable, IBufferDeserializable
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ClientboundStartConfigurationPacket(EnumProtocolVersion version)
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ != 0)
		{
		}
	}

	public void Read(IByteBuffer buffer)
	{
	}

	public void Write(IByteBuffer buffer)
	{
	}

	public bool Handle(Connection connection)
	{
		return false;
	}
}
