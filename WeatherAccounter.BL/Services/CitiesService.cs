using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherAccounter.BL.Contracts;
using WeatherAccounter.DAL.Contracts;
using WeatherAccounter.Models.Entites;
using WeatherAccounter.Models.ViewModels;

namespace WeatherAccounter.BL.Services
{
    public class CitiesService : ICitiesService
    {
        private readonly ICitiesRepositroy _citiesRepositroy;

        private readonly IMapper _mapper;

        public CitiesService(ICitiesRepositroy citiesRepositroy,
                             IMapper mapper)
        {
            _citiesRepositroy = citiesRepositroy;
            _mapper = mapper;
        }

        public City AddCity(CityViewModel city)
        {
            var cityEntity = _mapper.Map<City>(city);

            _citiesRepositroy.AddCity(cityEntity);

            return cityEntity;
        }

        public City DeleteCity(int id)
        {
            var deletedItem = _citiesRepositroy.DeleteCity(id);

            return deletedItem;
        }

        public IEnumerable<City> GetCities()
        {
            return _citiesRepositroy.GetCities();
        }

        public City GetCityById(int id)
        {
            return _citiesRepositroy.GetCityById(id);
        }

        public City UpdateCity(int id, CityViewModel city)
        {
            var cityFromRepo = _citiesRepositroy.GetCityById(id);

            _mapper.Map(city, cityFromRepo);

            _citiesRepositroy.UpdateCity(cityFromRepo);

            return cityFromRepo;
        }
    }
}
