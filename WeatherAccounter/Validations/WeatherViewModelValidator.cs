using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherAccounter.Models.ViewModels;

namespace WeatherAccounter.Validations
{
    public class WeatherViewModelValidator : AbstractValidator<WeatherViewModel>
    {
        public WeatherViewModelValidator()
        {
            RuleFor(x => x.Date)
                .NotEmpty();
            RuleFor(x => x.Timestamp)
                .NotEmpty();
            RuleFor(x => x.TemperatureC)
                .NotEmpty()
                .InclusiveBetween(-50, 50);
            RuleFor(x => x.MinTemperature)
                .NotEmpty();
            RuleFor(x => x.MaxTemperature)
                .NotEmpty();
            RuleFor(x => x.AvarageTemperature)
                .NotEmpty();
        }
    }
}
