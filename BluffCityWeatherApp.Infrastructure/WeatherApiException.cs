using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluffCityWeatherApp.Infrastructure
{
    public class WeatherApiException : Exception
    {
        public WeatherApiException() { }

        public WeatherApiException(string message) : base(message) { }

        public WeatherApiException(string message, Exception innerException) : base(message, innerException) { }
    }
}
