using WeatherNET.Common.Configs;
using WeatherNET.GeocodingService;

var builder = WebApplication.CreateBuilder( args );

// Add services to the container.
builder.Services.AddControllersWithViews();

// Bind configuration sections to classes
var configuration = builder.Configuration;

builder.Services.Configure<GoogleGeocodingConfig>( configuration.GetSection( "GoogleMaps" ) );
builder.Services.Configure<PirateWeatherConfig>( configuration.GetSection( "PirateWeather" ) );

// Application Services
builder.Services.AddAutoMapper( typeof( WeatherNET.Services.MappingProfiles.WeatherMappingProfile ) );
builder.Services.AddSingleton<IGeocodingService, GoogleGeocodingService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if ( !app.Environment.IsDevelopment() )
{
    app.UseExceptionHandler( "/Home/Error" );
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}" );

app.Run();
