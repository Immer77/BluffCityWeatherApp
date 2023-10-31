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
    /// British Airways class that Inherits from Airline
    /// </summary>
    public class BritishAirways : Airline
    {
        public BritishAirways() { }

        /// <summary>
        /// Update function as observer where we use the extension method for the britishAirwaysTranslator
        /// </summary>
        /// <param name="weatherData"></param>
        public override void Update(WeatherApiResponse weatherData)
        {
            Console.WriteLine("Weather Update for British Airways");
            Console.WriteLine(weatherData.BritishAirwaysTranslator() + "\n");
        }
    }
}
