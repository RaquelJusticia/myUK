using Moq;
using NUnit.Framework;
using RJ.myUK.Site.Controllers;
using RJ.myUK.Site.ServiceLibrary;

namespace RJ.myUK.Site.UnitTests
{
    public class HomeControllerTests
    {
        [Test]
        public void ShouldCallCurrencyManager()
        {
            //Arrange
            var currencyManager = new Mock<ICurrencyManager>();
            var homeController = new HomeController(currencyManager.Object);

            //Act
            homeController.Index();

            //Assert
            currencyManager.Verify(c => c.GetExchangeRate(), Times.Once);
        }
    }
}
