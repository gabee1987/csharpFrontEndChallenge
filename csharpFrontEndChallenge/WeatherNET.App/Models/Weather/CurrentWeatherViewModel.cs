using WeatherNET.Models.WeatherForecast;

namespace WeatherNET.App.Models
{
    public class CurrentWeatherViewModel
    {
        public Location Location { get; set; }
        public CurrentlyWeatherData Currently { get; set; }

        public string DisplayUnit { get; set; } // "imperial" or "si"
    }
}
