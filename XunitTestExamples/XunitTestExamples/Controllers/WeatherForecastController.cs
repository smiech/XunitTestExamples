using Microsoft.AspNetCore.Mvc;
using XunitTestExamples.Models;
using XunitTestExamples.Services;

namespace XunitTestExamples.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly WeatherService _weatherService;

        public WeatherForecastController(WeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> GetWeatherForecast()
        {
            return _weatherService.GetForecast();
        }
    }
}