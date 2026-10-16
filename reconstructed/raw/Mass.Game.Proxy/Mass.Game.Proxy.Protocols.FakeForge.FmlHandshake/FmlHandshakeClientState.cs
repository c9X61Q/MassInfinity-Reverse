namespace Mass.Game.Proxy.Protocols.FakeForge.FmlHandshake;

public enum FmlHandshakeClientState
{
	Start,
	Hello,
	WaitingServerData,
	WaitingServerComplete,
	PendingComplete,
	Complete,
	Done,
	Error
}
