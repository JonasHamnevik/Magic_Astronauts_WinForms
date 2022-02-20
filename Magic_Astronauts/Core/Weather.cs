using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace Magic_Astronauts.Core;

public class Weather : IWeather
{
    public string Date { get; set; }
    public string Place { get; set; }
    public string Temp { get; set; }
    public decimal Humidity { get; set; }

    public static Weather csvConverter(string csvLine)
    {
        string[] values = csvLine.Trim().Split(',');
        Weather weatherData = new Weather();
        weatherData.Date = values[0];
        weatherData.Place = values[1];
        //2016-11-06 13:17 har bokstäver istället för siffror för temp
        weatherData.Temp = values[2].PadLeft(2);
        weatherData.Humidity = decimal.Parse(values[3]);
        return weatherData;
    }
}
