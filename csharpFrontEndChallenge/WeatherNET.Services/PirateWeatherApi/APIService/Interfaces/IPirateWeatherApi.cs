using Refit;
using WeatherNET.PirateWeatherApi;

namespace WeatherNET.Services.PirateWeatherApi.APIService
{
    public interface IPirateWeatherApi
    {
        [Get( "https://api.pirateweather.net/forecast/{apiKey}/{latitude},{longitude}" )]
        Task<ApiWeatherData> GetWeatherDataAsync( string apiKey, double latitude, double longitude );
    }
}
