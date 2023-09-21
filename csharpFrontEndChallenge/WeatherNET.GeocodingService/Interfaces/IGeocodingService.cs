namespace WeatherNET.GeocodingService
{
    public interface IGeocodingService
    {
        Task<GoogleGeocodeResponse> GetLocationDataAsync( string locationName );
        Task<GoogleGeocodeResponse> GetLocationDataAsync( double latitude, double longitude );
        Task<string> GetLocationNameAsync( double latitude, double longitude );
        Task<(double Latitude, double Longitude)> GetCoordinatesAsync( string locationName );
    }
}
