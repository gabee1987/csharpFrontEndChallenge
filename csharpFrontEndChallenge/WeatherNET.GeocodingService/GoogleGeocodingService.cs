using Microsoft.Extensions.Options;
using Refit;
using WeatherNET.Common.Configs;

namespace WeatherNET.GeocodingService
{
    public class GoogleGeocodingService : IGeocodingService
    {
        private readonly IGoogleGeocodingApi _api;
        private readonly GoogleGeocodingConfig _config;


        public GoogleGeocodingService( IOptions<GoogleGeocodingConfig> configOptions )
        {
            _config = configOptions.Value;

            // Configure Refit to use Newtonsoft.Json
            var refitSettings = new RefitSettings
            {
                ContentSerializer = new NewtonsoftJsonContentSerializer()
            };

            _api = RestService.For<IGoogleGeocodingApi>( _config.BaseUrl );
        }

        public async Task<GoogleGeocodeResponse> GetLocationDataAsync( string locationName )
        {
            var response = await _api.GetLocationDataBasedOnNameAsync( locationName, _config.ApiKey );

            if ( response.Status != "OK" || !response.Results.Any() )
            {
                throw new Exception( "Failed to get location name from Google Geocoding API." );
            }

            return response;
        }

        public async Task<GoogleGeocodeResponse> GetLocationDataAsync( double latitude, double longitude )
        {
            var response = await _api.GetLocationDataBasedOnCoordinatesAsync( latitude, longitude, _config.ApiKey );

            if ( response.Status != "OK" || !response.Results.Any() )
            {
                throw new Exception( "Failed to get location name from Google Geocoding API." );
            }

            return response;
        }


        public async Task<string> GetLocationNameAsync( double latitude, double longitude )
        {
            var response = await _api.GetLocationDataBasedOnCoordinatesAsync( latitude, longitude, _config.ApiKey );

            if ( response.Status != "OK" || !response.Results.Any() )
            {
                throw new Exception( "Failed to get location name from Google Geocoding API." );
            }

            return response.Results.First().Formatted_Address;
        }

        public async Task<(double Latitude, double Longitude)> GetCoordinatesAsync( string locationName )
        {
            var response = await _api.GetLocationDataBasedOnNameAsync( locationName, _config.ApiKey );

            if ( response.Status != "OK" || !response.Results.Any() )
            {
                throw new Exception( "Failed to get coordinates from Google Geocoding API." );
            }

            var location = response.Results.First().Geometry.Location;

            return ( location.Lat, location.Lng );
        }
    }
}
