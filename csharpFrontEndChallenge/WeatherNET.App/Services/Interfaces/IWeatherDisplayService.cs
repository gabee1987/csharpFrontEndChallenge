using WeatherNET.App.Models.Weather;

namespace WeatherNET.App.Services
{
    public interface IWeatherDisplayService
    {
        void CalculateHourlyChartHeight( HourlyDataViewModel viewModel, double incrementFactor );
        void CalculateHourlyChartBarHeight( HourlyDataViewModel viewModel, double incrementFactor );
        void CalculateUvIndex( CurrentlyDataViewModel viewModel );
    }
}
