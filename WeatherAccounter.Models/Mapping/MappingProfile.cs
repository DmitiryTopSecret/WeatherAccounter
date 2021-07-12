using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherAccounter.Models.Entites;
using WeatherAccounter.Models.ViewModels;

namespace WeatherAccounter.Models.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<City, CityViewModel>();

            CreateMap<CityViewModel, City>();

            CreateMap<Weather, WeatherViewModel>();

            CreateMap<WeatherViewModel, Weather>();
        }
    }
}
