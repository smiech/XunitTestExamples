using System;
using System.Collections.Generic;
using NSubstitute;
using NUnit.Framework;
using XunitTestExamples.Models;
using XunitTestExamples.Services;

namespace XunitTestExamples.Tests.Services;

public class WeatherUserServiceTest
{
    private readonly WeatherUserService _weatherUserService;

    public WeatherUserServiceTest()
    {
        var weatherService = new WeatherService();
        var userService = Substitute.For<IUserService>();// new UserService(new List<User>(), DateTime.Today);
        userService.GetAllUsers().Returns(new List<User>());
        _weatherUserService = new WeatherUserService(userService, weatherService);
        var users = userService.GetAllUsers();
    }

    [Test]
    public void DoNothing()
    {
        
    }
}