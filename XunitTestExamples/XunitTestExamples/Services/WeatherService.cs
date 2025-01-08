using XunitTestExamples.Models;

namespace XunitTestExamples.Services;

public class WeatherService
{
    private readonly List<WeatherForecast> _forecasts;

    public WeatherService()
    {
        _forecasts = new List<WeatherForecast>
        {
            new WeatherForecast { Date = DateTime.Now.AddDays(1), TemperatureC = 20, Summary = "Sunny" },
            new WeatherForecast { Date = DateTime.Now.AddDays(2), TemperatureC = 18, Summary = "Cloudy" },
            new WeatherForecast { Date = DateTime.Now.AddDays(3), TemperatureC = 15, Summary = "Rainy" }
        };
    }

    public List<WeatherForecast> GetForecast()
    {
        return _forecasts;
    }
}