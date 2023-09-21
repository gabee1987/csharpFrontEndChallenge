namespace WeatherNET.Models.WeatherForecast
{
    public class PerMinuteWeatherData
    {
        /// <summary>
        /// The time in which the data point begins.
        /// </summary>
        public DateTime Time { get; set; }

        /// <summary>
        /// The rate in which liquid precipitation is falling. This value is expressed in millimeters per hour or inches per hour depending on the requested units.
        /// </summary>
        public double PrecipIntensity { get; set; }

        /// <summary>
        /// The probability of precipitation occurring expressed as a value between 0 and 1 inclusive.
        /// </summary>
        public double PrecipProbability { get; set; }

        /// <summary>
        /// The standard deviation of the precipitationIntensity.
        /// </summary>
        public double PrecipIntensityError { get; set; }

        /// <summary>
        /// The type of precipitation occurring.
        /// If precipIntensity is greater than zero this property will have one of the following values: rain, snow or sleet otherwise the value will be none. sleet is defined as any precipitation which is neither rain nor snow.
        /// </summary>
        public string PrecipType { get; set; }
    }
}
