namespace csharpFrontEndChallenge.Models.WeatherForecast
{
    public class Alert
    {
        /// <summary>
        /// A brief description of the alert.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// An array of strings containing all regions included in the weather alert.
        /// </summary>
        public List<string> Regions { get; set; } = new List<string>();

        /// <summary>
        /// Indicates how severe the weather alert is. Possible values are:
        /// - Extreme - Extraordinary threat to life or property
        /// - Severe - Significant threat to life or property
        /// - Moderate - Possible threat to life or property
        /// - Minor - Minimal threat to life or property
        /// - Unknown
        /// </summary>
        public string Severity { get; set; }

        /// <summary>
        /// The time in which the alert was issued represented in UNIX time.
        /// </summary>
        public DateTime Time { get; set; }

        /// <summary>
        /// The time in which the alert expires represented in UNIX time.
        /// </summary>
        public DateTime Expires { get; set; }

        /// <summary>
        /// A detailed description of the alert.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// A HTTP(S) url in which you can visit for more information about the alert.
        /// </summary>
        public string Uri { get; set; }
    }
}
