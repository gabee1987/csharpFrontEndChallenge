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
            // Convert location name to latitude and longitude
            var coordinates = await _geocodingService.GetCoordinatesAsync( locationName );
            var location = new Location
            {
                Latitude  = coordinates.Latitude,
                Longitude = coordinates.Longitude,
                Name      = locationName
            };

            // Fetch weather data
            var weatherData = await _pirateWeatherApiService.GetWeatherAsync( location );

            
            // TODO do the unit conversions here with a UnitConversion service

            return weatherData;
        }

        public async Task<CurrentlyWeatherData> GetCurrentWeatherAsync( string locationName, string unitPreference )
        {
            throw new NotImplementedException();
        }

        public async Task<DailyWeatherData> GetDailyWeatherAsync( string locationName, string unitPreference )
        {
            throw new NotImplementedException();
        }

        public async Task<HourlyWeatherData> GetHourlyWeatherAsync( string locationName, string unitPreference )
        {
            throw new NotImplementedException();
        }

        public async Task<MinutelyWeatherData> GetMinutelyWeatherAsync( string locationName, string unitPreference )
        {
            throw new NotImplementedException();
        }
    }
}
