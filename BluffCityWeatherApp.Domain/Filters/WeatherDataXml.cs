using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BluffCityWeatherApp.Domain.Filters
{
    /// <summary>
    /// XML Filter
    /// </summary>
    [XmlRoot("WeatherData")]
    public class WeatherDataXml
    {
        [XmlElement("Temperature")]
        public double Temperature { get; set; }

        [XmlElement("Clouds")]
        public int Clouds { get; set; }

        [XmlElement("NameOfCity")]
        public string NameOfCity { get; set; }

        [XmlElement("Country")]
        public string Country { get; set; }
    }

}
