namespace Mass.Domain.Desktop.Interfaces;

public interface IDesktopSkin
{
	string EntityId { get; set; }

	string Name { get; set; }

	string BriefSummary { get; set; }

	string ImageUrl { get; set; }
}
