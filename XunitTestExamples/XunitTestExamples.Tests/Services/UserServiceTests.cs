using System;
using System.Collections.Generic;
using System.Linq;
using NUnit;
using NUnit.Framework;
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
            _userService = new UserService(_users, DateTime.Now);
        }

        [Test]
        public void GetUserById_ExistingId_ReturnsUser()
        {
            var user = _userService.GetUserById(1);
            Assert.That(user, Is.Not.Null);
            Assert.That("Alice", Is.EqualTo(user.Name));
        }

        [Test]
        public void GetUserById_NonExistingId_ReturnsNull()
        {
            var user = _userService.GetUserById(3);
            Assert.That(user, Is.Not.Null);
        }
    }
}