using System;
using System.Net.Http;
using System.Threading.Tasks;
using BluffCityWeatherApp.Domain;
using Newtonsoft.Json;

namespace BluffCityWeatherApp.Infrastructure
{
    public class WeatherApiClient
    {
        private readonly string _apiKey;
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl;

        public WeatherApiClient()
        {
            _apiKey = "e5056c5a3a9a2e69127f61ef08d0a42d";
            _httpClient = new HttpClient();
            _baseUrl = "https://api.openweathermap.org/data/2.5/weather";
        }

        public async Task<WeatherData> GetWeatherDataAsync()
        {
            // Build the request URL, including the API key and the location parameter
            string requestUrl = $"?lat=44.34&lon=10.99&appid={_apiKey}";

            // Make the HTTP request to the weather API
            HttpResponseMessage response = await _httpClient.GetAsync(requestUrl);

            if (response.IsSuccessStatusCode)
            {
                // Deserialize the response JSON into WeatherData
                string content = await response.Content.ReadAsStringAsync();
                WeatherData weatherData = JsonConvert.DeserializeObject<WeatherData>(content);
                return weatherData;
            }
            else
            {
                // Handle error responses, logging, and possibly custom exceptions
                throw new WeatherApiException($"Weather API request failed with status code: {response.StatusCode}");
            }
        }
    }
}
