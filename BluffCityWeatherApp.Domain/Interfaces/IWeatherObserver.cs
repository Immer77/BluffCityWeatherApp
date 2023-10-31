using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluffCityWeatherApp.Domain.Interfaces
{
    public interface IWeatherObserver
    {
        void Update(WeatherApiResponse weatherData);
    }
}
