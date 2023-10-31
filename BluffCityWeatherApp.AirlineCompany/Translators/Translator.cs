using BluffCityWeatherApp.Domain;
using BluffCityWeatherApp.Domain.Filters;
using BluffCityWeatherApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace BluffCityWeatherApp.AirlineCompany.Translators
{
    public static class Translator
    {
        public static WeatherDataAC SASTranslate(this WeatherApiResponse weatherApiResponse)
        {
            WeatherDataAC weatherData = new WeatherDataAC();
            weatherData.Temperature = weatherApiResponse.main.temp;
            weatherData.clouds = weatherApiResponse.clouds.all;
            weatherData.NameOfCity = weatherApiResponse.name;
            weatherData.Country = weatherApiResponse.sys.country;
            return weatherData;
        }

        public static string BritishAirwaysTranslator(this WeatherApiResponse weatherApiResponse)
        {
            var weatherDataXml = new WeatherDataXml
            {
                Temperature = weatherApiResponse.main.temp,
                Clouds = weatherApiResponse.clouds.all,
                NameOfCity = weatherApiResponse.name,
                Country = weatherApiResponse.sys.country
            };

            // Use XmlSerializer to convert the object to XML
            var serializer = new XmlSerializer(typeof(WeatherDataXml));
            using (var stringWriter = new StringWriter())
            {
                serializer.Serialize(stringWriter, weatherDataXml);
                return stringWriter.ToString();
            }
        }

        public static string SouthWestAirlinesTranslator(this WeatherApiResponse weatherApiResponse)
        {
            var weatherDataXml = new WeatherDataXml
            {
                Temperature = weatherApiResponse.main.temp,
                Clouds = weatherApiResponse.clouds.all,
                NameOfCity = weatherApiResponse.name,
                Country = weatherApiResponse.sys.country
            };

            // Use XmlSerializer to convert the object to XML
            var serializer = new XmlSerializer(typeof(WeatherDataXml));
            using (var stringWriter = new StringWriter())
            {
                serializer.Serialize(stringWriter, weatherDataXml);
                return stringWriter.ToString();
            }
        }

        public static string KLMTranslator(this WeatherApiResponse weatherApiResponse)
        {
            string formattedString = $"Temperature: {weatherApiResponse.main.temp} K, Clouds: {weatherApiResponse.clouds.all}%, NameOfCity: {weatherApiResponse.name}, Country: {weatherApiResponse.sys.country}";
            return formattedString;
        }
    }
}
