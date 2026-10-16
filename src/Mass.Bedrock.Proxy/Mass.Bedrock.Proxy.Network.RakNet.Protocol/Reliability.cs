namespace Mass.Bedrock.Proxy.Network.RakNet.Protocol;

public enum Reliability : byte
{
	Unreliable,
	UnreliableSequenced,
	Reliable,
	ReliableOrdered,
	ReliableSequenced
}
