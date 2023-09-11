using WeatherNET.GeocodingService;
using WeatherNET.Models.WeatherForecast;
using WeatherNET.Services.PirateWeatherApi.APIService;
using WeatherNET.Services.PirateWeatherApi.TimeService;

namespace WeatherNET.Services.WeatherService
{
    public class WeatherService : IWeatherService
    {
        private readonly IPirateWeatherApiService _pirateWeatherApiService;
        private readonly IGeocodingService _geocodingService;
        private readonly ITimeService _timeService;


        public WeatherService( IGeocodingService geocodingService,
            IPirateWeatherApiService pirateWeatherApiService,
            ITimeService timeService )
        {
            _pirateWeatherApiService = pirateWeatherApiService;
            _geocodingService        = geocodingService;
            _timeService             = timeService;
        }

        public async Task<WeatherData> GetWeatherAsync( string locationName )
        {      
            // Get Location object from location name
            var location = await CreateLocationObject( locationName );

            // Fetch weather data
            var weatherData = await _pirateWeatherApiService.GetWeatherAsync( location );

            
            // TODO do the unit conversions here with a UnitConversion service


            return weatherData;
        }

        public async Task<CurrentlyWeatherData> GetCurrentWeatherAsync( string locationName  )
        {
            // Get Location object from location name
            var location = await CreateLocationObject( locationName );

            // Fetch weather data
            var weatherData = await _pirateWeatherApiService.GetCurrentWeatherAsync( location );


            // TODO do the unit conversions here with a UnitConversion service

            return weatherData;
        }

        public async Task<DailyWeatherData> GetDailyWeatherAsync( string locationName )
        {
            // Get Location object from location name
            var location = await CreateLocationObject( locationName );

            // Fetch weather data
            var weatherData = await _pirateWeatherApiService.GetDailyWeatherAsync( location );


            // TODO do the unit conversions here with a UnitConversion service

            return weatherData;
        }

        public async Task<HourlyWeatherData> GetHourlyWeatherAsync( string locationName )
        {
            // Get Location object from location name
            var location = await CreateLocationObject( locationName );

            // Fetch weather data
            var weatherData = await _pirateWeatherApiService.GetHourlyWeatherAsync( location );


            // TODO do the unit conversions here with a UnitConversion service

            return weatherData;
        }

        public async Task<MinutelyWeatherData> GetMinutelyWeatherAsync( string locationName )
        {
            // Get Location object from location name
            var location = await CreateLocationObject( locationName );

            // Fetch weather data
            var weatherData = await _pirateWeatherApiService.GetMinutelyWeatherAsync( location );


            // TODO do the unit conversions here with a UnitConversion service

            return weatherData;
        }

        #region Helper Methods
        private async Task<Location> CreateLocationObject( string locationName )
        {
            // Convert location name to latitude and longitude
            var coordinates = await _geocodingService.GetCoordinatesAsync( locationName );

            var location = new Location
            {
                Latitude  = coordinates.Latitude,
                Longitude = coordinates.Longitude,
                Name      = locationName
            };

            return location;

            // TODO need errorhandling and logging
        }
        #endregion
    }
}
