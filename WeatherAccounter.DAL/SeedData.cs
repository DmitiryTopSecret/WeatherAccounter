using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using WeatherAccounter.Models.Entites;

namespace WeatherAccounter.DAL
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            WeatherAccounterContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<WeatherAccounterContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Cities.Any())
            {
                context.Cities.AddRange(
                    new City
                    {
                        CityName = "Kharkov",
                        Weather = new Weather
                        {
                            Date = DateTime.Today.AddDays(-4),
                            Timestamp = DateTime.Today.AddDays(-4),
                            TemperatureC = 29,
                            MinTemperature = 21,
                            MaxTemperature = 30,
                        }
                    },
                    new City
                    {
                        CityName = "Kiev",
                        Weather = new Weather
                        {
                            Date = DateTime.Today.AddDays(-4),
                            Timestamp = DateTime.Today.AddDays(-4),
                            TemperatureC = 25,
                            MinTemperature = 19,
                            MaxTemperature = 28,
                        }
                    },
                    new City
                    {
                        CityName = "Odessa",
                        Weather = new Weather
                        {
                            Date = DateTime.Today.AddDays(-3),
                            Timestamp = DateTime.Today.AddDays(-3),
                            TemperatureC = 30,
                            MinTemperature = 22,
                            MaxTemperature = 32,
                        }
                    },
                    new City
                    {
                        CityName = "Dnepr",
                        Weather = new Weather
                        {
                            Date = DateTime.Today.AddDays(-1),
                            Timestamp = DateTime.Today.AddDays(-1),
                            TemperatureC = 27,
                            MinTemperature = 19,
                            MaxTemperature = 27,
                        }
                    },
                    new City
                    {
                        CityName = "Lvov",
                        Weather = new Weather
                        {
                            Date = DateTime.Today,
                            Timestamp = DateTime.Today,
                            TemperatureC = 23,
                            MinTemperature = 18,
                            MaxTemperature = 25,
                        }
                    },
                    new City
                    {
                        CityName = "Donetsk",
                        Weather = new Weather
                        {
                            Date = DateTime.Today.AddDays(-5),
                            Timestamp = DateTime.Today.AddDays(-5),
                            TemperatureC = 24,
                            MinTemperature = 19,
                            MaxTemperature = 27,
                        }
                    },
                    new City
                    {
                        CityName = "Nikolaev",
                        Weather = new Weather
                        {
                            Date = DateTime.Today.AddDays(3),
                            Timestamp = DateTime.Today.AddDays(3),
                            TemperatureC = 23,
                            MinTemperature = 18,
                            MaxTemperature = 25,
                        }
                    },
                    new City
                    {
                        CityName = "Zhitomer",
                        Weather = new Weather
                        {
                            Date = DateTime.Today.AddDays(3),
                            Timestamp = DateTime.Today.AddDays(3),
                            TemperatureC = 20,
                            MinTemperature = 19,
                            MaxTemperature = 27,
                        }
                    });

                context.SaveChanges();
            }
        }

    }
}
