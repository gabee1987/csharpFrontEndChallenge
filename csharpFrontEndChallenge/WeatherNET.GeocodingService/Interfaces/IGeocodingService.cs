namespace WeatherNET.GeocodingService
{
    public interface IGeocodingService
    {
        Task<string> GetLocationNameAsync(double latitude, double longitude);
        Task<(double Latitude, double Longitude)> GetCoordinatesAsync(string locationName);
    }
}
