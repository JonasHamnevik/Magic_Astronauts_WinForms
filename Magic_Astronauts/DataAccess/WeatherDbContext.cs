using Magic_Astronauts.Core;
using Microsoft.EntityFrameworkCore;

namespace Magic_Astronauts.DataAccess;

public class WeatherDbContext : DbContext
{
    public DbSet<Weather> Weathers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MagicAstronauts;Integrated Security=True");
    }
}
