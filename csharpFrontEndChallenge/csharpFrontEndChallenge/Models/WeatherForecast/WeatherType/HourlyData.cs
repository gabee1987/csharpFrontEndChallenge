﻿namespace csharpFrontEndChallenge.Models.WeatherForecast
{
    public class HourlyData : BaseWeatherData
    {
        /// <summary>
        /// The amount of liquid precipitation expected to fall over an hour or a day expressed in centimetres or inches depending on the requested units.
        /// </summary>
        public double PrecipAccumulation { get; set; }
    }
}