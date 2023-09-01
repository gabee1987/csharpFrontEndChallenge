namespace WeatherNET.Models.WeatherForecast
{
    /// <summary>
    /// The location is specified by a latitude (1st) and longitude (2nd) in decimal degrees (ex. 45.42,-75.69).
    /// </summary>
    public class Location
    {
        /// <summary>
        /// The requested latitude.
        /// </summary>
        public double Latitude { get; set; }
        
        /// <summary>
        /// The requested longitude.
        /// </summary>
        public double Longitude { get; set; }
        
        /// <summary>
        /// The calculated location from Latitude and Longitude
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Ex. America/Toronto. The timezone name for the requested location.
        /// </summary>
        public string TimeZone { get; set; }

        /// <summary>
        /// The timezone offset in hours.
        /// </summary>
        public double Offset { get; set; }

        /// <summary>
        /// The height above sea level in meters the requested location is.
        /// </summary>
        public double Elevation { get; set; }
    }
}
