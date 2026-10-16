using System.Threading.Tasks;
using Mass.Game.Proxy.Enums;
using Mass.Game.Proxy.Network.Packet;

namespace Mass.Game.Proxy.Network.Interface;

public interface IConnection
{
	EnumProtocolVersion Version { get; set; }

	EnumConnectionState State { get; set; }

	bool Disposed { get; }

	bool HandlePacket(IPacket packet);

	Task SendPacket(EnumPacketDirection direction, object packet);

	void Disconnect(EnumPacketDirection direction);
}
