namespace Weather.API.Backend.Service.DTOs
{
    public class CurrentWeather
    {
        public string Time { get; set; }
        public int Interval { get; set; }
        public double Temperature_2m { get; set; }
        public int Relative_humidity_2m { get; set; }
        public double Apparent_temperature { get; set; }
        public int Is_day { get; set; }
        public double Precipitation { get; set; } = 0;
    }
}
