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
    /// Southwest Airlines class that Inherits from Airline
    /// </summary>
    public class SouthWest : Airline
    {
        public SouthWest() { }
        /// <summary>
        /// Update function as observer where we use the extension method for the SouthwestAirlinesTranslator
        /// </summary>
        /// <param name="weatherData"></param>
        public override void Update(WeatherApiResponse weatherData)
        {
            Console.WriteLine("Weather Update for Southwest");
            Console.WriteLine(weatherData.SouthWestAirlinesTranslator() + "\n");
        }
    }
}
