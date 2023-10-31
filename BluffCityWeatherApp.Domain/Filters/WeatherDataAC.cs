using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluffCityWeatherApp.Domain.Filters
{
    /// <summary>
    /// Airline company filter
    /// </summary>
    public class WeatherDataAC
    {
        public string NameOfCity { get; set; }
        public string Country {  get; set; }
        public double Temperature { get; set; }
        public int clouds {  get; set; }

        public override string ToString()
        {
            return $"Name Of City: {NameOfCity}\nCountry: {Country}\nTemperature: {Temperature}\nCloud Category: {clouds}";
        }
    }
}
