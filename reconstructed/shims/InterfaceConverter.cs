// 缺口占位声明（**不是官方实现**）。见 ../../docs/可编译性-缺口台账.md
using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Mass.Game.Proxy.Network.Converters;

/// <summary>占位：官方实现在被 DNGuard 保护的方法集内（未还原）。</summary>
public class InterfaceConverter<T> : JsonConverter<T>
{
    public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        => throw new NotImplementedException("InterfaceConverter<T>.Read 未还原（DNGuard HVM 保护）");
    public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
        => throw new NotImplementedException("InterfaceConverter<T>.Write 未还原（DNGuard HVM 保护）");
}
