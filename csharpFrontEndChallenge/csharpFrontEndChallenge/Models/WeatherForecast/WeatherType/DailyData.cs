namespace csharpFrontEndChallenge.Models.WeatherForecast
{
    public class DailyData : BaseWeatherData
    {
        /// <summary>
        /// The time when the sun rises for a given day.
        /// </summary>
        public DateTime SunriseTime { get; set; }

        /// <summary>
        /// The time when the sun sets for a given day.
        /// </summary>
        public DateTime SunsetTime { get; set; }

        /// <summary>
        /// The fractional lunation number for the given day. 0.00 represents a new moon, 0.25 represents the first quarter, 0.50 represents a full moon and 0.75 represents the last quarter.
        /// </summary>
        public double MoonPhase { get; set; }

        /// <summary>
        /// The amount of liquid precipitation expected to fall over an hour or a day expressed in centimetres or inches depending on the requested units.
        /// </summary>
        public double PrecipAccumulation { get; set; }

        /// <summary>
        /// The maximum value of precipitationIntensity for the given day.
        /// </summary>
        public double PrecipIntensityMax { get; set; }

        /// <summary>
        /// The point in which the maximum precipitationIntensity occurs.
        /// </summary>
        public DateTime PrecipIntensityMaxTime { get; set; }

        /// <summary>
        /// The minimum value of precipitationIntensity for the given day.
        /// </summary>
        public double PrecipIntensityMin { get; set; }

        /// <summary>
        /// The point in which the minimum precipitationIntensity occurs.
        /// </summary>
        public DateTime PrecipIntensityMinTime { get; set; }

        /// <summary>
        /// The daytime high temperature calculated between 6:00 am and 6:00 pm local time.
        /// Note that this value is always forward looking, so for day 0 (the current day), it will return the highest value of the remaining hours in the day.
        /// </summary>
        public double TemperatureHigh { get; set; }

        /// <summary>
        /// The time in which the high temperature occurs.
        /// </summary>
        public DateTime TemperatureHighTime { get; set; }

        /// <summary>
        /// The overnight low temperature calculated between 6:00 pm and 6:00 am local time.
        /// Note that this value is always forward looking, so for day 0 (the current day), it will return the highest value of the remaining hours in the day.
        /// </summary>
        public double TemperatureLow { get; set; }

        /// <summary>
        /// The time in which the low temperature occurs.
        /// </summary>
        public DateTime TemperatureLowTime { get; set; }

        /// <summary>
        /// The maximum "feels like" temperature during the daytime, from 6:00 am to 6:00 pm.
        /// Note that this value is always forward looking, so for day 0 (the current day), it will return the highest value of the remaining hours in the day.
        /// If the forecast start time is after 6:00 pm, it will return the current temperature.
        /// </summary>
        public double ApparentTemperatureHigh { get; set; }

        /// <summary>
        /// The time of the maximum "feels like" temperature during the daytime, from 6:00 am to 6:00 pm.
        /// Note that this value is always forward looking, so for day 0 (the current day), it will return the time of the highest value of the remaining hours in the day.
        /// If the forecast start time is after 6:00 pm, it will return the current time.
        /// </summary>
        public DateTime ApparentTemperatureHighTime { get; set; }

        /// <summary>
        /// The minimum "feels like" temperature during the daytime, from 6:00 am to 6:00 pm.
        /// Note that this value is always forward looking, so for day 0 (the current day), it will return the lowest value of the remaining hours in the day.
        /// If the forecast start time is after 6:00 pm, it will return the current temperature.
        /// </summary>
        public double ApparentTemperatureLow { get; set; }

        /// <summary>
        /// The time of the minimum "feels like" temperature during the daytime, from 6:00 am to 6:00 pm.
        /// Note that this value is always forward looking, so for day 0 (the current day), it will return the time of the lowest value of the remaining hours in the day.
        /// If the forecast start time is after 6:00 pm, it will return the current time.
        /// </summary>
        public DateTime ApparentTemperatureLowTime { get; set; }

        /// <summary>
        /// The time in which the maximum wind gust occurs during the day.
        /// </summary>
        public DateTime WindGustTime { get; set; }

        /// <summary>
        /// The time in which the maximum uvIndex occurs during the day.
        /// </summary>
        public DateTime UvIndexTime { get; set; }

        /// <summary>
        /// The minimum temperature calculated between 12:00 am and 11:59 pm local time.
        /// Note that this value is always forward looking, so for day 0 (the current day), it will return the highest value of the remaining hours in the day.
        /// </summary>
        public int TemperatureMin { get; set; }

        /// <summary>
        ///  The time in which the minimum temperature occurs.
        /// </summary>
        public DateTime TemperatureMinTime { get; set; }

        /// <summary>
        /// The maximum temperature calculated between 12:00 am and 11:59 pm local time.
        /// Note that this value is always forward looking, so for day 0 (the current day), it will return the highest value of the remaining hours in the day.
        /// </summary>
        public double TemperatureMax { get; set; }

        /// <summary>
        /// The time in which the maximum temperature occurs
        /// </summary>
        public DateTime TemperatureMaxTime { get; set; }

        /// <summary>
        /// The minimum "feels like" temperature during a day, from from 12:00 am and 11:59 pm.
        /// Note that this value is always forward looking, so for day 0 (the current day), it will return the highest value of the remaining hours in the day.
        /// </summary>
        public double ApparentTemperatureMin { get; set; }

        /// <summary>
        /// The time (in UTC) that the minimum "feels like" temperature occurs during a day, from from 12:00 am and 11:59 pm.
        /// Note that this value is always forward looking, so for day 0 (the current day), it will return the highest value of the remaining hours in the day.
        /// </summary>
        public DateTime ApparentTemperatureMinTime { get; set; }

        /// <summary>
        /// The maximum "feels like" temperature during a day, from midnight to midnight.
        /// Note that this value is always forward looking, so for day 0 (the current day), it will return the highest value of the remaining hours in the day.
        /// </summary>
        public double ApparentTemperatureMax { get; set; }

        /// <summary>
        /// The time (in UTC) that the maximum "feels like" temperature occurs during a day, from 12:00 am and 11:59 pm.
        /// Note that this value is always forward looking, so for day 0 (the current day), it will return the highest value of the remaining hours in the day.
        /// </summary>
        public DateTime ApparentTemperatureMaxTime { get; set; }
    }
}
