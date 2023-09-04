﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using WeatherNET;
//
//    var weatherData = WeatherData.FromJson(jsonString);
namespace WeatherNET.PirateWeatherApi
{
    using System;
    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class ApiWeatherData
    {
        [JsonProperty( "latitude" )]
        public double Latitude { get; set; }

        [JsonProperty( "longitude" )]
        public double Longitude { get; set; }

        [JsonProperty( "timezone" )]
        public string Timezone { get; set; }

        [JsonProperty( "offset" )]
        public long Offset { get; set; }

        [JsonProperty( "elevation" )]
        public long Elevation { get; set; }

        [JsonProperty( "currently" )]
        public ApiCurrentlyData Currently { get; set; }

        [JsonProperty( "minutely" )]
        public ApiMinutelyData Minutely { get; set; }

        [JsonProperty( "hourly" )]
        public ApiHourlyData Hourly { get; set; }

        [JsonProperty( "daily" )]
        public ApiDailyData Daily { get; set; }

        [JsonProperty( "flags" )]
        public ApiFlags Flags { get; set; }
    }

    public partial class ApiCurrentlyData
    {
        [JsonProperty( "time" )]
        public long Time { get; set; }

        [JsonProperty( "summary" )]
        //public Summary Summary { get; set; }
        public string Summary { get; set; }

        [JsonProperty( "icon" )]
        public string Icon { get; set; }

        [JsonProperty( "nearestStormDistance", NullValueHandling = NullValueHandling.Ignore )]
        public long? NearestStormDistance { get; set; }

        [JsonProperty( "nearestStormBearing", NullValueHandling = NullValueHandling.Ignore )]
        public long? NearestStormBearing { get; set; }

        [JsonProperty( "precipIntensity" )]
        public long PrecipIntensity { get; set; }

        [JsonProperty( "precipProbability" )]
        public long PrecipProbability { get; set; }

        [JsonProperty( "precipIntensityError" )]
        public long PrecipIntensityError { get; set; }

        [JsonProperty( "precipType" )]
        public string PrecipType { get; set; }

        [JsonProperty( "temperature" )]
        public double Temperature { get; set; }

        [JsonProperty( "apparentTemperature" )]
        public double ApparentTemperature { get; set; }

        [JsonProperty( "dewPoint" )]
        public double DewPoint { get; set; }

        [JsonProperty( "humidity" )]
        public double Humidity { get; set; }

        [JsonProperty( "pressure" )]
        public double Pressure { get; set; }

        [JsonProperty( "windSpeed" )]
        public double WindSpeed { get; set; }

        [JsonProperty( "windGust" )]
        public double WindGust { get; set; }

        [JsonProperty( "windBearing" )]
        public long WindBearing { get; set; }

        [JsonProperty( "cloudCover" )]
        public double CloudCover { get; set; }

        [JsonProperty( "uvIndex" )]
        public double UvIndex { get; set; }

        [JsonProperty( "visibility" )]
        public long Visibility { get; set; }

        [JsonProperty( "ozone" )]
        public double Ozone { get; set; }

        [JsonProperty( "precipAccumulation", NullValueHandling = NullValueHandling.Ignore )]
        public long? PrecipAccumulation { get; set; }
    }

    public partial class ApiDailyData
    {
        [JsonProperty( "summary" )]
        //public Summary Summary { get; set; }
        public string Summary { get; set; }

        [JsonProperty( "icon" )]
        public string Icon { get; set; }

        [JsonProperty( "data" )]
        public ApiPerDayData[] Data { get; set; }
    }

    public partial class ApiPerDayData
    {
        [JsonProperty( "time" )]
        public long Time { get; set; }

        [JsonProperty( "icon" )]
        public string Icon { get; set; }

        [JsonProperty( "summary" )]
        //public Summary Summary { get; set; }
        public string Summary { get; set; }

        [JsonProperty( "sunriseTime" )]
        public long SunriseTime { get; set; }

        [JsonProperty( "sunsetTime" )]
        public long SunsetTime { get; set; }

