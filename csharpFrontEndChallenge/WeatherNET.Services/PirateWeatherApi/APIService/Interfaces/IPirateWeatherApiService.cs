using WeatherNET.Models.WeatherForecast;

namespace WeatherNET.Services.PirateWeatherApi.APIService.Interfaces
{
    public interface IPirateWeatherApiService
    {
        Task<CurrentlyWeatherData> GetCurrentWeatherAsync( Location location );
        Task<HourlyWeatherData> GetMinutelyWeatherAsync( Location location );
        Task<HourlyWeatherData> GetHourlyWeatherAsync( Location location );
        Task<DailyWeatherData> GetDailyWeatherAsync( Location location );

    }
}
