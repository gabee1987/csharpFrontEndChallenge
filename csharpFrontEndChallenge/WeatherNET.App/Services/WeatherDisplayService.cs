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

        public void CalculateUvIndex( CurrentlyDataViewModel viewModel )
        {
            if ( viewModel?.CurrentlyData == null ) return;

            var uvIndex = Math.Round( viewModel.CurrentlyData.UvIndex );

            viewModel.UvIndexDisplay = uvIndex switch
            {
                var n when n >= 0 && n <= 2 => $"Low, {uvIndex}",
                var n when n >= 3 && n <= 5 => $"Moderate, {uvIndex}",
                var n when n >= 6 && n <= 7 => $"High, {uvIndex}",
                var n when n >= 8 && n <= 10 => $"Very High, {uvIndex}",
                var n when n >= 11 => $"Extreme, {uvIndex}",
                _ => "Unknown"
            };
        }
    }
}
