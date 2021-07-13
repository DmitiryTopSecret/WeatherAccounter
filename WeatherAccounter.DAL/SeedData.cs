using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
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
                        Weather = new List<Weather>
                        {
                            new Weather()
                            {
                                Date = DateTime.Today.AddDays(-4),
                                Timestamp = DateTime.Today.AddDays(-4).AddHours(5),
                                TemperatureC = 29,
                                MinTemperature = 21,
                                MaxTemperature = 30,
                            },
                            new Weather()
                            {
                                Date = DateTime.Today.AddDays(-4),
                                Timestamp = DateTime.Today.AddDays(-4).AddHours(10),
                                TemperatureC = 27,
                                MinTemperature = 20,
                                MaxTemperature = 29,
                            }
                        }
                    },
                    new City
                    {

                        CityName = "Kiev",
                        Weather = new List<Weather>
                        {
                            new Weather()
                            {
                                Date = DateTime.Today.AddDays(-4),
                                Timestamp = DateTime.Today.AddDays(-4).AddHours(5),
                                TemperatureC = 25,
                                MinTemperature = 19,
                                MaxTemperature = 28,
                            },
                            new Weather()
                            {
                                Date = DateTime.Today.AddDays(-4),
                                Timestamp = DateTime.Today.AddDays(-4).AddHours(10),
                                TemperatureC = 23,
                                MinTemperature = 17,
                                MaxTemperature = 26,
                            }
                        }
                    },
                    new City
                    {
                        CityName = "Odessa",
                        Weather = new List<Weather>
                        {
                            new Weather()
                            {
                                Date = DateTime.Today.AddDays(-3),
                                Timestamp = DateTime.Today.AddDays(-3).AddHours(5),
                                TemperatureC = 30,
                                MinTemperature = 22,
                                MaxTemperature = 32,
                            },
                            new Weather()
                            {
                                Date = DateTime.Today.AddDays(-3),
                                Timestamp = DateTime.Today.AddDays(-3).AddHours(10),
                                TemperatureC = 23,
                                MinTemperature = 17,
                                MaxTemperature = 26,
                            }
                        }
                    },
                    new City
                    {
                        CityName = "Dnepr",
                        Weather = new List<Weather>
                        {
                            new Weather()
                            {
                                Date = DateTime.Today.AddDays(-1),
                                Timestamp = DateTime.Today.AddDays(-1).AddHours(5),
                                TemperatureC = 27,
                                MinTemperature = 19,
                                MaxTemperature = 27,
                            },
                            new Weather()
                            {
                                Date = DateTime.Today.AddDays(-1),
                                Timestamp = DateTime.Today.AddDays(-1).AddHours(10),
                                TemperatureC = 23,
                                MinTemperature = 17,
                                MaxTemperature = 26,
                            }
                        }
                    },
                    new City
                    {
                        CityName = "Lvov",
                        Weather = new List<Weather>
                        {
                            new Weather()
                            {
                                Date = DateTime.Today,
                                Timestamp = DateTime.Today.AddHours(5),
                                TemperatureC = 23,
                                MinTemperature = 18,
                                MaxTemperature = 25,
                            },
                            new Weather()
                            {
                                Date = DateTime.Today.AddDays(-4),
                                Timestamp = DateTime.Today.AddDays(-4).AddHours(10),
                                TemperatureC = 23,
                                MinTemperature = 17,
                                MaxTemperature = 26,
                            }
                        }
                    },
                    new City
                    {
                        CityName = "Donetsk",
                        Weather = new List<Weather>
                        {
                            new Weather()
                            {
                                Date = DateTime.Today.AddDays(-7),
                                Timestamp = DateTime.Today.AddDays(-7).AddHours(5),
                                TemperatureC = 21,
                                MinTemperature = 15,
                                MaxTemperature = 27,
                            },
                            new Weather()
                            {
                                Date = DateTime.Today.AddDays(-7),
                                Timestamp = DateTime.Today.AddDays(-7).AddHours(10),
                                TemperatureC = 23,
                                MinTemperature = 17,
                                MaxTemperature = 26,
                            }
                        }
                    },
                    new City
                    {
                        CityName = "Nikolaev",
                        Weather = new List<Weather>
                        {
                            new Weather()
                            {
                                Date = DateTime.Today.AddDays(3),
                                Timestamp = DateTime.Today.AddDays(3).AddHours(5),
                                TemperatureC = 20,
                                MinTemperature = 15,
                                MaxTemperature = 25,
                            },
                            new Weather()
                            {
                                Date = DateTime.Today.AddDays(3),
                                Timestamp = DateTime.Today.AddDays(3).AddHours(10),
                                TemperatureC = 22,
                                MinTemperature = 17,
                                MaxTemperature = 27,
                            }
                        }
                    },
                    new City
                    {
                        CityName = "Zhitomer",
                        Weather = new List<Weather>
                        {
                            new Weather()
                            {
                                Date = DateTime.Today.AddDays(2),
                                Timestamp = DateTime.Today.AddDays(2).AddHours(5),
                                TemperatureC = 19,
                                MinTemperature = 16,
                                MaxTemperature = 24,
                            },
                            new Weather()
                            {
                                Date = DateTime.Today.AddDays(2),
                                Timestamp = DateTime.Today.AddDays(2).AddHours(10),
                                TemperatureC = 20,
                                MinTemperature = 16,
                                MaxTemperature = 28,
                            }
                        }
                    });

                context.SaveChanges();
            }
        }

    }
}
