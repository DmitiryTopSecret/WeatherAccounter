using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAccounter.Models.Entites
{
    public class Weather
    {
        public int WeatherId { get; set; }
        public City City { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.Now;
        public int TemperatureC { get; set; }
        public int MinTemperature { get; set; }
        public int MaxTemperature { get; set; }
        public int AvarageTemperature => (int)(MinTemperature + MaxTemperature) / 2;

    }
}
