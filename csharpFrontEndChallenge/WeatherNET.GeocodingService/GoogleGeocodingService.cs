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
            _api    = RestService.For<IGoogleGeocodingApi>( Configs.GoogleApiBaseUrl );
        }


        public async Task<string> GetLocationNameAsync( double latitude, double longitude )
        {
            var response = await _api.GetLocationNameAsync( latitude, longitude, _config.ApiKey );

            if ( response.Status != "OK" || !response.Results.Any() )
            {
                throw new Exception( "Failed to get location name from Google Geocoding API." );
            }

            return response.Results.First().FormattedAddress;
        }

        public async Task<(double Latitude, double Longitude)> GetCoordinatesAsync( string locationName )
        {
            var response = await _api.GetCoordinatesAsync( locationName, _config.ApiKey );

            if ( response.Status != "OK" || !response.Results.Any() )
            {
                throw new Exception( "Failed to get coordinates from Google Geocoding API." );
            }

            var location = response.Results.First().Geometry.Location;

            return (location.Lat, location.Lng);
        }
    }
}
