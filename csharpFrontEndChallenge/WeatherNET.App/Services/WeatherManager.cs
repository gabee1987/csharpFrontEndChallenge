﻿using AutoMapper;
using WeatherNET.App.Models.Weather;
using WeatherNET.App.Services.Interfaces;
using WeatherNET.Services.WeatherService;

namespace WeatherNET.App.Services
{
    public class WeatherManager : IWeatherManager
    {
        private readonly IWeatherService _weatherService;
        private readonly IWeatherDisplayService _weatherDisplayService;
        private readonly ITooltipService _tooltipService;
        private readonly IMapper _mapper;

        public WeatherManager( IWeatherService weatherService,
                          IWeatherDisplayService weatherDisplayService,
                          ITooltipService tooltipService,
                          IMapper mapper )
        {
            _weatherService        = weatherService;
            _weatherDisplayService = weatherDisplayService;
            _tooltipService        = tooltipService;
            _mapper                = mapper;
        }

        public async Task<WeatherViewModel> GetWeatherViewModelByLocationName( string locationName )
        {
            var weatherData      = await _weatherService.GetWeatherAsync( locationName );
            var weatherViewModel = _mapper.Map<WeatherViewModel>( weatherData );

            // Calculate display related values

            // Hourly forecast
            _weatherDisplayService.CalculateHourlyChartHeight( weatherViewModel.Hourly, weatherViewModel.Hourly.HourlyChartHeightIncrementFactor );
            _weatherDisplayService.CalculateHourlyChartBarDisplayData( weatherViewModel, weatherViewModel.Hourly.HourlyColumnScalingFactor );
            _weatherDisplayService.CalculateUvIndex( weatherViewModel.Currently );
            _weatherDisplayService.GetIsDayTime( weatherViewModel );

            // Precipitation
            _weatherDisplayService.CalculateHourlyPrecipitationDisplayData( weatherViewModel );

            // Wind
            _weatherDisplayService.CalculateWindChartHeight( weatherViewModel.Hourly, weatherViewModel.Hourly.HourlyWindChartScalingFactor );
            _weatherDisplayService.CalculateWindBarDisplayData( weatherViewModel, weatherViewModel.Hourly.HourlyWindColumnScalingFactor );

            // Assign tooltip values from the json to the properties
            await AssignCurrentlyWeatherTooltipsToViewModelAsync( weatherViewModel.Currently );

            return weatherViewModel;
        }

        public async Task<WeatherViewModel> GetWeatherViewModelByCoordinates( double latitude, double longitude )
        {
            var weatherData      = await _weatherService.GetWeatherBasedOnCoordsAsync( latitude, longitude );
            var weatherViewModel = _mapper.Map<WeatherViewModel>( weatherData );

            // Calculate display related values

            // Hourly forecast
            _weatherDisplayService.CalculateHourlyChartHeight( weatherViewModel.Hourly, weatherViewModel.Hourly.HourlyChartHeightIncrementFactor );
            _weatherDisplayService.CalculateHourlyChartBarDisplayData( weatherViewModel, weatherViewModel.Hourly.HourlyColumnScalingFactor );
            _weatherDisplayService.CalculateUvIndex( weatherViewModel.Currently );
            _weatherDisplayService.GetIsDayTime( weatherViewModel );

            // Precipitation
            _weatherDisplayService.CalculateHourlyPrecipitationDisplayData( weatherViewModel );

            // Wind
            _weatherDisplayService.CalculateWindChartHeight( weatherViewModel.Hourly, weatherViewModel.Hourly.HourlyWindChartScalingFactor );
            _weatherDisplayService.CalculateWindBarDisplayData( weatherViewModel, weatherViewModel.Hourly.HourlyWindColumnScalingFactor );

            // Assign tooltip values from the json to the properties
            await AssignCurrentlyWeatherTooltipsToViewModelAsync( weatherViewModel.Currently );

            return weatherViewModel;
        }

       
        #region Helper Methods
        private async Task AssignCurrentlyWeatherTooltipsToViewModelAsync( CurrentlyDataViewModel viewModel )
        {
            var properties = viewModel.GetType().GetProperties();
            foreach ( var property in properties )
            {
                if ( property.Name.EndsWith( "Tooltip" ) )
                {
                    var tooltipKey     = property.Name.Replace( "Tooltip", "" );
                    var tooltipValue   = await _tooltipService.GetTooltipForAsync( tooltipKey );

                    if ( tooltipValue != null )
                    {
                        property.SetValue( viewModel, tooltipValue );
                    }
                }
            }
        }
        #endregion
    }
}
