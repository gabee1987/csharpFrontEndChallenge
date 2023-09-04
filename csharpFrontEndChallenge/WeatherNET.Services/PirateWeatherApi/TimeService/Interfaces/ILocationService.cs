namespace WeatherNET.Services.PirateWeatherApi.TimeService.Interfaces
{
    public interface ILocationService
    {
        Task<string> GetLocationNameAsync( double latitude, double longitude );
    }
}
