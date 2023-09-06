using Refit;
using WeatherNET.PirateWeatherApi;

namespace WeatherNET.Services.PirateWeatherApi.APIService
{
    public interface IPirateWeatherApi
    {
        [Get( "/forecast/{apiKey}/{latitude},{longitude}?units=si" )]
        Task<ApiWeatherData> GetWeatherDataAsync( string apiKey, double latitude, double longitude );

        [Get( "/forecast/{apiKey}/{latitude},{longitude}?units=si" )]
        Task<ApiWeatherData> GetCurrentWeatherDataAsync( string apiKey, double latitude, double longitude );
    }
}
