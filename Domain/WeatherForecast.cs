using System;

namespace Domain {
    public class WeatherForecast {
        public int Id { get; set; }
        public string Date { get; set; }
        public string TempC { get; set; }
        public string TempF { get; set; }
        public string Summary { get; set; }
    }
}