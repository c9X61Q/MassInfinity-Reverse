using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Mass.Game.Proxy.Enums;
using Mass.Game.Proxy.Network.Packet;
using Mass.Game.Proxy.Packets.Common;

namespace Mass.Game.Proxy.Packets.Configuration;

[PacketVersion(EnumProtocolVersion.V1206, 7)]
[PacketVersion(EnumProtocolVersion.V1219, 7)]
[PacketVersion(EnumProtocolVersion.V1211, 7)]
[PacketVersion(EnumProtocolVersion.V1218, 7)]
[Packet(EnumConnectionState.Configuration, EnumPacketDirection.Serverbound)]
public class ServerboundKnownPacksPacket : KnownPacksPacket
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe ServerboundKnownPacksPacket(EnumProtocolVersion version)
	{
		//IL_001a: Expected VT, but got Obj
		//IL_001a: Expected Obj, but got Ref
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		((_003C_003Ef__AnonymousType0<>)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field))._002Ector((_003Caction_003Ej__TPar)this);
	}
}
