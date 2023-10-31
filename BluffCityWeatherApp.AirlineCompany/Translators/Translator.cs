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
    /// <summary>
    /// Extension class
    /// </summary>
    public static class Translator
    {
        /// <summary>
        /// Sas translator, translating into a class
        /// </summary>
        /// <param name="weatherApiResponse"></param>
        /// <returns></returns>
        public static WeatherDataAC SASTranslate(this WeatherApiResponse weatherApiResponse)
        {
            WeatherDataAC weatherData = new WeatherDataAC();
            weatherData.Temperature = weatherApiResponse.main.temp;
            weatherData.clouds = weatherApiResponse.clouds.all;
            weatherData.NameOfCity = weatherApiResponse.name;
            weatherData.Country = weatherApiResponse.sys.country;
            return weatherData;
        }

        /// <summary>
        /// British Airways Translator that translates into XML
        /// </summary>
        /// <param name="weatherApiResponse"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Dublicate of British Airways Translator that translates into XML
        /// However decided to repeat myself since it seperates them for show sake.
        /// </summary>
        /// <param name="weatherApiResponse"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Standard KLM translator which returns a string
        /// </summary>
        /// <param name="weatherApiResponse"></param>
        /// <returns></returns>
        public static string KLMTranslator(this WeatherApiResponse weatherApiResponse)
        {
            string formattedString = $"Temperature: {weatherApiResponse.main.temp} K, Clouds: {weatherApiResponse.clouds.all}%, NameOfCity: {weatherApiResponse.name}, Country: {weatherApiResponse.sys.country}";
            return formattedString;
        }
    }
}
