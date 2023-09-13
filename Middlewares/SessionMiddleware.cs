using ObiletCase.Services;

namespace ObiletCase.Middlewares;

public class SessionMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ApplicationSettings _applicationSettings;

    public SessionMiddleware(RequestDelegate next, ApplicationSettings applicationSettings)
    {
        _next = next;
        _applicationSettings = applicationSettings;
    }

    public async Task InvokeAsync(HttpContext httpContext, SessionService sessionService)
    {
        if(_applicationSettings.DeviceSession == null)
        {
            await sessionService.GetSession();
        }

        if (httpContext.Session.GetInt32("origin") == null)
        {
            httpContext.Session.SetInt32("origin", 0);
            httpContext.Session.SetInt32("destination", 0);
            httpContext.Session.SetString("originText", string.Empty);
			httpContext.Session.SetString("destinationText", string.Empty);
        }

        await _next(httpContext);
    }
}