using System.Runtime.CompilerServices;
using DotNetty.Buffers;
using Mass.Game.Proxy.Enums;

namespace Mass.Game.Proxy.Network.Team;

public class RemoveTeam : TeamActionBase
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public RemoveTeam(EnumProtocolVersion version)
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ != 0)
		{
		}
	}

	public override void Read(IByteBuffer buffer)
	{
	}

	public override void Write(IByteBuffer buffer)
	{
	}
}
