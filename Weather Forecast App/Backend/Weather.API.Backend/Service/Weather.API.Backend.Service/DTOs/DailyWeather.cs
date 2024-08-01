namespace Weather.API.Backend.Service.DTOs
{
    public class DailyWeather
    {
        public List<string> Time { get; set; }
        public List<double> Temperature_2m_max { get; set; }
        public List<double> Temperature_2m_min { get; set; }
        public List<double> Apparent_temperature_max { get; set; }
        public List<double> Apparent_temperature_min { get; set; }
        public List<double> Precipitation_sum { get; set; }
        public List<double> Precipitation_hours { get; set; }
        public List<int> Precipitation_probability_max { get; set; }
    }
}
