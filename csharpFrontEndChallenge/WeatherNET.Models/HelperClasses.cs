namespace WeatherNET.Models
{
    public class HelperClasses
    {
        /// <summary>
        /// One of a set of icons to provide a visual display of what's happening.
        /// This could be one of: clear-day, clear-night, rain, snow, sleet, wind, fog, cloudy, partly-cloudy-day, partly-cloudy-night.
        /// </summary>
        public enum Icon { ClearDay, ClearNight, Rain, Snow, Sleet, Wind, Fog, Cloudy, PartlyCloudyDay, PartlyCloudyNight };

        /// <summary>
        /// The type of precipitation occurring.
        /// If precipIntensity is greater than zero this property will have one of the following values: rain, snow or sleet otherwise the value will be none.
        /// sleet is defined as any precipitation which is neither rain nor snow.
        /// </summary>
        public enum PrecipType { Rain, Snow, Sleet, None };

        //public enum Summary { Clear, Cloudy, PartlyCloudy };
    }
}
