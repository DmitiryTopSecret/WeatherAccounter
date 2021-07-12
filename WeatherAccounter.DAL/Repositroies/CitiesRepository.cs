using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherAccounter.DAL.Contracts;
using WeatherAccounter.Models.Entites;

namespace WeatherAccounter.DAL.Repositroies
{
    public class CitiesRepository : ICitiesRepositroy
    {
        private readonly WeatherAccounterContext _context;

        public CitiesRepository(WeatherAccounterContext context)
        {
            _context = context;
        }

        public IEnumerable<City> GetCities()
        {
            return _context.Cities.OrderBy(c => c.CityName);
        }

        public City GetCityById(int id)
        {
            return _context.Cities
                .FirstOrDefault(c => c.CityId == id);
        }
    }
}
