namespace Mass.Bedrock.Proxy.Network.Packet;

public enum RakNetPacketId
{
	ConnectedPing = 0,
	UnconnectedPing1 = 1,
	UnconnectedPing2 = 2,
	ConnectedPong = 3,
	UnconnectedPong = 28,
	OpenConnectionRequest1 = 5,
	OpenConnectionReply1 = 6,
	OpenConnectionRequest2 = 7,
	OpenConnectionReply2 = 8,
	ConnectionRequest = 9,
	ConnectionRequestAccepted = 16,
	AlreadyConnected = 18,
	NewIncomingConnection = 19,
	DisconnectionNotification = 21,
	IncompatibleProtocolVersion = 25,
	FrameSetPacketBegin = 128,
	FrameSetPacketEnd = 143,
	Nack = 160,
	Ack = 192,
	Game = 254
}
