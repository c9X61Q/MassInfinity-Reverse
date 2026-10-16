using System.Text.Json.Serialization;
using Mass.Game.Proxy.Network.Converters;
using Mass.Game.Proxy.Network.Interface;

namespace Mass.Game.Proxy.Network.Component.Structured;

[JsonConverter(typeof(InterfaceConverter<IComponent>))]
public interface IComponent : IBufferCodec, IBufferSerializable, IBufferDeserializable
{
}
