namespace csharpFrontEndChallenge.Models.WeatherForecast
{
    public class ApiFlag
    {
        /// <summary>
        /// The models used to generate the forecast.
        /// </summary>   
        public List<string> Sources { get; set; }

        /// <summary>
        /// The time in UTC when the model was last updated.
        /// </summary>
        public Dictionary<string, string> SourceTimes { get; set; }

        /// <summary>
        /// The distance in miles or kilometres to the closest station used in the request.
        /// </summary>
        public double NearestStation { get; set; }

        /// <summary>
        /// Indicates which units were used in the forecasts.
        /// </summary>
        public string Units { get; set; }

        /// <summary>
        /// The version of PirateWeather used to generate the forecast.
        /// </summary>
        public string Version { get; set; }
    }
}
