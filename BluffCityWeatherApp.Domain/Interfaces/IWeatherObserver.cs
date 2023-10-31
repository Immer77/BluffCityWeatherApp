using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluffCityWeatherApp.Domain.Interfaces
{
    /// <summary>
    /// Observer pattern for weather observers
    /// </summary>
    public interface IWeatherObserver
    {
        void Update(WeatherApiResponse weatherData);
    }
}
