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
    public class CityController : ControllerBase
    {
        private readonly ICitiesService _citiesService;

        public CityController(ICitiesService citiesService)
        {
            _citiesService = citiesService;
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

            if(city == null)
            {
                return NotFound();
            }

            return Ok(city);
        }
    }
}
