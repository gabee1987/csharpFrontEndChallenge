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

        public void CalculateHourlyChartBarDisplayData( WeatherViewModel viewModel, double incrementFactor )
        {
            if ( viewModel == null || viewModel.Hourly == null ) return;

            foreach ( var hourData in viewModel.Hourly.HourlyData.Data )
            {
                // Get the sunrise and sunset time for the specific day of the hourData.
                var date                 = hourData.Time.Date;
                var dailyDataForThisHour = viewModel.Daily.DailyData.Data.FirstOrDefault( d => d.Time.Date == date );

                // If there's no daily data for this hour's day, continue to the next hour.
                if ( dailyDataForThisHour == null ) continue;

                var sunriseTime = dailyDataForThisHour.SunriseTime;
                var sunsetTime  = dailyDataForThisHour.SunsetTime;

                var displayData = new HourlyDisplayData
                {
                    HeightValue = hourData.Temperature * incrementFactor,
                    IconClass   = hourData.Icon.ToLower(),
                    Hour        = hourData.Time.ToString( "HH" ),
                    SunriseTime = sunriseTime,
                    SunsetTime  = sunsetTime,
                    IsDaytime   = hourData.Time > sunriseTime && hourData.Time < sunsetTime ? true : false
                };
                viewModel.Hourly.DisplayData.Add( displayData );
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

        public void GetIsDayTime( WeatherViewModel weatherViewModel )
        {
            if (weatherViewModel == null || weatherViewModel.Hourly == null) return;

            if ( weatherViewModel.Hourly.DisplayData.Count > 0 )
            {
                weatherViewModel.IsDayTime = weatherViewModel.Hourly.DisplayData[0].IsDaytime;
            }
        }

        public void CalculateHourlyPrecipitationDisplayData( WeatherViewModel viewModel )
        {
            if ( viewModel == null || viewModel.Hourly.HourlyData == null ) return;

            foreach ( var hourData in viewModel.Hourly.HourlyData.Data )
            {
                var precipData = new HourlyPrecipDisplayData
                {
                    PrecipChance = hourData.PrecipProbability * 100,
                    PrecipVolume = hourData.PrecipIntensity,
                    Hour         = hourData.Time.ToString( "HH:00" )
                };
                viewModel.Hourly.PrecipDisplayData.Add( precipData );
            }
        }

        public void CalculateTotalPrecipVolumePerDay( WeatherViewModel weatherViewModel )
        {
            throw new NotImplementedException();
        }
    }
}