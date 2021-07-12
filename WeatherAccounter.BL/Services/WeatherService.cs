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
    public class WeatherService : IWeatherService
    {
        private readonly IWeatherRepository _weatherRepository;

        private readonly IMapper _mapper;

        public WeatherService(IWeatherRepository weatherRepository,
                              IMapper mapper)
        {
            _weatherRepository = weatherRepository;
            _mapper = mapper; 
        }

        public Weather AddWeather(WeatherViewModel weather)
        {
            var weatherEntity = _mapper.Map<Weather>(weather);

            _weatherRepository.AddWeather(weatherEntity);

            return weatherEntity;
        }

        public Weather DeleteWeather(int id)
        {
            var deletedItem = _weatherRepository.DeleteWeather(id);

            return deletedItem;
        }

        public IEnumerable<Weather> GetWeather()
        {
            return _weatherRepository.GetWeather();
        }

        public Weather GetWeatherById(int id)
        {
            return _weatherRepository.GetWeatherById(id);
        }

        public Weather UpdateWeather(int id, WeatherViewModel weather)
        {
            var weatherFromRepo = _weatherRepository.GetWeatherById(id);

            _mapper.Map(weather, weatherFromRepo);

            _weatherRepository.UpdateWeather(weatherFromRepo);

            return weatherFromRepo;
        }
    }
}
