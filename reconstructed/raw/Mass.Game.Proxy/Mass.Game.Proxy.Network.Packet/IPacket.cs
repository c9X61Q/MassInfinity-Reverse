using Mass.Game.Proxy.Minecraft;
using Mass.Game.Proxy.Network.Interface;

namespace Mass.Game.Proxy.Network.Packet;

public interface IPacket : IBufferCodec, IBufferSerializable, IBufferDeserializable
{
	bool Handle(Connection connection);
}
