using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BluffCityWeatherApp.Domain;
using BluffCityWeatherApp.Infrastructure;
using BluffCityWeatherApp.AirportInfoCenter;
using BluffCityWeatherApp.AirTrafficControl;
using BluffCityWeatherApp.AirlineCompany.Airlines;

namespace BluffCityWeatherApp
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            // Observers
            AirportInformationCenterService AIC = new AirportInformationCenterService();
            AirTrafficControlService ATC = new AirTrafficControlService();
            Airline SAS = new SAS();
            Airline SouthWest = new SouthWest();
            Airline BritishAirways = new BritishAirways();
            Airline KLM = new KLM();

            // Subscribing
            WeatherPublisher weatherPublisher = new WeatherPublisher();
            weatherPublisher.Subscribe(AIC);
            weatherPublisher.Subscribe(ATC);
            weatherPublisher.Subscribe(SAS);
            weatherPublisher.Subscribe(SouthWest);
            weatherPublisher.Subscribe(BritishAirways);
            weatherPublisher.Subscribe(KLM);

            WeatherApiClient weatherApiClient = new WeatherApiClient(weatherPublisher);
            await weatherApiClient.GetWeatherDataAsync();

            Console.ReadLine();
        }
    }
}
