using BluffCityWeatherApp.Domain;
using BluffCityWeatherApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluffCityWeatherApp.AirlineCompany.Airlines
{
    /// <summary>
    /// Abstract class for implementing new airlines
    /// </summary>
    public abstract class Airline : IWeatherObserver
    {
        public virtual void Update(WeatherApiResponse weatherData)
        {
            Console.WriteLine("Placeholder");
        }
    }
}
