using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherAccounter.Models.ViewModels;
using WeatherAccounter.Validations;

namespace WeatherAccounter.Infrastructure
{
    public static class ValidatorConfigurationExtension
    {
        public static void AddValidatorConfiguration(this IServiceCollection services)
        {
            services.AddTransient<IValidator<CityViewModel>, CityViewModelValidator>();

            services.AddTransient<IValidator<WeatherViewModel>, WeatherViewModelValidator>();
        }
    }
}
