using BluffCityWeatherApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluffCityWeatherApp.Infrastructure
{
    internal interface IWeatherApiClient
    {
        Task<WeatherData> GetWeatherDataAsync(string location);
    }
}
