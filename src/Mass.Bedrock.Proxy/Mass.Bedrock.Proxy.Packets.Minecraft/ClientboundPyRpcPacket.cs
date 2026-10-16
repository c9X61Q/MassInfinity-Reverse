using System.Runtime.CompilerServices;
using Mass.Bedrock.Proxy.Network.Minecraft.Enums;
using Mass.Bedrock.Proxy.Network.Packet;

namespace Mass.Bedrock.Proxy.Packets.Minecraft;

[Packet(EnumPacketDirection.Clientbound, 200u)]
public class ClientboundPyRpcPacket : PyRpcPacket
{
	public override EnumPacketDirection Direction => EnumPacketDirection.Clientbound;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ClientboundPyRpcPacket()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ != 0)
		{
		}
	}
}
