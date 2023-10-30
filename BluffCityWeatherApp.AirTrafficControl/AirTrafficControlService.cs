using BluffCityWeatherApp.Domain;
using BluffCityWeatherApp.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluffCityWeatherApp.AirTrafficControl
{
    internal class AirTrafficControlService
    {
        private readonly WeatherApiClient weatherApi;

        public AirTrafficControlService()
        {
            weatherApi = new WeatherApiClient();
        }

        public async Task<WeatherDataATC> GetWeatherInfoForAirportControlCenter(string airportCode)
        {
            // Call the Weather API to get weather data for the airport's location
            WeatherData weatherData = await weatherApi.GetWeatherDataAsync();

            // Process the weather data to create AirportWeatherInfo
            WeatherDataATC airportWeatherInfo = FilterWeatherData(weatherData);

            return airportWeatherInfo;
        }

        /// <summary>
        /// Using the Content Filter Pattern
        /// </summary>
        private WeatherDataATC FilterWeatherData(WeatherData weatherData)
        {
            WeatherDataATC weatherDataATC = new WeatherDataATC();
            weatherDataATC.Temperature = weatherData.Temperature;
            weatherDataATC.Country = weatherData.Country;
            weatherDataATC.NameOfCity = weatherData.NameOfCity;
            weatherDataATC.Pressure = weatherData.Pressure;
            weatherDataATC.Humidity = weatherData.Humidity;
            weatherDataATC.Coordinates = weatherData.Coordinates;
            weatherDataATC.Clouds = weatherData.Clouds;
            weatherDataATC.Wind = weatherData.Wind;
            weatherDataATC.Visibility = weatherData.Visibility;
            return weatherDataATC;
        }
    }
}
