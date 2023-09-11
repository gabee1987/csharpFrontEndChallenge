using WeatherNET.Models.WeatherForecast;
using Microsoft.AspNetCore.Mvc;
using WeatherNET.App.Models;
using WeatherNET.Services.WeatherService;

namespace WeatherNET.Controllers
{
    public class WeatherController : Controller
    {
        private readonly IConfiguration _configuration;             
        private readonly ILogger<WeatherData> _logger;
        private readonly IWeatherService _weatherService;


        public WeatherController( IConfiguration configuration, ILogger<WeatherData> logger, IWeatherService weatherService )
        {
            _configuration  = configuration;
            _logger         = logger;
            _weatherService = weatherService;
        }

        public IActionResult WeatherIndex()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetWeather( string? locationName )
        {
            // TODO need to create a proper inital page for the first time start
            // Validate input
            if ( string.IsNullOrWhiteSpace( locationName ) )
            {
                locationName = "Budapest";
                // Handle invalid input (e.g., return an error view or message)
                //return View( "Error", "Invalid location name provided." );
            }

            var weatherData = await _weatherService.GetWeatherAsync( locationName );
            

            //var viewModel = new CurrentWeatherViewModel
            //{
            //    Currently   = weatherData.Currently,
            //    Location    = weatherData.Location,
            //    DisplayUnit = "metric"
            //};


            // Pass the weather data to the view
            return View( "Weather", weatherData );
        }
    }
}
