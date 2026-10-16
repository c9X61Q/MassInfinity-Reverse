using System.Runtime.CompilerServices;
using DotNetty.Buffers;
using Mass.Game.Proxy.Enums;
using Mass.Game.Proxy.Minecraft;
using Mass.Game.Proxy.Network.Interface;
using Mass.Game.Proxy.Network.Packet;

namespace Mass.Game.Proxy.Packets.Configuration;

[Packet(EnumConnectionState.Configuration, EnumPacketDirection.Serverbound)]
[PacketVersion(EnumProtocolVersion.V1219, 9)]
[PacketVersion(EnumProtocolVersion.V1218, 9)]
public class ServerboundAcceptCodeOfConductPacket : IPacket, IBufferCodec, IBufferSerializable, IBufferDeserializable
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ServerboundAcceptCodeOfConductPacket(EnumProtocolVersion version)
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
