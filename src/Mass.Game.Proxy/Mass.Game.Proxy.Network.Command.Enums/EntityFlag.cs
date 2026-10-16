using System;

namespace Mass.Game.Proxy.Network.Command.Enums;

[Flags]
public enum EntityFlag : byte
{
	Single = 1,
	Multiple = 2
}
