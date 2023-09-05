using AutoMapper;
using Microsoft.Extensions.Options;
using Refit;
using WeatherNET.Common.Configs;
using WeatherNET.Models.WeatherForecast;
using WeatherNET.Services.PirateWeatherApi.APIService.Interfaces;

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
            _api    = RestService.For<IPirateWeatherApi>( _config.PirateWeatherBaseUrl );
        }

        public async Task<CurrentlyWeatherData> GetCurrentWeatherAsync( Location location )
        {
            var apidData = await _api.GetWeatherDataAsync( _config.PirateWeatherApiKey, location.Latitude, location.Longitude );
            return _mapper.Map<CurrentlyWeatherData>( apidData.Currently );
        }

        public Task<DailyWeatherData> GetDailyWeatherAsync( Location location )
        {
            throw new NotImplementedException();
        }

        public Task<HourlyWeatherData> GetHourlyWeatherAsync( Location location )
        {
            throw new NotImplementedException();
        }

        public Task<HourlyWeatherData> GetMinutelyWeatherAsync( Location location )
        {
            throw new NotImplementedException();
        }
    }
}
