using DotNetty.Buffers;

namespace Mass.Game.Proxy.Network.Interface;

public interface IBufferDeserializable
{
	void Read(IByteBuffer buffer);
}
