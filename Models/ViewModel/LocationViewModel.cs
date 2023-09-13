using ObiletCase.Models.Response;

namespace ObiletCase.Models.ViewModel;

public class LocationViewModel
{
	public BusLocation OldOrigin { get; set; }
	public BusLocation OldDestination { get; set; }
	public List<BusLocation> Locations { get; set; }
}