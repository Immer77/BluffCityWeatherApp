using BluffCityWeatherApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluffCityWeatherApp.Domain
{
    /// <summary>
    /// Actual implementation of the weather publisher (Subject)
    /// </summary>
    public class WeatherPublisher : IWeatherPublisher
    {
        private List<IWeatherObserver> _subscribers = new List<IWeatherObserver>();

        public async Task NotifySubscribersAsync(WeatherApiResponse weatherData)
        {
            foreach (var subscriber in _subscribers)
            {
                subscriber.Update(weatherData);
            }
        }

        public void Subscribe(IWeatherObserver subscriber)
        {
            _subscribers.Add(subscriber);
        }

        public void Unsubscribe(IWeatherObserver subscriber)
        {
            _subscribers.Remove(subscriber);
        }
    }

}
