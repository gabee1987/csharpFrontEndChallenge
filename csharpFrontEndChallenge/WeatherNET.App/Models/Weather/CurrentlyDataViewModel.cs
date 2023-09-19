using WeatherNET.Models.WeatherForecast;

namespace WeatherNET.App.Models.Weather
{
    public class CurrentlyDataViewModel
    {
        public CurrentlyWeatherData CurrentlyData { get; set; }

        #region Display Helpers
        public string UvIndexDisplay { get; set; }
        #endregion
    }
}
