using BluffCityWeatherApp.Domain;
using BluffCityWeatherApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluffCityWeatherApp.AirlineCompany.Airlines
{
    public abstract class Airline : IWeatherObserver
    {

        protected Airline()
        {
        }

        public virtual void Update(WeatherApiResponse weatherData)
        {
            Console.WriteLine("Placeholder");
        }
    }
}
