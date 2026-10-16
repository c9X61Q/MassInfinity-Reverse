using System.Runtime.CompilerServices;
using Mass.Bedrock.Proxy.Network.Packet;

namespace Mass.Bedrock.Proxy.Packets.RakNet.Acknowledge;

[RakNetPacket(160)]
public class Nack : Ack
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Nack()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ != 0)
		{
		}
	}
}
