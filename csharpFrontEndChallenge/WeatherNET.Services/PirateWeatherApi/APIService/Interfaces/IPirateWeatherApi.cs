using Refit;
using WeatherNET.PirateWeatherApi;

namespace WeatherNET.Services.PirateWeatherApi.APIService
{
    public interface IPirateWeatherApi
    {
        /// <summary>
        /// Get all weather data including current, minutely, hourly, daily, and alerts.
        /// </summary>
        /// <param name="apiKey">The API key for authentication.</param>
        /// <param name="latitude">The latitude of the location.</param>
        /// <param name="longitude">The longitude of the location.</param>
        /// <returns>Returns all weather data.</returns>
        [Get( "/forecast/{apiKey}/{latitude},{longitude}?units=si" )]
        Task<ApiWeatherData> GetWeatherDataAsync( string apiKey, double latitude, double longitude );

        /// <summary>
        /// Get current weather data.
        /// </summary>
        /// <param name="apiKey">The API key for authentication.</param>
        /// <param name="latitude">The latitude of the location.</param>
        /// <param name="longitude">The longitude of the location.</param>
        /// <returns>Returns current weather data.</returns>
        [Get( "/forecast/{apikey}/{latitude},{longitude}?exclude=minutely,hourly,daily?units=si" )]
        Task<ApiWeatherData> GetCurrentWeatherDataAsync( string apiKey, double latitude, double longitude );

        /// <summary>
        /// Get daily weather data.
        /// </summary>
        /// <param name="apiKey">The API key for authentication.</param>
        /// <param name="latitude">The latitude of the location.</param>
        /// <param name="longitude">The longitude of the location.</param>
        /// <returns>Returns daily weather data.</returns>
        [Get( "/forecast/{apiKey}/{latitude},{longitude}?exclude=currently,minutely,hourly&units=si" )]
        Task<ApiWeatherData> GetDailyWeatherDataAsync( string apiKey, double latitude, double longitude );

        /// <summary>
        /// Get hourly weather data.
        /// </summary>
        /// <param name="apiKey">The API key for authentication.</param>
        /// <param name="latitude">The latitude of the location.</param>
        /// <param name="longitude">The longitude of the location.</param>
        /// <returns>Returns hourly weather data.</returns>
        [Get( "/forecast/{apiKey}/{latitude},{longitude}?exclude=currently,minutely,daily&units=si" )]
        Task<ApiWeatherData> GetHourlyWeatherDataAsync( string apiKey, double latitude, double longitude );

        /// <summary>
        /// Get minutely weather data.
        /// </summary>
        /// <param name="apiKey">The API key for authentication.</param>
        /// <param name="latitude">The latitude of the location.</param>
        /// <param name="longitude">The longitude of the location.</param>
        /// <returns>Returns minutely weather data.</returns>
        [Get( "/forecast/{apiKey}/{latitude},{longitude}?exclude=currently,hourly,daily&units=si" )]
        Task<ApiWeatherData> GetMinutelyWeatherDataAsync( string apiKey, double latitude, double longitude );
    }
}
