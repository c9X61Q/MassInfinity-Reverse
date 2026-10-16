using System.Runtime.CompilerServices;
using DotNetty.Buffers;

namespace Mass.Game.Proxy.Protocols.Germ.Clientbound;

public class OhMyGodClientLinkRequest : GermPacket
{
	public override void Read(IByteBuffer buffer)
	{
	}

	public override void Write(IByteBuffer buffer)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public OhMyGodClientLinkRequest()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ != 0)
		{
		}
	}
}
