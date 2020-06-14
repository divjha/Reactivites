using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Persistences;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {


        private readonly DataContext _context;

        public WeatherForecastController(DataContext context)
        {
           _context = context;


        }

        [HttpGet]
        public async Task< ActionResult<IEnumerable<WeatherForecast>>> Get()
        {
            var weather = await _context.WeatherForecasts.ToListAsync();
            return Ok(weather);
        }

         [HttpGet("{id}")]
         
        public async Task< ActionResult<IEnumerable<WeatherForecast>>> Get(int id)
        {
            var weather = await _context.WeatherForecasts.FindAsync(id);
            return Ok(weather);
        }
    }
}