using System;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistences {
    public class DataContext : DbContext { 
        public DataContext(DbContextOptions options):base(options)
        {
            
        }
        public DbSet<WeatherForecast> WeatherForecasts { get; set; }
        public DbSet<Activity> Activities { get; set; }
        protected override void OnModelCreating(ModelBuilder builder){
            builder.Entity<WeatherForecast>()
            .HasData(
                new WeatherForecast
                {
                    Id = 1,
                    Date = "14/06/2020",
                    TempC = "46C",
                    TempF = "113F"
                },
                new WeatherForecast
                {
                    Id = 2,
                    Date = "14/06/2020",
                    TempC = "42C",
                    TempF = "103F"
                },
                new WeatherForecast
                {
                    Id = 3,
                    Date = "13/06/2020",
                    TempC = "35C",
                    TempF = "93F"
                }

            );
        }
    }
}