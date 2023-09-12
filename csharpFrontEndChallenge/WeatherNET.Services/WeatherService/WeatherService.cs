using WeatherNET.GeocodingService;
using WeatherNET.Models.WeatherForecast;
using WeatherNET.Services.Exceptions_Models;
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
            var location = await CreateLocationObjectBasedOnLocationNameAsync( locationName );

            // Fetch weather data
            var weatherData = await _pirateWeatherApiService.GetWeatherAsync( location );

            // Put the Location name to the Location object
            AppendLocationName( location, weatherData );


            // TODO do the unit conversions here with a UnitConversion service


            return weatherData;
        }

        public async Task<WeatherData> GetWeatherBasedOnCoordsAsync( double latitude, double longitude )
        {
            // Get Location object from location name
            var location = await CreateLocationObjectBasedOnCoordsAsync( latitude, longitude );

            // Fetch weather data
            var weatherData = await _pirateWeatherApiService.GetWeatherAsync( location );

            // Put the Location name to the Location object
            AppendLocationName( location, weatherData );


            // TODO do the unit conversions here with a UnitConversion service


            return weatherData;
        }

        public async Task<CurrentlyWeatherData> GetCurrentWeatherAsync( string locationName  )
        {
            // Get Location object from location name
            var location = await CreateLocationObjectBasedOnLocationNameAsync( locationName );

            // Fetch weather data
            var weatherData = await _pirateWeatherApiService.GetCurrentWeatherAsync( location );


            // TODO do the unit conversions here with a UnitConversion service

            return weatherData;
        }

        public async Task<DailyWeatherData> GetDailyWeatherAsync( string locationName )
        {
            // Get Location object from location name
            var location = await CreateLocationObjectBasedOnLocationNameAsync( locationName );

            // Fetch weather data
            var weatherData = await _pirateWeatherApiService.GetDailyWeatherAsync( location );


            // TODO do the unit conversions here with a UnitConversion service

            return weatherData;
        }

        public async Task<HourlyWeatherData> GetHourlyWeatherAsync( string locationName )
        {
            // Get Location object from location name
            var location = await CreateLocationObjectBasedOnLocationNameAsync( locationName );

            // Fetch weather data
            var weatherData = await _pirateWeatherApiService.GetHourlyWeatherAsync( location );


            // TODO do the unit conversions here with a UnitConversion service

            return weatherData;
        }

        public async Task<MinutelyWeatherData> GetMinutelyWeatherAsync( string locationName )
        {
            // Get Location object from location name
            var location = await CreateLocationObjectBasedOnLocationNameAsync( locationName );

            // Fetch weather data
            var weatherData = await _pirateWeatherApiService.GetMinutelyWeatherAsync( location );


            // TODO do the unit conversions here with a UnitConversion service

            return weatherData;
        }

        #region Helper Methods
        private async Task<Location> CreateLocationObjectBasedOnLocationNameAsync( string locationName )
        {
            // Get location data from google geocoding
            var locationData = await _geocodingService.GetLocationDataAsync( locationName );

            if ( locationData.Results.First().Geometry.Location.Lat == 0 && locationData.Results.First().Geometry.Location.Lng == 0 )
            {
                throw new InvalidLocationException( $"Invalid location provided: {locationName}" );
            }

            var location = new Location
            {
                Latitude  = locationData.Results.First().Geometry.Location.Lat,
                Longitude = locationData.Results.First().Geometry.Location.Lng,
                Name      = locationData.Results.First().Formatted_Address
            };

            return location;

            // TODO need errorhandling and logging
        }

        private async Task<Location> CreateLocationObjectBasedOnCoordsAsync( double latitude, double longitude )
        {
            // Convert location name to latitude and longitude
            var locationData = await _geocodingService.GetLocationDataAsync( latitude, longitude );

            if ( string.IsNullOrEmpty( locationData.Results.First().Formatted_Address ) )
            {
                throw new InvalidLocationException( $"Invalid location provided - Latitude: {latitude}, Longitude: {longitude}" );
            }

            var location = new Location
            {
                Latitude  = latitude,
                Longitude = longitude,
                Name      = locationData.Results.First().Formatted_Address
            };

            return location;

            // TODO need errorhandling and logging
        }

        private static void AppendLocationName( Location location, WeatherData? weatherData )
        {
            if ( location != null && weatherData != null )
            {
                weatherData.Location.Name = location.Name;
            }
        }
        #endregion
    }
}
