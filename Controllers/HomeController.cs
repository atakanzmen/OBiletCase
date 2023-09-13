using Microsoft.AspNetCore.Mvc;
using ObiletCase.Services;

namespace ObiletCase.Controllers;
public class HomeController : Controller
{
    private readonly LocationService _locationService;

    public HomeController(LocationService locationService)
    {
        _locationService = locationService;
    }

    public async Task<IActionResult> Index()
    {
		HttpContext.Session.GetInt32("origin");
		HttpContext.Session.GetInt32("destination");

		var data = await _locationService.GetBusLocations();
        return View(data);
    }

    public IActionResult SessionUpdate(int originId, int destinationId, string originText, string destinationText)
    {
		HttpContext.Session.SetInt32("origin", originId);
		HttpContext.Session.SetInt32("destination", destinationId);
		HttpContext.Session.SetString("originText", originText);
		HttpContext.Session.SetString("destinationText", destinationText);

        return NoContent();
	}
}