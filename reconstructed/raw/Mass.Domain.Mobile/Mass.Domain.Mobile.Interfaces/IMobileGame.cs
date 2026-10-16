namespace Mass.Domain.Mobile.Interfaces;

public interface IMobileGame
{
	string EntityId { get; set; }

	string Name { get; set; }

	string Description { get; set; }

	int PlayerCount { get; set; }

	string ImageUrl { get; set; }
}
