using Mass.Game.Proxy.Network.Interface;

namespace Mass.Game.Proxy.Network.Command.Parsers;

public interface IParser : IBufferCodec, IBufferSerializable, IBufferDeserializable
{
}
