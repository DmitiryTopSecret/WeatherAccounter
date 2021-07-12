using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherAccounter.Models.Entites;

namespace WeatherAccounter.BL.Contracts
{
    public interface IWeatherService
    {
        IEnumerable<Weather> GetWeather();
        Weather GetWeatherById(int id);
    }
}