        [JsonProperty( "moonPhase" )]
        public double MoonPhase { get; set; }

        [JsonProperty( "precipIntensity" )]
        public long PrecipIntensity { get; set; }

        [JsonProperty( "precipIntensityMax" )]
        public long PrecipIntensityMax { get; set; }

        [JsonProperty( "precipIntensityMaxTime" )]
        public long PrecipIntensityMaxTime { get; set; }

        [JsonProperty( "precipProbability" )]
        public long PrecipProbability { get; set; }

        [JsonProperty( "precipAccumulation" )]
        public long PrecipAccumulation { get; set; }

        [JsonProperty( "precipType" )]
        public string PrecipType { get; set; }

        [JsonProperty( "temperatureHigh" )]
        public double TemperatureHigh { get; set; }

        [JsonProperty( "temperatureHighTime" )]
        public long TemperatureHighTime { get; set; }

        [JsonProperty( "temperatureLow" )]
        public double TemperatureLow { get; set; }

        [JsonProperty( "temperatureLowTime" )]
        public long TemperatureLowTime { get; set; }

        [JsonProperty( "apparentTemperatureHigh" )]
        public double ApparentTemperatureHigh { get; set; }

        [JsonProperty( "apparentTemperatureHighTime" )]
        public long ApparentTemperatureHighTime { get; set; }

        [JsonProperty( "apparentTemperatureLow" )]
        public double ApparentTemperatureLow { get; set; }

        [JsonProperty( "apparentTemperatureLowTime" )]
        public long ApparentTemperatureLowTime { get; set; }

        [JsonProperty( "dewPoint" )]
        public double DewPoint { get; set; }

        [JsonProperty( "humidity" )]
        public double Humidity { get; set; }

        [JsonProperty( "pressure" )]
        public double Pressure { get; set; }

        [JsonProperty( "windSpeed" )]
        public double WindSpeed { get; set; }

        [JsonProperty( "windGust" )]
        public double WindGust { get; set; }

        [JsonProperty( "windGustTime" )]
        public long WindGustTime { get; set; }

        [JsonProperty( "windBearing" )]
        public long WindBearing { get; set; }

        [JsonProperty( "cloudCover" )]
        public double CloudCover { get; set; }

        [JsonProperty( "uvIndex" )]
        public double UvIndex { get; set; }

        [JsonProperty( "uvIndexTime" )]
        public long UvIndexTime { get; set; }

        [JsonProperty( "visibility" )]
        public long Visibility { get; set; }

        [JsonProperty( "temperatureMin" )]
        public double TemperatureMin { get; set; }

        [JsonProperty( "temperatureMinTime" )]
        public long TemperatureMinTime { get; set; }

        [JsonProperty( "temperatureMax" )]
        public double TemperatureMax { get; set; }

        [JsonProperty( "temperatureMaxTime" )]
        public long TemperatureMaxTime { get; set; }

        [JsonProperty( "apparentTemperatureMin" )]
        public double ApparentTemperatureMin { get; set; }

        [JsonProperty( "apparentTemperatureMinTime" )]
        public long ApparentTemperatureMinTime { get; set; }

        [JsonProperty( "apparentTemperatureMax" )]
        public double ApparentTemperatureMax { get; set; }

        [JsonProperty( "apparentTemperatureMaxTime" )]
        public long ApparentTemperatureMaxTime { get; set; }
    }

    public partial class ApiFlags
    {
        [JsonProperty( "sources" )]
        public string[] Sources { get; set; }

        [JsonProperty( "sourceTimes" )]
        public ApiSourceTimes SourceTimes { get; set; }

        [JsonProperty( "nearest-station" )]
        public long NearestStation { get; set; }

        [JsonProperty( "units" )]
        public string Units { get; set; }

        [JsonProperty( "version" )]
        public string Version { get; set; }
    }

    public partial class ApiSourceTimes
    {
        [JsonProperty( "gfs" )]
        public DateTimeOffset Gfs { get; set; }

        [JsonProperty( "gefs" )]
        public DateTimeOffset Gefs { get; set; }
    }

