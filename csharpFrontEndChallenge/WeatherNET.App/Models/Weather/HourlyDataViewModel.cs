using WeatherNET.Models.WeatherForecast;

namespace WeatherNET.App.Models.Weather
{
    public class HourlyDataViewModel
    {
        public HourlyWeatherData HourlyData { get; set; }


        #region Display Helpers
        public double ColumnHeightValue { get; set; }
        public List<HourlyDisplayData> DisplayData { get; set; } = new List<HourlyDisplayData>();
        public string IconClass { get; set; }
        public string Hour { get; set; }
        public double ColumnScalingFactor { get; set; } = 0.4;
        public double ChartHeightIncrementFactor { get; set; } = 0.7;
        public double MaxTemp { get; set; }
        public double AdjustedChartHeight { get; set; }
        #endregion
    }

    public class HourlyDisplayData
    {
        public double HeightValue { get; set; }
        public string IconClass { get; set; }
        public string Hour { get; set; }
        public bool IsDaytime { get; set; }
        public DateTime? SunriseTime { get; set; }
        public DateTime? SunsetTime { get; set; }
    }
}
