using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShohagOnlinePortal.Controllers;
using System.Web.Mvc;

namespace ShohagOnlinePortal.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }


    }
}
