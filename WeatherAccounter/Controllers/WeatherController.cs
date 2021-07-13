using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherAccounter.BL.Contracts;
using WeatherAccounter.Models.Entites;
using WeatherAccounter.Models.ViewModels;

namespace WeatherAccounter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        private readonly IWeatherService _weatherService;

        private readonly IValidator<WeatherViewModel> _validator;

        public WeatherController(IWeatherService weatherService,
                                 IValidator<WeatherViewModel> validator)
        {
            _weatherService = weatherService;
            _validator = validator;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Weather> GetWeather()
        {
            var weather = _weatherService.GetWeather();

            if (weather == null)
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

            if (weatherWithId == null)
            {
                return NotFound();
            }

            return Ok(weatherWithId);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Weather> AddWeather([FromBody] WeatherViewModel weather)
        {
            var result = _validator.Validate(weather);

            if (!result.IsValid)
            {
                return BadRequest(result);
            }

            _weatherService.AddWeather(weather);

            return NoContent();
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult UpdateWeather([FromRoute] int id, [FromBody] WeatherViewModel weather)
        {

            var result = _validator.Validate(weather);

            if (!result.IsValid)
            {
                return BadRequest();
            }

            var updatedWeather = _weatherService.UpdateWeather(id, weather);

            if (updatedWeather == null)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult DeleteWeather(int id)
        {
            var deletedWeather = _weatherService.DeleteWeather(id);

            if (deletedWeather == null)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
