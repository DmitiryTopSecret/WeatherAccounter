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
    public class CityController : ControllerBase
    {
        private readonly ICitiesService _citiesService;

        private readonly IValidator<CityViewModel> _validator;

        public CityController(ICitiesService citiesService,
                              IValidator<CityViewModel> validator)
        {
            _citiesService = citiesService;
            _validator = validator;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<City> GetCities()
        {
            var cities = _citiesService.GetCities();

            if (cities == null)
            {
                return NotFound();
            }

            return Ok(cities.ToList());
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<City> GetCityById(int id)
        {
            var city = _citiesService.GetCityById(id);

            if (city == null)
            {
                return NotFound();
            }

            return Ok(city);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<City> AddCity([FromBody] CityViewModel city)
        {
            var result = _validator.Validate(city);

            if (!result.IsValid)
            {
                return BadRequest(result);
            }

            _citiesService.AddCity(city);

            return NoContent();
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult UpdateCity([FromRoute] int id, [FromBody] CityViewModel city)
        {

            var result = _validator.Validate(city);

            if (!result.IsValid)
            {
                return BadRequest();
            }

            var updatedCity = _citiesService.UpdateCity(id, city);

            if (updatedCity == null)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult DeleteCity(int id)
        {
            var deletedCity = _citiesService.DeleteCity(id);

            if (deletedCity == null)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
