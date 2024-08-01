using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Weather.API.Backend.Presentation.Models;
using Weather.API.Backend.Service.Services.Interface;

namespace Weather.API.Backend.Presentation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IWeatherService _weatherService;

        public WeatherForecastController(IWeatherService weatherService, IMapper mapper)
        {
            _weatherService = weatherService;
            _mapper = mapper;
        }


        /// <summary>
        /// This actions method will get the weather forecast data according to the lat and long of the location.
        /// </summary>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        /// <returns></returns>
        [HttpGet("GetWeatherForecast/{latitude}/{longitude}")]
        public async Task<ActionResult<WeatherForecastModel>> GetWeatherForecastAsync(double latitude, double longitude)
        {
            var response = _mapper.Map<WeatherForecastModel>(await _weatherService.GetWeatherForecast(latitude, longitude));
            return response;
        }

    }
}
