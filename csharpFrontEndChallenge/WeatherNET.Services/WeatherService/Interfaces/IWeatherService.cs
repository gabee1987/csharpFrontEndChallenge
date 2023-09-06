using WeatherNET.Models.WeatherForecast;

namespace WeatherNET.Services.WeatherService
{
    public interface IWeatherService
    {
        Task<WeatherData> GetWeatherAsync( string locationName );
        Task<CurrentlyWeatherData> GetCurrentWeatherAsync( string locationName, string unitPreference );
        Task<DailyWeatherData> GetDailyWeatherAsync( string locationName, string unitPreference );
        Task<HourlyWeatherData> GetHourlyWeatherAsync( string locationName, string unitPreference );
        Task<MinutelyWeatherData> GetMinutelyWeatherAsync( string locationName, string unitPreference );
    }
}
