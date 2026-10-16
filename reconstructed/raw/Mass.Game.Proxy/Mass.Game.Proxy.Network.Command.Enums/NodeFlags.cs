using System;

namespace Mass.Game.Proxy.Network.Command.Enums;

[Flags]
public enum NodeFlags : byte
{
	None = 0,
	Root = 0,
	Literal = 1,
	Argument = 2,
	Executable = 4,
	HasRedirect = 8,
	HasSuggestions = 0x10,
	Restricted = 0x20
}
