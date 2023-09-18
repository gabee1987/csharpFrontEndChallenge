using WeatherNET.Models.WeatherForecast;
using Microsoft.AspNetCore.Mvc;
using WeatherNET.Services.WeatherService;
using WeatherNET.Services.Exceptions_Models;
using AutoMapper;
using WeatherNET.App.Services;
using WeatherNET.App.Models.Weather;

namespace WeatherNET.Controllers
{
    public class WeatherController : Controller
    {
        private readonly IConfiguration _configuration;             
        private readonly ILogger<WeatherData> _logger;
        private readonly IWeatherService _weatherService;
        private readonly IMapper _mapper;
        private readonly IWeatherDisplayService _weatherDisplayService;


        public WeatherController( 
            IConfiguration configuration,
            ILogger<WeatherData> logger,
            IWeatherService weatherService,
            IMapper mapper,
            IWeatherDisplayService weatherDisplayService )
        {
            _configuration         = configuration;
            _logger                = logger;
            _weatherService        = weatherService;
            _mapper                = mapper;
            _weatherDisplayService = weatherDisplayService;
        }

        public IActionResult WeatherIndex()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetWeatherByLocationName( string? locationName )
        {
            try
            {
                locationName ??= _configuration.GetValue<string>( "DefaultLocation" );

                var weatherData = await _weatherService.GetWeatherAsync( locationName );

                if ( weatherData == null )
                {
                    _logger.LogWarning( $"No weather data found for location: {locationName}" );
                    return NotFound( $"No weather data found for location: {locationName}" );
                }

                var weatherViewModel = _mapper.Map<WeatherViewModel>( weatherData );

                // Calculate display related values
                _weatherDisplayService.CalculateHourlyChartHeight( weatherViewModel.Hourly, weatherViewModel.Hourly.ChartHeightIncrementFactor );
                _weatherDisplayService.CalculateHourlyChartBarHeight( weatherViewModel.Hourly, weatherViewModel.Hourly.ColumnScalingFactor );

                return View( "Weather", weatherViewModel );
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

        [HttpGet]
        public async Task<IActionResult> GetWeatherByCoordinates( double latitude, double longitude )
        {
            try
            {
                var weatherData = await _weatherService.GetWeatherBasedOnCoordsAsync( latitude, longitude );

                if ( weatherData == null )
                {
                    _logger.LogWarning( $"No weather data found for location - Latitude: {latitude}, Longitude: {longitude}" );
                    return NotFound( new { message = $"No weather data found for location - Latitude: {latitude}, Longitude: {longitude}" } );
                }

                var weatherViewModel = _mapper.Map<WeatherViewModel>( weatherData );

                // Calculate display related values
                _weatherDisplayService.CalculateHourlyChartHeight( weatherViewModel.Hourly, weatherViewModel.Hourly.ChartHeightIncrementFactor );
                _weatherDisplayService.CalculateHourlyChartBarHeight( weatherViewModel.Hourly, weatherViewModel.Hourly.ColumnScalingFactor );

                return View( "Weather", weatherViewModel );
            }
            catch ( InvalidLocationException ex ) // Custom exception for invalid locations
            {
                _logger.LogError( ex, $"Invalid location provided - Latitude: {latitude}, Longitude: {longitude}" );
                return BadRequest( new { message = $"Invalid location - Latitude: {latitude}, Longitude: {longitude}" } );
            }
            catch ( Exception ex ) // General exception handler
            {
                _logger.LogError( ex, "An error occurred while fetching weather data." );
                return StatusCode( 500, new { message = "Internal server error. Please try again later." } );
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetWeatherDataAsJson( double latitude, double longitude )
        {
            try
            {
                var weatherData = await _weatherService.GetWeatherBasedOnCoordsAsync( latitude, longitude );

                if ( weatherData == null )
                {
                    _logger.LogWarning( $"No weather data found for location - Latitude: {latitude}, Longitude: {longitude}" );
                    return NotFound( new { message = $"No weather data found for location - Latitude: {latitude}, Longitude: {longitude}" } );
                }

                return Json( weatherData );
            }
            catch ( InvalidLocationException ex ) // Custom exception for invalid locations
            {
                _logger.LogError( ex, $"Invalid location provided - Latitude: {latitude}, Longitude: {longitude}" );
                return BadRequest( new { message = $"Invalid location - Latitude: {latitude}, Longitude: {longitude}" } );
            }
            catch ( Exception ex ) // General exception handler
            {
                _logger.LogError( ex, "An error occurred while fetching weather data." );
                return StatusCode( 500, new { message = "Internal server error. Please try again later." } );
            }
        }
    }
}
