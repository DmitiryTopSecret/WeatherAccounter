using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherAccounter.Models.Entites;
using WeatherAccounter.Models.ViewModels;

namespace WeatherAccounter.BL.Contracts
{
    public interface IWeatherService
    {
        IEnumerable<Weather> GetWeather();
        Weather GetWeatherById(int id);
        Weather AddWeather(WeatherViewModel weather);
        Weather UpdateWeather(int id, WeatherViewModel weather);
        Weather DeleteWeather(int id);
    }
}
