namespace WeatherNET.GeocodingService
{
    internal class Configs
    {
        // Google Maps
        public static readonly string GoogleApiBaseUrl = "https://maps.googleapis.com";
        public static readonly string GoogleMapsApiKey = Environment.GetEnvironmentVariable( "GOOGLE_GEOCODING_API_KEY" );
    }
}
