namespace Weather.API.Backend.Service.DTOs
{
    public class HourlyWeather
    {
        public List<string> Time { get; set; }
        public List<double> Temperature_2m { get; set; }
        public List<int> Relative_humidity_2m { get; set; }
        public List<double> Apparent_temperature { get; set; }
        public List<int> Precipitation_probability { get; set; }
        public List<double> Precipitation { get; set; }
    }
}
