namespace Mass.Game.Proxy.Protocols.FakeForge.FmlHandshake;

public enum FmlHandshakeServerState
{
	Start,
	Hello,
	WaitingAck,
	Complete,
	Done,
	Error
}
