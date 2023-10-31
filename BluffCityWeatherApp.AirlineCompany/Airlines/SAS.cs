using BluffCityWeatherApp.AirlineCompany.Translators;
using BluffCityWeatherApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluffCityWeatherApp.AirlineCompany.Airlines
{
    public class SAS : Airline
    {
        public SAS() { }
        public override void Update(WeatherApiResponse weatherData)
        {
            Console.WriteLine("Weather Update for SAS");
            Console.WriteLine(weatherData.SASTranslate() + "\n");
        }
    }
}
