using AutoMapper;
using WeatherNET.Services.PirateWeatherApi.TimeService;

namespace WeatherNET.Services.MappingProfiles
{
    public  class WeatherMappingProfile : Profile
    {
        private readonly ITimeService _timeService;

        public WeatherMappingProfile( ITimeService timeService )
        {
            _timeService = timeService;
        }

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
                //.ForMember( dest => dest.Time, opt => opt.MapFrom( src => _timeService.ConvertUnixToDateTime( src.Time ) ) );
                //.ForMember( dest => dest.Time, opt => opt.MapFrom( src => src.Time != null ? _timeService.ConvertUnixToDateTime( src.Time ) : DateTime.MinValue ) );

            CreateMap<WeatherNET.PirateWeatherApi.ApiDailyData, WeatherNET.Models.WeatherForecast.DailyWeatherData>();
            CreateMap<WeatherNET.PirateWeatherApi.ApiPerDayData, WeatherNET.Models.WeatherForecast.PerDayWeatherData>();
                //.ForMember( dest => dest.Time, opt => opt.MapFrom( src => _timeService.ConvertUnixToDateTime( src.Time ) ) );

            CreateMap<WeatherNET.PirateWeatherApi.ApiHourlyData, WeatherNET.Models.WeatherForecast.HourlyWeatherData>();
            //CreateMap<WeatherNET.PirateWeatherApi.ApiCurrentlyData, WeatherNET.Models.WeatherForecast.PerHourWeatherData>()
            //    .ForMember( dest => dest.Time, opt => opt.MapFrom( src => _timeService.ConvertUnixToDateTime( src.Time ) ) );

            CreateMap<WeatherNET.PirateWeatherApi.ApiMinutelyData, WeatherNET.Models.WeatherForecast.MinutelyWeatherData>();
            CreateMap<WeatherNET.PirateWeatherApi.ApiPerMinuteData, WeatherNET.Models.WeatherForecast.PerMinuteWeatherData>();
                //.ForMember( dest => dest.Time, opt => opt.MapFrom( src => _timeService.ConvertUnixToDateTime( src.Time ) ) );

            CreateMap<WeatherNET.PirateWeatherApi.ApiFlags, WeatherNET.Models.WeatherForecast.Flags>();
            CreateMap<WeatherNET.PirateWeatherApi.ApiSourceTimes, WeatherNET.Models.WeatherForecast.SourceTimes>();

            //CreateMap<WeatherNET.Models.WeatherForecast.CurrentlyWeatherData, WeatherNET.Models.WeatherForecast.PerHourWeatherData>();
            //CreateMap<WeatherNET.Models.WeatherForecast.PerHourWeatherData, WeatherNET.Models.WeatherForecast.CurrentlyWeatherData>();

        }
    }
}
