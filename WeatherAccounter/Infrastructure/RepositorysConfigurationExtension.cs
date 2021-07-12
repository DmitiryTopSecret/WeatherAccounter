using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherAccounter.DAL.Contracts;
using WeatherAccounter.DAL.Repositroies;

namespace WeatherAccounter.Infrastructure
{
    public static class RepositorysConfigurationExtension
    {
        public static void AddRepositorysConfiguration(this IServiceCollection services)
        {
            services.AddTransient<ICitiesRepositroy, CitiesRepository>();

            services.AddTransient<IWeatherRepository, WeatherRepository>();
        }
    }
}
