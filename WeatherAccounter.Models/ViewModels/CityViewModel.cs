using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherAccounter.Models.Entites;

namespace WeatherAccounter.Models.ViewModels
{
    public class CityViewModel
    {
        public string CityName { get; set; }
        public Weather Weather { get; set; }
    }
}
