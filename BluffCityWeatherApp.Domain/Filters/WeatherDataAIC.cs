using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluffCityWeatherApp.Domain.Filters
{
    /// <summary>
    /// Airport information center filter
    /// </summary>
    public class WeatherDataAIC
    {
        public string NameOfCity { get; set; }
        public string Country {  get; set; }
        public double Sunrise { get; set; }
        public double Sunset { get; set; }
        public double Temperature { get; set; }
        public WeatherDataAIC() { }

        public override string ToString()
        {
            return $"Name Of City: {NameOfCity}\nCountry: {Country}\nTemperature: {Temperature}\nSunrise: {Sunrise}\nSunset: {Sunset}\n";
        }

    }
}
