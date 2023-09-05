using WeatherNET.Models.WeatherForecast;
using Microsoft.AspNetCore.Mvc;
using WeatherNET.GeocodingService;
using WeatherNET.Services.PirateWeatherApi.APIService.Interfaces;

namespace WeatherNET.Controllers
{
    public class WeatherController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly IGeocodingService _geocodingService;
        private readonly IPirateWeatherApiService _pirateWeatherApiService;
        private readonly ILogger<WeatherData> _logger;


        public WeatherController(
            IConfiguration configuration,
            IGeocodingService geocodingService,
            IPirateWeatherApiService pirateWeatherApiService,
            ILogger<WeatherData> logger )
        {
            _configuration           = configuration;
            _geocodingService        = geocodingService;
            _pirateWeatherApiService = pirateWeatherApiService;
            _logger                  = logger;
        }

        public IActionResult WeatherIndex()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetCurrentWeather( string? locationName )
        {
            // Validate input
            if ( string.IsNullOrWhiteSpace( locationName ) )
            {
                locationName = "Budapest";
                // Handle invalid input (e.g., return an error view or message)
                //return View( "Error", "Invalid location name provided." );
            }

            // Convert location name to latitude and longitude
            var coordinates = await _geocodingService.GetCoordinatesAsync( locationName );
            var location = new Location
            {
                Latitude  = coordinates.Latitude,
                Longitude = coordinates.Longitude,
                Name      = locationName
            };

            // Fetch weather data
            var currentWeather = await _pirateWeatherApiService.GetCurrentWeatherAsync( location );


            // Pass the weather data to the view
            return View( "CurrentWeather", currentWeather );
        }
    }
}