    public partial class ApiHourlyData
    {
        [JsonProperty( "summary" )]
        //public Summary Summary { get; set; }
        public string Summary { get; set; }

        [JsonProperty( "icon" )]
        public string Icon { get; set; }

        [JsonProperty( "data" )]
        public ApiCurrentlyData[] Data { get; set; }
    }

    public partial class ApiMinutelyData
    {
        [JsonProperty( "summary" )]
        //public Summary Summary { get; set; }
        public string Summary { get; set; }

        [JsonProperty( "icon" )]
        public string Icon { get; set; }

        [JsonProperty( "data" )]
        public ApiPerMinuteData[] Data { get; set; }
    }

    public partial class ApiPerMinuteData
    {
        [JsonProperty( "time" )]
        public long Time { get; set; }

        [JsonProperty( "precipIntensity" )]
        public long PrecipIntensity { get; set; }

        [JsonProperty( "precipProbability" )]
        public long PrecipProbability { get; set; }

        [JsonProperty( "precipIntensityError" )]
        public long PrecipIntensityError { get; set; }

        [JsonProperty( "precipType" )]
        public ApiPrecipType PrecipType { get; set; }
    }

    public enum ApiIcon { ClearDay, ClearNight, Rain, Snow, Sleet, Wind, Fog, Cloudy, PartlyCloudyDay, PartlyCloudyNight };

    public enum ApiPrecipType { Rain, Snow, Sleet, None };

    //public enum Summary { Clear, Cloudy, PartlyCloudy };

    public partial class ApiWeatherData
    {
        public static ApiWeatherData FromJson( string json ) => JsonConvert.DeserializeObject<ApiWeatherData>( json, WeatherNET.PirateWeatherApi.Converter.Settings );
    }

