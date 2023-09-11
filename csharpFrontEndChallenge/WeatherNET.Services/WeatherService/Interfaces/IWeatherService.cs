using WeatherNET.Models.WeatherForecast;

namespace WeatherNET.Services.WeatherService
{
    public interface IWeatherService
    {
        Task<WeatherData> GetWeatherAsync( string locationName );
        Task<CurrentlyWeatherData> GetCurrentWeatherAsync( string locationName );
        Task<DailyWeatherData> GetDailyWeatherAsync( string locationName );
        Task<HourlyWeatherData> GetHourlyWeatherAsync( string locationName );
        Task<MinutelyWeatherData> GetMinutelyWeatherAsync( string locationName );
    }
}
