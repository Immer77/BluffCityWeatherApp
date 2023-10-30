using BluffCityWeatherApp.Domain;
using BluffCityWeatherApp.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluffCityWeatherApp.AirportInfoCenter
{
    internal class AirportInformationCenterService
    {
        private readonly WeatherApiClient weatherApi;

        public AirportInformationCenterService()
        {
            weatherApi = new WeatherApiClient();
        }

        public async Task<WeatherDataAIC> GetWeatherInfoForAirportInformationCenter(string airportCode)
        {
            // Call the Weather API to get weather data for the airport's location
            WeatherData weatherData = await weatherApi.GetWeatherDataAsync();

            // Process the weather data to create AirportWeatherInfo
            WeatherDataAIC airportWeatherInfo = FilterWeatherData(weatherData);

            return airportWeatherInfo;
        }

        /// <summary>
        /// Using the Content Filter Pattern
        /// </summary>
        private WeatherDataAIC FilterWeatherData(WeatherData weatherData)
        {
            WeatherDataAIC weatherDataAIC = new WeatherDataAIC();
            weatherDataAIC.Temperature = weatherData.Temperature;
            weatherDataAIC.Country = weatherData.Country;
            weatherDataAIC.Sunrise = weatherData.Sunrise;
            weatherDataAIC.Sunset = weatherData.Sunset;
            weatherDataAIC.NameOfCity = weatherData.NameOfCity;
            return weatherDataAIC;
        }
    }
}
