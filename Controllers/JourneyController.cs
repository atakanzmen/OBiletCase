using Microsoft.AspNetCore.Mvc;
using ObiletCase.Models.Request;
using ObiletCase.Services;

namespace ObiletCase.Controllers;
public class JourneyController : Controller
{
	private readonly JourneyService _journeyService;

	public JourneyController(JourneyService journeyService)
	{
		_journeyService = journeyService;
	}

	public async Task<IActionResult> Index(int originId, int destinationId, string date)
	{
		if (originId == 0 || destinationId == 0 || string.IsNullOrWhiteSpace(date))
		{
			return BadRequest();
		}

		var result = await _journeyService.GetJourneys(new JourneyDataRequest()
		{
			DepartureDate = date,
			DestinationId = destinationId,
			OriginId = originId
		});

		if (result != null && result.Any())
		{
			return View(result);
		}

		return RedirectToAction("Index", "Home");
	}
}