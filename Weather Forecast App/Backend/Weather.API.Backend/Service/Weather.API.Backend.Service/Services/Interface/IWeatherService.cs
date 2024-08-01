using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather.API.Backend.Service.DTOs;

namespace Weather.API.Backend.Service.Services.Interface
{
    public interface IWeatherService
    {
        Task<WeatherForecast> GetWeatherForecast(double latitude, double longitude);
    }
}
