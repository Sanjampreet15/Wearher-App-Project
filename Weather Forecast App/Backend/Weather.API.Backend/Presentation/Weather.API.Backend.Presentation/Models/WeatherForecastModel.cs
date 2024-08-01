
namespace Weather.API.Backend.Presentation.Models
{
    public class WeatherForecastModel
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double Generationtime_ms { get; set; }
        public int Utc_offset_seconds { get; set; }
        public string Timezone { get; set; }
        public string Timezone_abbreviation { get; set; }
        public double Elevation { get; set; }
        public Dictionary<string, string> Current_units { get; set; }
        public CurrentWeatherModel Current { get; set; }
        public Dictionary<string, string> Hourly_units { get; set; }
        public HourlyWeatherModel Hourly { get; set; }
        public Dictionary<string, string> Daily_units { get; set; }
        public DailyWeatherModel Daily { get; set; }
    }
}
