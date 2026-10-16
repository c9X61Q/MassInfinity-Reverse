using System.Runtime.CompilerServices;
using DotNetty.Buffers;
using Mass.Bedrock.Proxy.Minecraft;
using Mass.Bedrock.Proxy.Network.Minecraft.Enums;
using Mass.Bedrock.Proxy.Network.Packet;

namespace Mass.Bedrock.Proxy.Packets.Minecraft;

[Packet(EnumPacketDirection.Serverbound, 4u)]
public class ServerboundHandshakePacket : PacketBase
{
	public override void Read(IByteBuffer buffer)
	{
	}

	public override void Write(IByteBuffer buffer)
	{
	}

	public override bool Handle(Connection connection)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ServerboundHandshakePacket()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ != 0)
		{
		}
	}
}
