using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;
using WeatherAPI.Entities;

namespace WeatherAPI.Context
{
    public class WeatherContext : DbContext 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source =EA;Database=WeatherApiDB;User Id=sa;Password=123456;Trusted_Connection=true;");

        }
        public DbSet<City> Cities { get;set; }
    }
}
