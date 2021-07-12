using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WeatherAccounter.Models.Entites;

namespace WeatherAccounter.DAL
{
    public class WeatherAccounterContext : DbContext
    {
        public WeatherAccounterContext(DbContextOptions<WeatherAccounterContext> options)
            :base(options)
        {
        }

        public DbSet<Weather> Weather { get; set; }
        public DbSet<City> Cities { get; set; }
    }
}
