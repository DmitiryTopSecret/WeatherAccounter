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
    public class WeatherService : IWeatherService
    {
        private readonly IWeatherRepository _weatherRepository;

        public WeatherService(IWeatherRepository weatherRepository)
        {
            _weatherRepository = weatherRepository;
        }
        public IEnumerable<Weather> GetWeather()
        {
            return _weatherRepository.GetWeather();
        }

        public Weather GetWeatherById(int id)
        {
            return _weatherRepository.GetWeatherById(id);
        }
    }
}
