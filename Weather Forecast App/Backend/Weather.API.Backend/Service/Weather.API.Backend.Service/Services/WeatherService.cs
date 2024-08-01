using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Weather.API.Backend.Service.DTOs;
using Weather.API.Backend.Service.Services.Interface;

namespace Weather.API.Backend.Service.Services
{
    public class WeatherService : IWeatherService
    {
        private readonly HttpClient _httpClient;

        public WeatherService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<WeatherForecast> GetWeatherForecast(double latitude, double longitude)
        {
            try
            {
                var queryParams = new Dictionary<string, string>
                {
                    { "latitude", latitude.ToString() },
                    { "longitude", longitude.ToString() },
                    { "current", "temperature_2m,relative_humidity_2m,apparent_temperature,is_day,precipitation" },
                    { "hourly", "temperature_2m,relative_humidity_2m,apparent_temperature,precipitation_probability,precipitation" },
                    { "daily", "temperature_2m_max,temperature_2m_min,apparent_temperature_max,apparent_temperature_min,precipitation_sum,precipitation_hours,precipitation_probability_max" },
                    { "timezone", "auto" }
                };

                string apiUrl = "https://api.open-meteo.com/v1/forecast?" + BuildQueryString(queryParams);

                HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    WeatherForecast forecast = JsonConvert.DeserializeObject<WeatherForecast>(responseBody);
                    return forecast;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        private string BuildQueryString(Dictionary<string, string> queryParams)
        {
            var queryBuilder = new StringBuilder();
            foreach (var kvp in queryParams)
            {
                queryBuilder.Append($"{kvp.Key}={kvp.Value}&");
            }
            return queryBuilder.ToString().TrimEnd('&');
        }

    }
}
