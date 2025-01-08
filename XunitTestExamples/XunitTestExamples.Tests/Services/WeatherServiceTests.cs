using System;
using System.Collections.Generic;
using Xunit;
using XunitTestExamples.Services;
using XunitTestExamples.Models;

namespace XunitTestExamples.Tests.Services
{
    public class WeatherServiceTests
    {
        private readonly WeatherService _weatherService;

        public WeatherServiceTests()
        {
            _weatherService = new WeatherService();
        }

        [Fact]
        public void GetForecast_ReturnsListOfWeatherForecast()
        {
            // Act
            var result = _weatherService.GetForecast();

            // Assert
            Assert.IsType<List<WeatherForecast>>(result);
            Assert.NotEmpty(result);
        }

        [Fact]
        public void GetForecast_ContainsValidWeatherData()
        {
            // Act
            var result = _weatherService.GetForecast();

            // Assert
            foreach (var forecast in result)
            {
                Assert.NotEqual(default, forecast.Date);
                Assert.InRange(forecast.TemperatureC, -30, 50);
                Assert.False(string.IsNullOrWhiteSpace(forecast.Summary));
            }
        }
    }
}