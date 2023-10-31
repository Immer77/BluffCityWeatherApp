using BluffCityWeatherApp.AirlineCompany.Translators;
using BluffCityWeatherApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluffCityWeatherApp.AirlineCompany.Airlines
{
    public class KLM : Airline
    {
        public KLM() { }

        public override void Update(WeatherApiResponse weatherData)
        {
            Console.WriteLine("Weather Update for KLM");
            Console.WriteLine(weatherData.KLMTranslator() + "\n");
        }
    }
}
