﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherAccounter.Models.Entites;

namespace WeatherAccounter.DAL.Contracts
{
    public interface ICitiesRepositroy
    {
        IEnumerable<City> GetCities();
        City GetCityById(int id);
    }
}