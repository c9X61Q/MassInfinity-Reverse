using System;

namespace Mass.Domain.Desktop.Interfaces;

public interface IDesktopGameCharacter
{
	string GameId { get; set; }

	string Name { get; set; }

	DateTime CreateTime { get; set; }
}
