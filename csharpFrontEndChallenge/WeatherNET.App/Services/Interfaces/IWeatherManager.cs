using WeatherNET.App.Models.Weather;

namespace WeatherNET.App.Services.Interfaces
{
    public interface IWeatherManager
    {
        Task<WeatherViewModel> GetWeatherViewModelByLocationName( string locationName );
        Task<WeatherViewModel> GetWeatherViewModelByCoordinates( double latitude, double longitude );
    }
}
