namespace WeatherNET.Models.WeatherForecast
{
    public class MinutelyWeatherData
    {
        /// <summary>
        /// A human-readable summary describing the weather conditions for a given data point.
        /// </summary>
        public string Summary { get; set; }

        /// <summary>
        /// One of a set of icons to provide a visual display of what's happening.
        /// This could be one of: clear-day, clear-night, rain, snow, sleet, wind, fog, cloudy, partly-cloudy-day, partly-cloudy-night.
        /// </summary>
        public string Icon { get; set; }

        public List<PerMinuteWeatherData> Data { get; set; } = new List<PerMinuteWeatherData>();
    }
}
