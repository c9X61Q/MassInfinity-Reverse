using System.Runtime.CompilerServices;
using DotNetty.Buffers;

namespace Mass.Game.Proxy.Protocols.Germ.Clientbound;

public class HytPartyOpen : GermPacket
{
	public override void Read(IByteBuffer buffer)
	{
	}

	public override void Write(IByteBuffer buffer)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public HytPartyOpen()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ != 0)
		{
		}
	}
}
