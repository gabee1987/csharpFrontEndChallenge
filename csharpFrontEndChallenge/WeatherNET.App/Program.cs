using WeatherNET.Common.Configs;
using WeatherNET.GeocodingService;
using WeatherNET.Services.MappingProfiles;
using WeatherNET.Services.PirateWeatherApi.APIService;
using WeatherNET.Services.PirateWeatherApi.TimeService;
using WeatherNET.Services.WeatherService;
using Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation;
using WeatherNET.App.Models.MappingProfiles;
using WeatherNET.App.Services;
using WeatherNET.App.Services.Interfaces;

var builder = WebApplication.CreateBuilder( args );

// Add services to the container.
builder.Services.AddControllersWithViews();

// Bind configuration sections to classes
var configuration = builder.Configuration;

builder.Services.Configure<GoogleGeocodingConfig>( configuration.GetSection( "GoogleMapsApi" ) );
builder.Services.Configure<PirateWeatherConfig>( configuration.GetSection( "PirateWeatherApi" ) );

// Application Services
builder.Services.AddSingleton<ITimeService, TimeService>();
builder.Services.AddAutoMapper( ( serviceProvider, automapper ) =>
{
    automapper.AddProfile( new WeatherMappingProfile( serviceProvider.GetRequiredService<ITimeService>() ) );
    automapper.AddProfile( new WeatherViewModelMappingProfile() );
}, AppDomain.CurrentDomain.GetAssemblies() );

builder.Services.AddTransient<IGeocodingService, GoogleGeocodingService>();
builder.Services.AddTransient<IPirateWeatherApiService, PirateWeatherApiService>();
builder.Services.AddTransient<IWeatherService, WeatherService>();
builder.Services.AddTransient<IWeatherDisplayService, WeatherDisplayService>();
builder.Services.AddTransient<IWeatherManager, WeatherManager>();
builder.Services.AddSingleton<ITooltipService, TooltipService>();

builder.Services.AddRazorPages().AddRazorRuntimeCompilation();
var app = builder.Build();

// Configure the HTTP request pipeline.
if ( !app.Environment.IsDevelopment() )
{
    app.UseExceptionHandler( "/Home/Error" );
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
else
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}" );

app.Run();
