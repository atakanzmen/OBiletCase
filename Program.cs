using ObiletCase;
using ObiletCase.Clients;
using ObiletCase.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddSession(options => {
	options.IdleTimeout = TimeSpan.FromMinutes(10);
});

// Register Application
builder.Services.AddSingleton<ApplicationSettings>();

// Register Services
builder.Services.AddScoped<JourneyService>();
builder.Services.AddScoped<LocationService>();
builder.Services.AddScoped<SessionService>();

// Register HttpClient
builder.Services.AddHttpClient<ExternalHttpClient>(httpClient =>
{
    httpClient.BaseAddress = new Uri("https://v2-api.obilet.com/");
    httpClient.Timeout = TimeSpan.FromSeconds(60);
    httpClient.DefaultRequestHeaders.Add("Authorization", "Basic JEcYcEMyantZV095WVc3G2JtVjNZbWx1");
});

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseSession();
app.UseRouting();
app.UseMiddleware<ObiletCase.Middlewares.SessionMiddleware>();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
