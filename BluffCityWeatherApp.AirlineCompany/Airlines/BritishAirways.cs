using BluffCityWeatherApp.AirlineCompany.Translators;
using BluffCityWeatherApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluffCityWeatherApp.AirlineCompany.Airlines
{
    public class BritishAirways : Airline
    {
        public BritishAirways() { }

        public override void Update(WeatherApiResponse weatherData)
        {
            Console.WriteLine("Weather Update for British Airways");
            Console.WriteLine(weatherData.BritishAirwaysTranslator() + "\n");
        }
    }
}
