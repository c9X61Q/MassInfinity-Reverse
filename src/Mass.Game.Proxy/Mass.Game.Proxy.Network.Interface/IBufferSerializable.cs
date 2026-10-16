using DotNetty.Buffers;

namespace Mass.Game.Proxy.Network.Interface;

public interface IBufferSerializable
{
	void Write(IByteBuffer buffer);
}
