using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherAccounter.DAL.Contracts;
using WeatherAccounter.Models.Entites;

namespace WeatherAccounter.DAL.Repositroies
{
    public class WeatherRepository : IWeatherRepository
    {
        private readonly WeatherAccounterContext _context;

        public WeatherRepository(WeatherAccounterContext context)
        {
            _context = context;
        }

        public Weather AddWeather(Weather weather)
        {
            var result = _context.Weather.Add(weather);

            _context.SaveChanges();

            return result.Entity;
        }

        public Weather DeleteWeather(int id)
        {
            var result = _context.Weather
               .FirstOrDefault(e => e.WeatherId == id);

            if (result != null)
            {
                _context.Weather.Remove(result);

                _context.SaveChanges();
            }

            return result;
        }

        public IEnumerable<Weather> GetWeather()
        {
            return _context.Weather
                .OrderBy(w => w.WeatherId);
        }

        public Weather GetWeatherById(int id)
        {
            return _context.Weather
                .SingleOrDefault(w => w.WeatherId == id);
        }

        public Weather UpdateWeather(Weather weather)
        {
            var result = _context.Weather.Update(weather);

            _context.SaveChanges();

            return result.Entity;
        }
    }
}