    public static class Serialize
    {
        public static string ToJson( this ApiWeatherData self ) => JsonConvert.SerializeObject( self, WeatherNET.PirateWeatherApi.Converter.Settings );
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling        = DateParseHandling.None,
            Converters               =
            {
                ApiIconConverter.Singleton,
                ApiPrecipTypeConverter.Singleton,
                //SummaryConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class ApiIconConverter : JsonConverter
    {
        public override bool CanConvert( Type t ) => t == typeof( ApiIcon ) || t == typeof( ApiIcon? );

        public override object ReadJson( JsonReader reader, Type t, object existingValue, JsonSerializer serializer )
        {
            if ( reader.TokenType == JsonToken.Null ) return null;
            var value = serializer.Deserialize<string>( reader );
            switch ( value )
            {
                case "clear-day":
                    return ApiIcon.ClearDay;
                case "clear-night":
                    return ApiIcon.ClearNight;
                case "rain":
                    return ApiIcon.Rain;
                case "snow":
                    return ApiIcon.Snow;
                case "sleet":
                    return ApiIcon.Sleet;
                case "wind":
                    return ApiIcon.Wind;
                case "fog":
                    return ApiIcon.Fog;
                case "cloudy":
                    return ApiIcon.Cloudy;
                case "partly-cloudy-day":
                    return ApiIcon.PartlyCloudyDay;
                case "partly-cloudy-night":
                    return ApiIcon.PartlyCloudyNight;
            }
            throw new Exception( "Cannot unmarshal type Icon" );
        }

        public override void WriteJson( JsonWriter writer, object untypedValue, JsonSerializer serializer )
        {
            if ( untypedValue == null )
            {
                serializer.Serialize( writer, null );
                return;
            }
            var value = (ApiIcon)untypedValue;
            switch ( value )
            {
                case ApiIcon.ClearDay:
                    serializer.Serialize( writer, "clear-day" );
                    return;
                case ApiIcon.ClearNight:
                    serializer.Serialize( writer, "clear-night" );
                    return;
                case ApiIcon.Rain:
                    serializer.Serialize( writer, "rain" );
                    return;
                case ApiIcon.Snow:
                    serializer.Serialize( writer, "snow" );
                    return;
                case ApiIcon.Sleet:
                    serializer.Serialize( writer, "sleet" );
                    return;
                case ApiIcon.Wind:
                    serializer.Serialize( writer, "wind" );
                    return;
                case ApiIcon.Fog:
                    serializer.Serialize( writer, "fog" );
                    return;
                case ApiIcon.Cloudy:
                    serializer.Serialize( writer, "cloudy" );
                    return;
                case ApiIcon.PartlyCloudyDay:
                    serializer.Serialize( writer, "partly-cloudy-day" );
                    return;
                case ApiIcon.PartlyCloudyNight:
                    serializer.Serialize( writer, "partly-cloudy-night" );
                    return;
            }
            throw new Exception( "Cannot marshal type Icon" );
        }

        public static readonly ApiIconConverter Singleton = new ApiIconConverter();
    }

    internal class ApiPrecipTypeConverter : JsonConverter
    {
        public override bool CanConvert( Type t ) => t == typeof( ApiPrecipType ) || t == typeof( ApiPrecipType? );

        public override object ReadJson( JsonReader reader, Type t, object existingValue, JsonSerializer serializer )
        {
            if ( reader.TokenType == JsonToken.Null ) return null;
            var value = serializer.Deserialize<string>( reader );

            switch ( value )
            {
                case "rain":
                    return ApiPrecipType.Rain;
                case "snow":
                    return ApiPrecipType.Snow;
                case "sleet":
                    return ApiPrecipType.Sleet;
                case "none":
                    return ApiPrecipType.None;
            }
            throw new Exception( "Cannot unmarshal type PrecipType" );
        }

        public override void WriteJson( JsonWriter writer, object untypedValue, JsonSerializer serializer )
        {
            if ( untypedValue == null )
            {
                serializer.Serialize( writer, null );
                return;
            }
            var value = (ApiPrecipType)untypedValue;
            switch ( value )
            {
                case ApiPrecipType.Rain:
                    serializer.Serialize( writer, "rain" );
                    break;
                case ApiPrecipType.Snow:
                    serializer.Serialize( writer, "snow" );
                    break;
                case ApiPrecipType.Sleet:
                    serializer.Serialize( writer, "sleet" );
                    break;
                case ApiPrecipType.None:
                    serializer.Serialize( writer, "none" );
                    break;
                default:
                    break;
            }
            throw new Exception( "Cannot marshal type PrecipType" );
        }

        public static readonly ApiPrecipTypeConverter Singleton = new ApiPrecipTypeConverter();
    }

    //internal class SummaryConverter : JsonConverter
    //{
    //    public override bool CanConvert( Type t ) => t == typeof( Summary ) || t == typeof( Summary? );

    //    public override object ReadJson( JsonReader reader, Type t, object existingValue, JsonSerializer serializer )
    //    {
    //        if ( reader.TokenType == JsonToken.Null ) return null;
    //        var value = serializer.Deserialize<string>( reader );
    //        switch ( value )
    //        {
    //            case "Clear":
    //                return Summary.Clear;
    //            case "Cloudy":
    //                return Summary.Cloudy;
    //            case "Partly Cloudy":
    //                return Summary.PartlyCloudy;
    //        }
    //        throw new Exception( "Cannot unmarshal type Summary" );
    //    }

    //    public override void WriteJson( JsonWriter writer, object untypedValue, JsonSerializer serializer )
    //    {
    //        if ( untypedValue == null )
    //        {
    //            serializer.Serialize( writer, null );
    //            return;
    //        }
    //        var value = (Summary)untypedValue;
    //        switch ( value )
    //        {
    //            case Summary.Clear:
    //                serializer.Serialize( writer, "Clear" );
    //                return;
    //            case Summary.Cloudy:
    //                serializer.Serialize( writer, "Cloudy" );
    //                return;
    //            case Summary.PartlyCloudy:
    //                serializer.Serialize( writer, "Partly Cloudy" );
    //                return;
    //        }
    //        throw new Exception( "Cannot marshal type Summary" );
    //    }

    //    public static readonly SummaryConverter Singleton = new SummaryConverter();
    //}
}