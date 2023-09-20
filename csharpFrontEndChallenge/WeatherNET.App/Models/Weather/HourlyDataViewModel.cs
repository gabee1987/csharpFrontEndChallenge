﻿using WeatherNET.Models.WeatherForecast;

namespace WeatherNET.App.Models.Weather
{
    public class HourlyDataViewModel
    {
        public HourlyWeatherData HourlyData { get; set; }


        #region Display Helpers
        public double ColumnHeightValue { get; set; }
        public List<HourlyDisplayData> DisplayData { get; set; } = new List<HourlyDisplayData>();
        public List<HourlyPrecipDisplayData> PrecipDisplayData { get; set; } = new List<HourlyPrecipDisplayData>();
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

    public class HourlyPrecipDisplayData
    {
        public double PrecipChance { get; set; } // In percentage
        public double PrecipVolume { get; set; } // In mm
        public string Hour { get; set; }
        public string FormattedVolume => PrecipVolume == 0 ? "-" : $"{Math.Round( PrecipVolume, 1 )}";
        public string FormattedChance => $"{Math.Round( PrecipChance, 1 )}";
        public bool IsDaytime { get; set; }
    }
}
