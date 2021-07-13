using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherAccounter.Models.ViewModels;

namespace WeatherAccounter.Validations
{
    public class CityViewModelValidator : AbstractValidator<CityViewModel>
    {
        public CityViewModelValidator()
        {
            RuleFor(x => x.CityName)
                .NotEmpty()
                .MinimumLength(2)
                .MaximumLength(25);
            RuleFor(x => x.Weather)
                .NotNull();
        }
    }
}
