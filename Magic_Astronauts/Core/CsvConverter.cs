using System.Globalization;
using System.Text;

namespace Magic_Astronauts.Core
{
    public class CsvConverter : Weather
    {
        public static Weather Converter(string csvLine)
        {
            Weather weatherData = new Weather();
            decimal result;

            string[] values = csvLine
                .Trim()
                .Split(',', ' ');
            foreach (var item in values)
            {
                weatherData.Date = values[0];
                weatherData.Time = values[1];
                weatherData.Location = values[2];
                if (!decimal.TryParse(values[3], out result))
                {
                    break;
                }
                else
                {
                    weatherData.Temp = decimal.Parse(values[3], CultureInfo.InvariantCulture);
                }
                weatherData.Humidity = decimal.Parse(values[4]);
            }
            return weatherData;
            //weatherData.Date = values[0];
            //weatherData.Time = values[1];
            //weatherData.Location = values[2];
            //weatherData.Temp = decimal.Parse(values[3]);
            //weatherData.Humidity = decimal.Parse(values[4]);
            //return weatherData;
        }
    }
}
