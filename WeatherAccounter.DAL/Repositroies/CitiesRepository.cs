using Microsoft.EntityFrameworkCore;
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

        public City AddCity(City city)
        {
            var result = _context.Cities.Add(city);

            _context.SaveChanges();

            return result.Entity;
        }

        public City DeleteCity(int id)
        {
            var result = _context.Cities
               .FirstOrDefault(e => e.CityId == id);

            if (result != null)
            {
                _context.Cities.Remove(result);

                _context.SaveChanges();
            }

            return result;
        }

        public IEnumerable<City> GetCities()
        {
            return _context.Cities
                .Include("Weather")
                .OrderBy(c => c.CityName);
        }


        public City GetCityById(int id)
        {
            return _context.Cities
                .Include("Weather")
                .FirstOrDefault(c => c.CityId == id);
        }

        public City UpdateCity(City city)
        {
            var result = _context.Cities.Update(city);

            _context.SaveChanges();

            return result.Entity;
        }
    }
}
