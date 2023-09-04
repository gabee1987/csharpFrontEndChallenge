using AutoMapper;

namespace WeatherNET.Services.MappingProfiles
{
    public  class WeatherMappingProfile : Profile
    {
        public WeatherMappingProfile()
        {
            CreateMap<WeatherNET.PirateWeatherApi.ApiWeatherData, WeatherNET.Models.WeatherForecast.WeatherData>()
                .ForMember( dest => dest.Location, opt => opt.MapFrom( src => new WeatherNET.Models.WeatherForecast.Location
                {
                    Latitude  = src.Latitude,
                    Longitude = src.Longitude,
                    TimeZone  = src.Timezone,
                    Offset    = src.Offset,
                    Elevation = src.Elevation,
                } ) );

            CreateMap<WeatherNET.PirateWeatherApi.ApiCurrentlyData, WeatherNET.Models.WeatherForecast.CurrentlyWeatherData>();

            CreateMap<WeatherNET.PirateWeatherApi.ApiDailyData, WeatherNET.Models.WeatherForecast.DailyWeatherData>();
            CreateMap<WeatherNET.PirateWeatherApi.ApiPerDayData, WeatherNET.Models.WeatherForecast.PerDayWeatherData>();

            CreateMap<WeatherNET.PirateWeatherApi.ApiHourlyData, WeatherNET.Models.WeatherForecast.HourlyWeatherData>();

            CreateMap<WeatherNET.PirateWeatherApi.ApiMinutelyData, WeatherNET.Models.WeatherForecast.MinutelyWeatherData>();
            CreateMap<WeatherNET.PirateWeatherApi.ApiPerMinuteData, WeatherNET.Models.WeatherForecast.PerMinuteWeatherData>();

            CreateMap<WeatherNET.PirateWeatherApi.ApiFlags, WeatherNET.Models.WeatherForecast.ApiFlag>();

            CreateMap<WeatherNET.Models.WeatherForecast.CurrentlyWeatherData, WeatherNET.Models.WeatherForecast.PerHourWeatherData>();
            CreateMap<WeatherNET.Models.WeatherForecast.PerHourWeatherData, WeatherNET.Models.WeatherForecast.CurrentlyWeatherData>();
        }
    }
}
