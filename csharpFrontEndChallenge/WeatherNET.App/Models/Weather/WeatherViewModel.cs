using WeatherNET.App.Models.Weather;
using WeatherNET.Models.WeatherForecast;

namespace WeatherNET.App.Models.Weather
{
    public class WeatherViewModel
    {
        public Location Location { get; set; }
        public CurrentlyDataViewModel Currently { get; set; }
        public DailyDataViewModel Daily { get; set; }
        public HourlyDataViewModel Hourly { get; set; }
        public MinutelyDataViewModel Minutely { get; set; }
        public List<Alert> Alerts { get; set; } = new List<Alert>();
        public Flags Flags { get; set; }


        #region Display Helpers
        public string DisplayUnit { get; set; } // "imperial" or "si"
        public bool IsDayTime { get; set; }
        #endregion

    }
}
