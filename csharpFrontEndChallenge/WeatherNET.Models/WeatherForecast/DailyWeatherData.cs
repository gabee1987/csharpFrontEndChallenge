namespace WeatherNET.Models.WeatherForecast
{
    // All the time values are in UNIX format here
    public class DailyWeatherData
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

        public List<PerDayWeatherData> Data { get; set; } = new List<PerDayWeatherData>();
    }
}
