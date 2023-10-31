using BluffCityWeatherApp.Domain;
using BluffCityWeatherApp.Domain.Filters;
using BluffCityWeatherApp.Domain.Interfaces;
using BluffCityWeatherApp.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluffCityWeatherApp.AirportInfoCenter
{
    public class AirportInformationCenterService : IWeatherObserver
    {
        private readonly WeatherApiClient weatherApi;

        public AirportInformationCenterService()
        {

        }

        public void Update(WeatherApiResponse weatherData)
        {
            Console.WriteLine("Weather Update for Airport Information Center");
            WeatherDataAIC data = FilterWeatherData(weatherData);
            Console.WriteLine(data);
        }

        /// <summary>
        /// Using the Content Filter Pattern
        /// </summary>
        private WeatherDataAIC FilterWeatherData(WeatherApiResponse weatherData)
        {
            WeatherDataAIC weatherDataAIC = new WeatherDataAIC();
            weatherDataAIC.Temperature = weatherData.main.temp;
            weatherDataAIC.Country = weatherData.sys.country;
            weatherDataAIC.Sunrise = weatherData.sys.sunrise;
            weatherDataAIC.Sunset = weatherData.sys.sunset;
            weatherDataAIC.NameOfCity = weatherData.name;
            return weatherDataAIC;
        }
    }
}
