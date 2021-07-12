using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherAccounter.BL.Contracts;
using WeatherAccounter.BL.Services;

namespace WeatherAccounter.Infrastructure
{
    public static class ServicesConfigurationExtension
    {
        public static void AddServicesConfiguration(this IServiceCollection services)
        {
            services.AddScoped<ICitiesService, CitiesService>();

            services.AddScoped<IWeatherService, WeatherService>();
        }
    }
}
