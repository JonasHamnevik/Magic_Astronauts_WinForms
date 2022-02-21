using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace Magic_Astronauts.Core;

public class Weather
{
    public int WeatherID { get; set; }
    public string Date { get; set; }
    public string Place { get; set; }
    public string Temp { get; set; }
    public decimal Humidity { get; set; }

    public static Weather csvConverter(string csvLine)
    {
        string[] values = csvLine.Trim().Replace("âˆ’", "").Split(',');
        Weather weatherData = new Weather();
        weatherData.Date = values[0];
        weatherData.Place = values[1];
        weatherData.Temp = values[2];
        weatherData.Humidity = decimal.Parse(values[3]);
        return weatherData;
    }
}
