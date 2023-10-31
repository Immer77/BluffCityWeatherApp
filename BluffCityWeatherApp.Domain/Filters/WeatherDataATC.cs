using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluffCityWeatherApp.Domain.Filters
{
    public class WeatherDataATC
    {
        public string NameOfCity { get; set; }
        public string Coordinates { get; set; }
        public string Country { get; set; }
        public double Temperature { get; set; }
        public double Humidity { get; set; }
        public double Pressure { get; set; }
        public double Wind { get; set; }
        public int Clouds { get; set; }
        public int Visibility { get; set; }

        public override string ToString()
        {
            return $"Name Of City: {NameOfCity}\nCountry: {Country}\nTemperature: {Temperature}\nCoordinates: {Coordinates}\nHumidity: {Humidity}\nPressure: {Pressure}\nVisibility: {Visibility}\nClouds Category {Clouds}\nWind: {Wind}\n";
        }
    }
}
