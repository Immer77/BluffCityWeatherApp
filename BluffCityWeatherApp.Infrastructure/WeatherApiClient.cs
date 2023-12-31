﻿using System;
using System.Net.Http;
using System.Threading.Tasks;
using BluffCityWeatherApp.Domain;
using BluffCityWeatherApp.Domain.Interfaces;
using Newtonsoft.Json;

namespace BluffCityWeatherApp.Infrastructure
{
    /// <summary>
    /// Weather Api Client to make calls to the weather API
    /// </summary>
    public class WeatherApiClient
    {
        private readonly string _apiKey;
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl;
        private IWeatherPublisher _weatherPublisher;

        /// <summary>
        /// Constructor that takes in the weather publisher
        /// </summary>
        /// <param name="weatherPublisher"></param>
        public WeatherApiClient(IWeatherPublisher weatherPublisher)
        {
            _apiKey = "e5056c5a3a9a2e69127f61ef08d0a42d";
            _httpClient = new HttpClient();
            _baseUrl = "https://api.openweathermap.org/data/2.5/weather";
            _weatherPublisher = weatherPublisher;
        }

        /// <summary>
        /// HTTP Get call to the weather API
        /// </summary>
        /// <returns></returns>
        /// <exception cref="WeatherApiException"></exception>
        public async Task GetWeatherDataAsync()
        {
            // Build the request URL, including the API key and the location parameter
            string requestUrl = "?lat=44.34&lon=10.99&appid=" +_apiKey;

            _httpClient.BaseAddress = new Uri(_baseUrl);
            // Make the HTTP request to the weather API
            HttpResponseMessage response = await _httpClient.GetAsync(requestUrl);

            if (response.IsSuccessStatusCode)
            {
                // Deserialize the response JSON into WeatherData
                string content = await response.Content.ReadAsStringAsync();
                Console.WriteLine(content);
                WeatherApiResponse weatherData = JsonConvert.DeserializeObject<WeatherApiResponse>(content);

                // Notify subscribers with the new weather data
                await _weatherPublisher.NotifySubscribersAsync(weatherData);
            }
            else
            {
                // Handle error responses, logging, and possibly custom exceptions
                throw new WeatherApiException($"Weather API request failed with status code: {response.StatusCode}");
            }
        }
    }
}
