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

        public void CalculateTotalPrecipVolumePerDay( WeatherViewModel viewModel )
        {
            throw new NotImplementedException();
        }

        public void CalculateWindStrengthType( WeatherViewModel viewModel )
        {
            if ( viewModel == null || viewModel.Hourly.HourlyData == null ) return;

            foreach ( var hourData in viewModel.Hourly.HourlyData.Data )
            {
                var windData = new HourlyWindDisplayData
                {
                    WindStrength        = GetWindStrengthInWords( hourData.WindSpeed ),
                    WindDirectionString = GetWindDirectionInWords( hourData.WindBearing ),
                    WindDirection       = hourData.WindBearing,
                    WindSpeed           = Math.Round( hourData.WindSpeed ),
                    WindGust            = Math.Round( hourData.WindGust ),
                    Hour                = hourData.Time.ToString( "HH:00" )
                };
                viewModel.Hourly.WindDisplayData.Add( windData );
            }
        }

        public void CalculateWindDirectionType( WeatherViewModel viewModel )
        {
            throw new NotImplementedException();
        }

        #region Helper Methods
        private string GetWindStrengthInWords( double speed )
        {
            if ( speed <= 1 ) return "Calm";
            if ( speed <= 5 ) return "Light Air";
            if ( speed <= 11 ) return "Light Breeze";
            if ( speed <= 19 ) return "Gentle Breeze";
            if ( speed <= 28 ) return "Moderate Breeze";
            if ( speed <= 38 ) return "Fresh Breeze";
            if ( speed <= 49 ) return "Strong Breeze";
            if ( speed <= 61 ) return "Near Gale";
            if ( speed <= 74 ) return "Gale";
            if ( speed <= 88 ) return "Strong Gale";
            if ( speed <= 102 ) return "Storm";
            if ( speed <= 117 ) return "Violent Storm";
            if ( speed > 117 ) return "Hurricane";

            return "Unknown";
        }

        private string GetWindDirectionInWords( double bearing )
        {
            if ( bearing <= 11.25 || bearing > 348.75 ) return "North";
            if ( bearing <= 33.75 ) return "North-Northeast";
            if ( bearing <= 56.25 ) return "Northeast";
            if ( bearing <= 78.75 ) return "East-Northeast";
            if ( bearing <= 101.25 ) return "East";
            if ( bearing <= 123.75 ) return "East-Southeast";
            if ( bearing <= 146.25 ) return "Southeast";
            if ( bearing <= 168.75 ) return "South-Southeast";
            if ( bearing <= 191.25 ) return "South";
            if ( bearing <= 213.75 ) return "South-Southwest";
            if ( bearing <= 236.25 ) return "Southwest";
            if ( bearing <= 258.75 ) return "West-Southwest";
            if ( bearing <= 281.25 ) return "West";
            if ( bearing <= 303.75 ) return "West-Northwest";
            if ( bearing <= 326.25 ) return "Northwest";
            if ( bearing <= 348.75 ) return "North-Northwest";

            return "Unknown";
        }
        #endregion
    }
}