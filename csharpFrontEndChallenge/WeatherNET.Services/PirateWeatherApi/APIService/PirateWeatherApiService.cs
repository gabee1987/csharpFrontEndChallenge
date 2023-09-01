using WeatherNET.Models.WeatherForecast;
using WeatherNET.Services.PirateWeatherApi.APIService.Interfaces;

namespace WeatherNET.Services.PirateWeatherApi.APIService
{
    public class PirateWeatherApiService : IPirateWeatherApiService
    {
        public Task<CurrentlyWeatherData> GetCurrentWeatherAsync( Location location )
        {
            throw new NotImplementedException();
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
