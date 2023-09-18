using WeatherNET.App.Models.Weather;

namespace WeatherNET.App.Services
{
    public class WeatherDisplayService : IWeatherDisplayService
    {
        public void CalculateHourlyChartHeight( HourlyDataViewModel viewModel, double incrementFactor )
        {
            if ( viewModel.HourlyData == null ) return;


            viewModel.MaxTemp = viewModel.HourlyData.Data.Max( d => d.Temperature );
            viewModel.AdjustedChartHeight = viewModel.MaxTemp * incrementFactor;
        }

        public void CalculateHourlyChartBarHeight( HourlyDataViewModel viewModel, double incrementFactor )
        {
            if ( viewModel.HourlyData == null ) return;

            foreach ( var hourData in viewModel.HourlyData.Data )
            {
                var displayData = new HourlyDisplayData
                {
                    HeightValue = hourData.Temperature * incrementFactor,
                    IconClass   = hourData.Icon.ToLower(),
                    Hour        = hourData.Time.ToString( "HH" )
                };
                viewModel.DisplayData.Add( displayData );
            }
        }
    }
}
