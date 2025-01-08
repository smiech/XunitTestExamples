using XunitTestExamples.Models;

namespace XunitTestExamples.Services;

public class WeatherUserService
{
    private readonly UserService _userService;
    private readonly WeatherService _weatherService;

    public WeatherUserService(UserService userService, WeatherService weatherService)
    {
        _userService = userService;
        _weatherService = weatherService;
    }

    public (User user, List<WeatherForecast> forecasts) GetUserWithWeather(int userId)
    {
        var user = _userService.GetUserById(userId);
        if (user == null)
        {
            return (null, null);
        }

        var forecasts = _weatherService.GetForecast();
        return (user, forecasts);
    }
}