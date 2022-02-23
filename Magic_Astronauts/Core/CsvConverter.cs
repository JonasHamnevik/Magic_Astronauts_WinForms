using System.Globalization;

namespace Magic_Astronauts.Core
{
    public class CsvConverter : Weather
    {
        public static Weather Converter(string csvLine, out Weather data)
        {
            IList<Weather> weatherList = new List<Weather>();
            data = new Weather();

            string[] values = csvLine
                .Trim()
                .Split(',');
            data = new Weather
            {
                Date = Convert.ToDateTime(values[0]),
                Location = values[1],
                Temp = float.Parse(values[2], NumberStyles.Float, CultureInfo.InvariantCulture),
                Humidity = int.Parse(values[3])
            };
            return data;
            
            //weatherData.Date = DateTime.ParseExact(values[0].Substring(0, 10), "yyyy-MM-dd", CultureInfo.CurrentCulture);
            //weatherData.Location = values[1];
            //weatherData.Temp = float.Parse(values[2], NumberStyles.Float, CultureInfo.InvariantCulture);
            //weatherData.Humidity = int.Parse(values[3]);
            //return weatherData;
        }
    }
}
