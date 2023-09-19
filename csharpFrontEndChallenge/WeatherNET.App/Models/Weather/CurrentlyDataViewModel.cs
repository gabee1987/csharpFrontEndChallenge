using WeatherNET.Models.WeatherForecast;

namespace WeatherNET.App.Models.Weather
{
    public class CurrentlyDataViewModel
    {
        public CurrentlyWeatherData CurrentlyData { get; set; }

        #region Display Helpers
        public string UvIndexDisplay { get; set; }


        // Tooltip properties
        public string TimeTooltip { get; set; }
        public string SummaryTooltip { get; set; }
        public string IconTooltip { get; set; }
        public string NearestStormDistanceTooltip { get; set; }
        public string NearestStormBearingTooltip { get; set; }
        public string PrecipIntensityTooltip { get; set; }
        public string PrecipIntensityErrorTooltip { get; set; }
        public string PrecipProbabilityTooltip { get; set; }
        public string PrecipTypeTooltip { get; set; }
        public string TemperatureTooltip { get; set; }
        public string ApparentTemperatureTooltip { get; set; }
        public string DewPointTooltip { get; set; }
        public string HumidityTooltip { get; set; }
        public string PressureTooltip { get; set; }
        public string WindSpeedTooltip { get; set; }
        public string WindGustTooltip { get; set; }
        public string WindBearingTooltip { get; set; }
        public string CloudCoverTooltip { get; set; }
        public string UvIndexTooltip { get; set; }
        public string VisibilityTooltip { get; set; }
        public string OzoneTooltip { get; set; }
        public string PrecipAccumulationTooltip { get; set; }
        #endregion
    }
}
