namespace csharpFrontEndChallenge.Models.WeatherForecast
{
    public class WeatherForecast
    {
        public Location Location { get; set; }
        public string TimeZone { get; set; }
        public double Offset { get; set; }
        public double Elevation { get; set; }
        public WeatherTypeData Currently { get; set; }
        public WeatherTypeData Minutely { get; set; }
        public WeatherTypeData Hourly { get; set; }
        public WeatherTypeData Daily { get; set; }
    }
}
