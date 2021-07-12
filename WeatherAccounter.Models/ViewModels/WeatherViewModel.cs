using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAccounter.Models.ViewModels
{
    public class WeatherViewModel
    {
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public DateTime Timestamp { get; set; }
        public int TemperatureC { get; set; }
        public int MinTemperature { get; set; }
        public int MaxTemperature { get; set; }
        public int AvarageTemperature => (MinTemperature + MaxTemperature) / 2;
    }
}
