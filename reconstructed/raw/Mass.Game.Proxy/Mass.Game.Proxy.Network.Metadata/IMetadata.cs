using System.Text.Json.Serialization;
using Mass.Game.Proxy.Network.Converters;
using Mass.Game.Proxy.Network.Interface;

namespace Mass.Game.Proxy.Network.Metadata;

[JsonConverter(typeof(InterfaceConverter<IMetadata>))]
public interface IMetadata : IBufferCodec, IBufferSerializable, IBufferDeserializable
{
}
