using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherAccounter.BL.Contracts;
using WeatherAccounter.Models.Entites;

namespace WeatherAccounter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        private readonly IWeatherService _weatherService;

        public WeatherController(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Weather> GetWeather()
        {
            var weather = _weatherService.GetWeather();

            if(weather == null)
            {
                return NotFound();
            }

            return Ok(weather.ToList());
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Weather> GetWeatherById(int id)
        {
            var weatherWithId = _weatherService.GetWeatherById(id);

            if(weatherWithId == null)
            {
                return NotFound();
            }

            return Ok(weatherWithId);
        }
    }
}
