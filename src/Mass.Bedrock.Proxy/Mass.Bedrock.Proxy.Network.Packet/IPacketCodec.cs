namespace Mass.Bedrock.Proxy.Network.Packet;

public interface IPacketCodec
{
	byte[] ProcessBytes(byte[] bytes);
}
