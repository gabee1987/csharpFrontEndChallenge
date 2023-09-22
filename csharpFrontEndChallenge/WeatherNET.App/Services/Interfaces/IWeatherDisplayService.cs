using WeatherNET.App.Models.Weather;

namespace WeatherNET.App.Services
{
    public interface IWeatherDisplayService
    {
        void CalculateHourlyChartHeight( HourlyDataViewModel viewModel, double incrementFactor );
        void CalculateHourlyChartBarDisplayData( WeatherViewModel viewModel, double incrementFactor );
        void CalculateUvIndex( CurrentlyDataViewModel currentlyViewModel );
        void GetIsDayTime( WeatherViewModel weatherViewModel );
        void CalculateHourlyPrecipitationDisplayData( WeatherViewModel viewModel );
        void CalculateTotalPrecipVolumePerDay( WeatherViewModel weatherViewModel );
        void CalculateWindBarDisplayData( WeatherViewModel weatherViewModel, double incrementFactor );
        void CalculateWindDirectionType( WeatherViewModel weatherViewModel );
        void CalculateWindChartHeight( HourlyDataViewModel viewModel, double incrementFactor );
    }
}
