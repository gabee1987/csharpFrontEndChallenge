using WeatherNET.Models.WeatherForecast;

namespace WeatherNET.App.Models.Weather
{
    public class HourlyDataViewModel
    {
        public HourlyWeatherData HourlyData { get; set; }


        #region Display Helpers
        public double ColumnHeightValue { get; set; }
        public List<HourlyDisplayData> DisplayData { get; set; } = new List<HourlyDisplayData>();
        public List<HourlyPrecipDisplayData> PrecipDisplayData { get; set; } = new List<HourlyPrecipDisplayData>();
        public List<HourlyWindDisplayData> WindDisplayData { get; set; } = new List<HourlyWindDisplayData>();
        public string IconClass { get; set; }
        public string Hour { get; set; }
        public double HourlyChartHeightIncrementFactor { get; set; } = 0.7;
        public double HourlyColumnScalingFactor { get; set; } = 0.4;
        public double HourlyWindChartScalingFactor { get; set; } = 1.2;
        public double HourlyWindColumnScalingFactor { get; set; } = 1.0;
        public double MaxTemp { get; set; }
        public double MaxWindGust { get; set; }
        public double AdjustedHourlyChartHeight { get; set; }
        public double AdjustedWindChartHeight { get; set; }
        #endregion
    }

    public class HourlyDisplayData
    {
        public double BarHeightValue { get; set; }
        public double TempValue { get; set; }
        public string IconClass { get; set; }
        public string Hour { get; set; }
        public bool IsDaytime { get; set; }
        public DateTime? SunriseTime { get; set; }
        public DateTime? SunsetTime { get; set; }
    }

    public class HourlyPrecipDisplayData
    {
        public double PrecipChance { get; set; } // In percentage
        public double PrecipVolume { get; set; } // In mm
        public string Hour { get; set; }
        public string FormattedVolume => PrecipVolume == 0 ? "-" : $"{Math.Round( PrecipVolume, 1 )}";
        public string FormattedChance => $"{Math.Round( PrecipChance, 1 )}";
        public bool IsDaytime { get; set; }
    }

    public class HourlyWindDisplayData
    {
        public double BarHeightValue { get; set; }
        public double WindSpeed { get; set; } // In km/h
        public string WindStrength { get; set; } // In words like Calm, intensive etc.
        public double WindDirection { get; set; } // in degree
        public string WindDirectionString { get; set; } // in words
        public double WindBearing { get; set; }
        public double WindGust { get; set; }
        public string Hour { get; set; }
        public bool IsDaytime { get; set; }
    }
}
