using Refit;

namespace WeatherNET.GeocodingService
{
    public interface IGoogleGeocodingApi
    {
        [Get( "/maps/api/geocode/json?latlng={latitude},{longitude}&key={apiKey}" )]
        Task<GeocodingResponse> GetLocationNameAsync( double latitude, double longitude, string apiKey );

        [Get( "/maps/api/geocode/json?address={locationName}&key={apiKey}" )]
        Task<GeocodingResponse> GetCoordinatesAsync( string locationName, string apiKey );
    }
}
