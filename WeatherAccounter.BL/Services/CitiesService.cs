using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherAccounter.BL.Contracts;
using WeatherAccounter.DAL.Contracts;
using WeatherAccounter.Models.Entites;

namespace WeatherAccounter.BL.Services
{
    public class CitiesService : ICitiesService
    {
        private readonly ICitiesRepositroy _citiesRepositroy;

        public CitiesService(ICitiesRepositroy citiesRepositroy)
        {
            _citiesRepositroy = citiesRepositroy;
        }

        public IEnumerable<City> GetCities()
        {
            return _citiesRepositroy.GetCities();
        }

        public City GetCityById(int id)
        {
            return _citiesRepositroy.GetCityById(id);
        }
    }
}
