﻿using WeatherNET.Models.WeatherForecast;

namespace WeatherNET.Services.PirateWeatherApi.APIService
{
    public interface IPirateWeatherApiService
    {
        Task<WeatherData> GetWeatherAsync( Location location );
        Task<CurrentlyWeatherData> GetCurrentWeatherAsync( Location location );
        Task<DailyWeatherData> GetDailyWeatherAsync( Location location );
        Task<HourlyWeatherData> GetHourlyWeatherAsync( Location location );
        Task<MinutelyWeatherData> GetMinutelyWeatherAsync( Location location );

    }
}
