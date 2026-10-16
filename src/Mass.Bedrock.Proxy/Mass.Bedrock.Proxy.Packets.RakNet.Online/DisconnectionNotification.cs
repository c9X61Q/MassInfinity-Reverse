using System.Runtime.CompilerServices;
using DotNetty.Buffers;
using Mass.Bedrock.Proxy.Network.Packet;

namespace Mass.Bedrock.Proxy.Packets.RakNet.Online;

[RakNetPacket(21)]
public class DisconnectionNotification : IRakNetPacket
{
	public void Read(IByteBuffer buffer)
	{
	}

	public void Write(IByteBuffer buffer)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DisconnectionNotification()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ != 0)
		{
		}
	}
}
