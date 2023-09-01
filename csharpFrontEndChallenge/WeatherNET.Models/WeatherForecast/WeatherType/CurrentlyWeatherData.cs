namespace WeatherNET.Models.WeatherForecast
{
    public class CurrentlyData : BaseWeatherData
    {
        /// <summary>
        /// The approximate distance to the nearest storm in kilometers or miles depending on the requested units.
        /// </summary>
        public double NearestStormDistance { get; set; }

        /// <summary>
        /// The approximate direction in degrees in which a storm is travelling with 0° representing true north.
        /// </summary>
        public double NearestStormBearing { get; set; }
    }
}
