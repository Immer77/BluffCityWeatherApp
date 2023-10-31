using BluffCityWeatherApp.AirlineCompany.Translators;
using BluffCityWeatherApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluffCityWeatherApp.AirlineCompany.Airlines
{
    /// <summary>
    /// KLM class that Inherits from Airline
    /// </summary>
    public class KLM : Airline
    {

        public KLM() { }

        /// <summary>
        /// Update function as observer where we use the extension method for the KLMTranslator
        /// </summary>
        /// <param name="weatherData"></param>
        public override void Update(WeatherApiResponse weatherData)
        {
            Console.WriteLine("Weather Update for KLM");
            Console.WriteLine(weatherData.KLMTranslator() + "\n");
        }
    }
}
