using Mass.Domain.Desktop.ValueObjects;

namespace Mass.Domain.Desktop.Interfaces;

public interface IDesktopGame
{
	string EntityId { get; set; }

	string Name { get; set; }

	string Author { get; set; }

	string Description { get; set; }

	int PlayerCount { get; set; }

	int MaxCount { get; set; }

	int LikeCount { get; set; }

	string ImageUrl { get; set; }

	EnumGameVersion GameVersion { get; set; }

	EnumGameType GameType { get; set; }
}
