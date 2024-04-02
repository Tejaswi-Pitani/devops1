using Humanizer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Moq;
using sample2.Controllers;
using sample2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace TestProject
{
    [TestClass]
    public class HomeControllerTests
    {
        private List<User> _users;

        [TestInitialize]
        public void Initialize()
        {
            _users = new List<User>();
        }

        //[TestMethod]
        //public void Index_Returns_View_With_Users()
        //{
        //    // Arrange
        //    var loggerMock = new Mock<ILogger<HomeController>>();
        //    var controller = new HomeController(loggerMock.Object);
        //    var users = new List<User> { new User { Id = 1, Name = "Test User" } };
        //    _users.AddRange(users);

        //    // Act
        //    var result = controller.Index() as ViewResult;

        //    // Assert
        //    Assert.IsNotNull(result);
        //    CollectionAssert.AreEqual(users.Select(u => u.Id).ToList(), ((IEnumerable<User>)result.Model).Select(u => u.Id).ToList());
        //}

        //[TestMethod]
        //public void Details_Returns_View_With_User()
        //{
        //    // Arrange
        //    var loggerMock = new Mock<ILogger<HomeController>>();
        //    var controller = new HomeController(loggerMock.Object);
        //    var user = new User { Id = 1, Name = "Test User" };
        //    _users.Add(user);

        //    // Act
        //    var result = controller.Details(user.Id) as ViewResult;

        //    // Assert
        //    Assert.IsNotNull(result);
        //    Assert.AreEqual(user.Id, ((User)result.Model).Id);
        //    Assert.AreEqual(user.Name, ((User)result.Model).Name);
        //}

        [TestMethod]
        public void Details_Returns_NotFound_When_User_Not_Found()
        {
            // Arrange
            var loggerMock = new Mock<ILogger<HomeController>>();
            var controller = new HomeController(loggerMock.Object);

            // Act
            var result = controller.Details(1) as NotFoundResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}


           
           
        

