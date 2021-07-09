using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherAccounter.DAL
{
    public class WeatherAccounterContext : DbContext
    {
        public WeatherAccounterContext(DbContextOptions<WeatherAccounterContext> options)
            :base(options)
        {
        }


    }
}
