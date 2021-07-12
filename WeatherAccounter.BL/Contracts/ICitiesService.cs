using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherAccounter.Models.Entites;
using WeatherAccounter.Models.ViewModels;

namespace WeatherAccounter.BL.Contracts
{
    public interface ICitiesService
    {
        IEnumerable<City> GetCities();
        City GetCityById(int id);
        City AddCity(CityViewModel city);
        City UpdateCity(int id, CityViewModel city);
        City DeleteCity(int id);
    }
}
