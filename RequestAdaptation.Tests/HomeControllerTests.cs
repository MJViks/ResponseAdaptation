using System;
using Xunit;

namespace RequestAdaptation.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void Post_Home()
        {
            Home home = new Home {Email = "Test@email.ru", Name = "", Text = "Test", Software = "Photoshop"};
            const string expected = "Одно или несколько полей не заполнены!";
            HomeController homeController = new HomeController();
            string actual = homeController.Post(home);
            Assert.Equal(expected, actual);
        }
    }
}
