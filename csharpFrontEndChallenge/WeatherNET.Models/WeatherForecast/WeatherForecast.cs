using WeatherNET.Models.WeatherForecast.API;

namespace WeatherNET.Models.WeatherForecast
{
    public class WeatherForecast
    {
        /// <summary>
        /// Location data based on Latitude and Longitude
        /// </summary>
        public Location Location { get; set; }       

        /// <summary>
        /// A block containing the current weather for the requested location.
        /// </summary>
        public CurrentlyData Currently { get; set; }

        /// <summary>
        /// A block containing the minute-by-minute precipitation intensity for the 60 minutes.
        /// </summary>
        public MinutelyData Minutely { get; set; }

        /// <summary>
        /// A block containing the hour-by-hour forecasted conditions for the next 48 hours.
        /// </summary>
        public HourlyData Hourly { get; set; }

        /// <summary>
        /// A block containing the day-by-day forecasted conditions for the next 7 days.
        /// </summary>
        public DailyData Daily { get; set; }

        /// <summary>
        /// A list containing any severe weather alerts if any for the current location.
        /// </summary>
        public List<Alert> Alerts { get; set; } = new List<Alert>();

        /// <summary>
        /// A block containing miscellaneous data for the API request.
        /// </summary>
        public ApiFlag Flags { get; set; }
    }
}
