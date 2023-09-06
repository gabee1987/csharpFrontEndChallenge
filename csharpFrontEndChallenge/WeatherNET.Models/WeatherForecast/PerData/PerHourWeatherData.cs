namespace WeatherNET.Models.WeatherForecast
{
    public  class PerHourWeatherData
    {
        /// <summary>
        /// The time in which the data point begins.
        /// </summary>
        public DateTime Time { get; set; }

        /// <summary>
        /// A human-readable summary describing the weather conditions for a given data point.
        /// </summary>
        public string Summary { get; set; }

        /// <summary>
        /// One of a set of icons to provide a visual display of what's happening.
        /// This could be one of: clear-day, clear-night, rain, snow, sleet, wind, fog, cloudy, partly-cloudy-day, partly-cloudy-night.
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// The approximate distance to the nearest storm in kilometers or miles depending on the requested units.
        /// </summary>
        public double NearestStormDistance { get; set; }

        /// <summary>
        /// The approximate direction in degrees in which a storm is travelling with 0° representing true north.
        /// </summary>
        public double NearestStormBearing { get; set; }

        /// <summary>
        /// The rate in which liquid precipitation is falling. This value is expressed in millimeters per hour or inches per hour depending on the requested units.
        /// </summary>
        public double PrecipIntensity { get; set; }

        /// <summary>
        /// The standard deviation of the precipitationIntensity.
        /// </summary>
        public double PrecipIntensityError { get; set; }

        /// <summary>
        /// The probability of precipitation occurring expressed as a value between 0 and 1 inclusive.
        /// </summary>
        public double PrecipProbability { get; set; }

        /// <summary>
        /// The type of precipitation occurring.
        /// If precipIntensity is greater than zero this property will have one of the following values: rain, snow or sleet otherwise the value will be none. sleet is defined as any precipitation which is neither rain nor snow.
        /// </summary>
        public string PrecipType { get; set; }

        /// <summary>
        /// The air temperature in degrees Celsius or degrees Fahrenheit depending on the requested units
        /// </summary>
        public double Temperature { get; set; }

        /// <summary>
        /// "Feels like" temperature, including either humidex if the temperature is greater than 10C or wind chill if less than 10C.
        /// </summary>
        public double ApparentTemperature { get; set; }

        /// <summary>
        /// The point in which the air temperature needs (assuming constant pressure) in order to reach a relative humidity of 100%.
        /// This is value is represented in degrees Celsius or Fahrenheit depending on the requested units.
        /// </summary>
        public double DewPoint { get; set; }

        /// <summary>
        /// Relative humidity expressed as a value between 0 and 1 inclusive.
        /// This is a percentage of the actual water vapor in the air compared to the total amount of water vapor that can exist at the current temperature.
        /// </summary>
        public double Humidity { get; set; }

        /// <summary>
        /// The sea-level pressure represented in hectopascals or millibars depending on the requested units.
        /// </summary>
        public double Pressure { get; set; }

        /// <summary>
        /// The current wind speed in kilometres per hour or miles per hour depending on the requested units.
        /// </summary>
        public double WindSpeed { get; set; }

        /// <summary>
        /// The wind gust in kilometres per hour or miles per hour depending on the requested units.
        /// </summary>
        public double WindGust { get; set; }

        /// <summary>
        /// The direction in which the wind is blowing in degrees with 0° representing true north.
        /// </summary>
        public double WindBearing { get; set; }

        /// <summary>
        /// Percentage of the sky that is covered in clouds. This value will be between 0 and 1 inclusive.
        /// </summary>
        public double CloudCover { get; set; }

        /// <summary>
        /// The measure of UV radiation as represented as an index starting from 0. 0 to 2 is Low, 3 to 5 is Moderate, 6 and 7 is High, 8 to 10 is Very High and 11+ is considered extreme.
        /// </summary>
        public double UvIndex { get; set; }

        /// <summary>
        /// The visibility in kilometres or miles depending on the requested units.
        /// In the daily block the visibility is the average visibility for the day.
        /// This value is capped at 16 kilometres or 10 miles depending on the requested units.
        /// </summary>
        public double Visibility { get; set; }

        /// <summary>
        /// The density of total atmospheric ozone at a given time in Dobson units.
        /// </summary>
        public double Ozone { get; set; }

        /// <summary>
        /// The amount of liquid precipitation expected to fall over an hour or a day expressed in centimetres or inches depending on the requested units.
        /// </summary>
        public double PrecipAccumulation { get; set; }
    }
}
