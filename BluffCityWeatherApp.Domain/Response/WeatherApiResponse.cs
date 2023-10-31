using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluffCityWeatherApp.Domain
{
    /// <summary>
    /// Weather api response received from The weather API
    /// </summary>
    public class WeatherApiResponse
    {
        public Coord coord { get; set; }
        public List<Weather> weather { get; set; }
        public string name { get; set; }
        public Main main { get; set; }
        public Wind wind { get; set; }
        public Cloud clouds { get; set; }
        public int visibility { get; set; }
        public Sys sys { get; set; }
    }

    public class Coord
    {
        public double lon { get; set; }
        public double lat { get; set; }
    }

    public class Weather
    {
        public int id { get; set; }
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
    }

    public class Main
    {
        public double temp { get; set; }
        public double humidity { get; set; }
        public double pressure { get; set; }
    }

    public class Wind
    {
        public double speed { get; set; }
    }

    public class Cloud
    {
        public int all { get; set; }
    }

    public class Sys
    {
        public string country { get; set; }
        public double sunrise { get; set; }
        public double sunset { get; set; }
    }

}
