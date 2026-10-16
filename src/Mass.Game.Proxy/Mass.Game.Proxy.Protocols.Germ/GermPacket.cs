using System.Runtime.CompilerServices;
using DotNetty.Buffers;

namespace Mass.Game.Proxy.Protocols.Germ;

public abstract class GermPacket
{
	public abstract void Read(IByteBuffer buffer);

	public abstract void Write(IByteBuffer buffer);

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected GermPacket()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ != 0)
		{
		}
	}
}
