using AutoMapper;
using Weather.API.Backend.Presentation.Models;
using Weather.API.Backend.Service;
using Weather.API.Backend.Service.DTOs;

namespace Weather.API.Backend.Presentation.WebProfile
{
    public class WebMappingProfile : Profile
    {
        public WebMappingProfile()
        {
            CreateMap<WeatherForecastModel, WeatherForecast>().ReverseMap();
            CreateMap<CurrentWeatherModel, CurrentWeather>().ReverseMap();
            CreateMap<DailyWeatherModel, DailyWeather>().ReverseMap();
            CreateMap<HourlyWeatherModel, HourlyWeather>().ReverseMap();
        }
    }
}
