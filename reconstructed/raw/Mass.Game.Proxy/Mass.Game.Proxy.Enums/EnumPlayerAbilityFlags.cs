using System;

namespace Mass.Game.Proxy.Enums;

[Flags]
public enum EnumPlayerAbilityFlags : byte
{
	None = 0,
	Invulnerable = 1,
	Flying = 2,
	AllowFlying = 4,
	Creative = 8
}
