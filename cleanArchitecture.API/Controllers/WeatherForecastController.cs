using cleanArchitecture.API.Contracts;
using cleanArchitecture.Core.Entities;
using cleanArchitecture.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace cleanArchitecture.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };
        private readonly ICarServices _carServices;


        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger,ICarServices carServices)
        {
            _logger = logger;
            _carServices = carServices;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpPost("/testing")]
        public async Task<ActionResult<Car>> CreateNew(CarsOpreationContract Model)
        {
            var newCar = new Car()
            {
                  Name = Model.name
            };
           return await _carServices.create(newCar);

        }
    }
}

