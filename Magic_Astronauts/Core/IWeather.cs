namespace Magic_Astronauts.Core
{
    public interface IWeather
    {
        string Date { get; set; }
        string Place { get; set; }
        string Temp { get; set; }
        decimal Humidity { get; set; }
    }
}