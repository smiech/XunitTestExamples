using XunitTestExamples.Models;
using XunitTestExamples.Services;

namespace XunitTestExamples
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var userService = new UserService(new List<User>());
            var weatherService = new WeatherService();

            // Example usage of UserService
            var user = userService.GetUserById(1);
            Console.WriteLine(user);

            // Example usage of WeatherService
            var forecasts = weatherService.GetForecast();
            foreach (var forecast in forecasts)
            {
                Console.WriteLine($"{forecast.Date.ToShortDateString()}: {forecast.Summary} ({forecast.TemperatureC}C/{forecast.TemperatureF}F)");
            }
        }
    }
}