using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluffCityWeatherApp.Domain.Interfaces
{
    public interface IWeatherPublisher
    {
        Task NotifySubscribersAsync(WeatherApiResponse weatherData);
        void Subscribe(IWeatherObserver subscriber);
        void Unsubscribe(IWeatherObserver subscriber);
    }
}
