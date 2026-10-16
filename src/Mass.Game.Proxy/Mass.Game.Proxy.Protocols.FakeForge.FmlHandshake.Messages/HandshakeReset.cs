using System.Runtime.CompilerServices;
using DotNetty.Buffers;

namespace Mass.Game.Proxy.Protocols.FakeForge.FmlHandshake.Messages;

public class HandshakeReset : FmlHandshakeMessage
{
	public override void Read(IByteBuffer buffer)
	{
	}

	public override void Write(IByteBuffer buffer)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public HandshakeReset()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ != 0)
		{
		}
	}
}
