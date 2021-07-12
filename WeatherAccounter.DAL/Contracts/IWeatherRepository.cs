using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherAccounter.Models.Entites;

namespace WeatherAccounter.DAL.Contracts
{
    public interface IWeatherRepository
    {
        IEnumerable<Weather> GetWeather();
        Weather GetWeatherById(int id);
        Weather AddWeather(Weather weather);
        Weather UpdateWeather(Weather weather);
        Weather DeleteWeather(int id);
    }
}
