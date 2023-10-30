using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluffCityWeatherApp.Domain
{
    public class WeatherDataATC
    {
        public string NameOfCity { get; set; }
        public string Coordinates { get; set; }
        public string Country { get; set; }
        public string Temperature { get; set; }
        public string Humidity { get; set; }
        public string Pressure { get; set; }
        public string Wind { get; set; }
        public string Clouds { get; set; }
        public string Visibility { get; set; }
    }
}
