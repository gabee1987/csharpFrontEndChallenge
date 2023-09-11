using WeatherNET.Models.WeatherForecast;
using Microsoft.AspNetCore.Mvc;
using WeatherNET.App.Models;
using WeatherNET.Services.WeatherService;
using WeatherNET.Services.Exceptions_Models;

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
            try
            {
                locationName ??= "Budapest";

                var weatherData = await _weatherService.GetWeatherAsync( locationName );

                if ( weatherData == null )
                {
                    _logger.LogWarning( $"No weather data found for location: {locationName}" );
                    return NotFound( $"No weather data found for location: {locationName}" );
                }

                return View( "Weather", weatherData );
            }
            catch ( InvalidLocationException ex ) // Custom exception for invalid locations
            {

                _logger.LogError( ex, $"Invalid location provided: {locationName}" );
                return BadRequest( $"Invalid location: {locationName}" );
            }
            catch ( Exception ex ) // General exception handler
            {
                _logger.LogError( ex, "An error occurred while fetching weather data." );
                return StatusCode( 500, "Internal server error. Please try again later." );
            }
        }
    }
}
