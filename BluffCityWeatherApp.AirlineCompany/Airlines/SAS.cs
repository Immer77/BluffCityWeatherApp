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
    /// SAS class that Inherits from Airline
    /// </summary>
    public class SAS : Airline
    {
        public SAS() { }
        /// <summary>
        /// Update function as observer where we use the extension method for the SASTranslator
        /// </summary>
        /// <param name="weatherData"></param>
        public override void Update(WeatherApiResponse weatherData)
        {
            Console.WriteLine("Weather Update for SAS");
            Console.WriteLine(weatherData.SASTranslate() + "\n");
        }
    }
}
