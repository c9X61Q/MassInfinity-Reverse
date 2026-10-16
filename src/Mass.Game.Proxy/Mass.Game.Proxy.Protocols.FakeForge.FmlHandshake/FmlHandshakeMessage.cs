using System.Runtime.CompilerServices;
using DotNetty.Buffers;

namespace Mass.Game.Proxy.Protocols.FakeForge.FmlHandshake;

public abstract class FmlHandshakeMessage
{
	public abstract void Read(IByteBuffer buffer);

	public abstract void Write(IByteBuffer buffer);

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected FmlHandshakeMessage()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ != 0)
		{
		}
	}
}
