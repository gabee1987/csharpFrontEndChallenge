using AutoMapper;
using WeatherNET.App.Models.Weather;
using WeatherNET.Models.WeatherForecast;

namespace WeatherNET.App.Models.MappingProfiles
{
    public class WeatherViewModelMappingProfile : Profile
    {
        public WeatherViewModelMappingProfile()
        {
            CreateMap<WeatherData, WeatherViewModel>()
                .ForMember( dest => dest.Location, opt => opt.MapFrom( src => src.Location ) )
                .ForMember( dest => dest.Currently, opt => opt.MapFrom( src => src.Currently ) )
                .ForMember( dest => dest.Daily, opt => opt.MapFrom( src => src.Daily ) )
                .ForMember( dest => dest.Hourly, opt => opt.MapFrom( src => src.Hourly ) )
                .ForMember( dest => dest.Minutely, opt => opt.MapFrom( src => src.Minutely ) )
                .ForMember( dest => dest.Alerts, opt => opt.MapFrom( src => src.Alerts ) )
                .ForMember( dest => dest.Flags, opt => opt.MapFrom( src => src.Flags ) );

            // For each individual view model mapping
            CreateMap<CurrentlyWeatherData, CurrentlyDataViewModel>()
                .ForMember( dest => dest.CurrentlyData, opt => opt.MapFrom( src => src ) );

            CreateMap<DailyWeatherData, DailyDataViewModel>()
                .ForMember( dest => dest.DailyData, opt => opt.MapFrom( src => src ) );

            CreateMap<HourlyWeatherData, HourlyDataViewModel>()
                .ForMember( dest => dest.HourlyData, opt => opt.MapFrom( src => src ) )
                .ForMember( dest => dest.MaxTemp, opt => opt.MapFrom( src => src.Data.Max( d => d.Temperature ) ) )
                .ForMember( dest => dest.AdjustedHourlyChartHeight, opt => opt.MapFrom( src => src.Data.Max( d => d.Temperature ) * 0.7 ) );

            CreateMap<MinutelyWeatherData, MinutelyDataViewModel>()
                .ForMember( dest => dest.MinutelyData, opt => opt.MapFrom( src => src ) );
        }
    }
}
