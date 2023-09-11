using AutoMapper;
using Microsoft.Extensions.Options;
using Refit;
using WeatherNET.Common.Configs;
using WeatherNET.Models.WeatherForecast;
using WeatherNET.PirateWeatherApi;

namespace WeatherNET.Services.PirateWeatherApi.APIService
{
    public class PirateWeatherApiService : IPirateWeatherApiService
    {
        private readonly IPirateWeatherApi _api;
        private readonly PirateWeatherConfig _config;
        private readonly IMapper _mapper;

        public PirateWeatherApiService( IOptions<PirateWeatherConfig> configOptions, IMapper mapper )
        {
            _config = configOptions.Value;
            _api    = RestService.For<IPirateWeatherApi>( _config.BaseUrl );
            _mapper = mapper;
        }

        public async Task<WeatherData> GetWeatherAsync( Location location )
        {
            var apiData = await FetchApiData( _api.GetWeatherDataAsync, location );
            return _mapper.Map<WeatherData>( apiData );
        }

        public async Task<CurrentlyWeatherData> GetCurrentWeatherAsync( Location location )
        {
            var apidData = await FetchApiData( _api.GetCurrentWeatherDataAsync, location );
            return _mapper.Map<CurrentlyWeatherData>( apidData.Currently );
        }

        public async Task<DailyWeatherData> GetDailyWeatherAsync( Location location )
        {
            var apiData = await FetchApiData( _api.GetDailyWeatherDataAsync, location );
            return _mapper.Map<DailyWeatherData>( apiData.Daily );
        }

        public async Task<HourlyWeatherData> GetHourlyWeatherAsync( Location location )
        {
            var apiData = await FetchApiData( _api.GetHourlyWeatherDataAsync, location );
            return _mapper.Map<HourlyWeatherData>( apiData.Hourly );
        }

        public async Task<MinutelyWeatherData> GetMinutelyWeatherAsync( Location location )
        {
            var apiData = await FetchApiData( _api.GetMinutelyWeatherDataAsync, location );
            return _mapper.Map<MinutelyWeatherData>( apiData.Minutely );
        }



        #region Helper methods
        private async Task<ApiWeatherData> FetchApiData( Func<string, double, double, Task<ApiWeatherData>> apiMethod, Location location )
        {
            if ( string.IsNullOrWhiteSpace( _config.BaseUrl ) )
            {
                throw new ArgumentException( "PirateWeatherBaseUrl is not set in the configuration." );
            }
            return await apiMethod( _config.ApiKey, location.Latitude, location.Longitude );
        }
        #endregion
    }
}
