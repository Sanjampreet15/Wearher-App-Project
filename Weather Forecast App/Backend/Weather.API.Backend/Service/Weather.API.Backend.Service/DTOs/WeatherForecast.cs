
namespace Weather.API.Backend.Service.DTOs
{
    public class WeatherForecast
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double Generationtime_ms { get; set; }
        public int Utc_offset_seconds { get; set; }
        public string Timezone { get; set; }
        public string Timezone_abbreviation { get; set; }
        public double Elevation { get; set; }
        public Dictionary<string, string> Current_units { get; set; }
        public CurrentWeather Current { get; set; }
        public Dictionary<string, string> Hourly_units { get; set; }
        public HourlyWeather Hourly { get; set; }
        public Dictionary<string, string> Daily_units { get; set; }
        public DailyWeather Daily { get; set; }
    }
}
