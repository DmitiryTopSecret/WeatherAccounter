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
        public IEnumerable<Weather> GetWeather()
        {
            throw new NotImplementedException();
        }

        public Weather GetWeatherById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
