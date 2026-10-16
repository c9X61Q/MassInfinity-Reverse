using System.Runtime.CompilerServices;
using System.Text;
using Mass.Application.Models;
using Mass.Bedrock.Proxy.Network.Packet;

namespace Mass.Bedrock.Proxy.Packets.RakNet.Acknowledge;

[RakNetPacket(160)]
public class Nack : Ack
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe Nack()
	{
		//IL_0011: Expected Obj, but got Ref
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		_ = ((EntityLaunchBedrockProxy)(object)this).EqualityContract;
	}
}
