using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using XunitTestExamples.Services;
using XunitTestExamples.Models;

namespace XunitTestExamples.Tests.Services
{
    public class UserServiceTests
    {
        private readonly UserService _userService;
        private readonly List<User> _users;

        public UserServiceTests()
        {
            _users = new List<User>
            {
                new User { Id = 1, Name = "Alice", Email = "alice@example.com" },
                new User { Id = 2, Name = "Bob", Email = "bob@example.com" }
            };
            _userService = new UserService(_users);
        }

        [Fact]
        public void GetUserById_ExistingId_ReturnsUser()
        {
            var user = _userService.GetUserById(1);
            Assert.NotNull(user);
            Assert.Equal("Alice", user.Name);
        }

        [Fact]
        public void GetUserById_NonExistingId_ReturnsNull()
        {
            var user = _userService.GetUserById(3);
            Assert.Null(user);
        }
    }
}