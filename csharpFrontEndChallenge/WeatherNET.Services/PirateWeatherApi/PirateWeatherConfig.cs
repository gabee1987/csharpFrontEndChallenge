namespace WeatherNET.Services.PirateWeatherApi
{
    public static class PirateWeatherConfig
    {
        public static readonly string BaseUrl = "https://api.pirateweather.net/forecast/";
        public static readonly string ApiKey  = Environment.GetEnvironmentVariable( "PIRATE_WEATHER_API_KEY" );
    }
}
