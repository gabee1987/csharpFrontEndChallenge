using Refit;

namespace WeatherNET.GeocodingService
{
    public interface IGoogleGeocodingApi
    {
        [Get( "/maps/api/geocode/json?latlng={latitude},{longitude}&key={apiKey}" )]
        Task<GoogleGeocodeResponse> GetLocationDataBasedOnCoordinatesAsync( double latitude, double longitude, string apiKey );

        [Get( "/maps/api/geocode/json?address={locationName}&key={apiKey}" )]
        Task<GoogleGeocodeResponse> GetLocationDataBasedOnNameAsync( string locationName, string apiKey );

        //[Get( "/maps/api/geocode/json?latlng={latitude},{longitude}&key={apiKey}" )]
        //Task<GoogleGeocodeResponse> GetLocationNameAsync( double latitude, double longitude, string apiKey );

        //[Get( "/maps/api/geocode/json?address={locationName}&key={apiKey}" )]
        //Task<GoogleGeocodeResponse> GetCoordinatesAsync( string locationName, string apiKey );
    }
}
