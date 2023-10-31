using BluffCityWeatherApp.Domain;
using BluffCityWeatherApp.Domain.Filters;
using BluffCityWeatherApp.Domain.Interfaces;
using BluffCityWeatherApp.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluffCityWeatherApp.AirTrafficControl
{
    public class AirTrafficControlService : IWeatherObserver
    {

        public AirTrafficControlService() { }


        public void Update(WeatherApiResponse weatherData)
        {
            Console.WriteLine("Weather Update for AirTrafficControlService");
            WeatherDataATC data = FilterWeatherData(weatherData);
            Console.WriteLine(data);
        }

        /// <summary>
        /// Using the Content Filter Pattern
        /// </summary>
        private WeatherDataATC FilterWeatherData(WeatherApiResponse weatherData)
        {
            WeatherDataATC weatherDataATC = new WeatherDataATC();
            weatherDataATC.Temperature = weatherData.main.temp;
            weatherDataATC.Country = weatherData.sys.country;
            weatherDataATC.NameOfCity = weatherData.name;
            weatherDataATC.Pressure = weatherData.main.pressure;
            weatherDataATC.Humidity = weatherData.main.humidity;
            weatherDataATC.Coordinates = "Longitude: " + weatherData.coord.lon + "Latitude: " + weatherData.coord.lat;
            weatherDataATC.Clouds = weatherData.clouds.all;
            weatherDataATC.Wind = weatherData.wind.speed;
            weatherDataATC.Visibility = weatherData.visibility;
            return weatherDataATC;
        }
    }
}
