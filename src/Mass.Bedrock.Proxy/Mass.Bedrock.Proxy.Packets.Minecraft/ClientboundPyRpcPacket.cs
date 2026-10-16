using System.Runtime.CompilerServices;
using System.Text;
using Mass.Application.Models;
using Mass.Bedrock.Proxy.Network.Minecraft.Enums;
using Mass.Bedrock.Proxy.Network.Packet;

namespace Mass.Bedrock.Proxy.Packets.Minecraft;

[Packet(EnumPacketDirection.Clientbound, 200u)]
public class ClientboundPyRpcPacket : PyRpcPacket
{
	public override EnumPacketDirection Direction => EnumPacketDirection.Clientbound;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe ClientboundPyRpcPacket()
	{
		//IL_0011: Expected Obj, but got Ref
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		_ = ((EntityLaunchBedrockProxy)(object)this).EqualityContract;
	}
}
