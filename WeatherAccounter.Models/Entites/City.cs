using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAccounter.Models.Entites
{
    public class City
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public List<Weather> Weather { get; set; }
    }
}
