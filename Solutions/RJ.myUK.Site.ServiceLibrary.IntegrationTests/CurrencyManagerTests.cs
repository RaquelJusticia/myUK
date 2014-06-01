using NUnit.Framework;

namespace RJ.myUK.Site.ServiceLibrary.IntegrationTests
{
    public class CurrencyManagerTests
    {
        [Test]
        public void ShouldReturnExchange()
        {
            //Arrange
            var currencyManager = new CurrencyManager();

            //Act
            var rate = currencyManager.GetExchangeRate();

            //Assert
            Assert.That(rate, Is.Not.EqualTo(0));
        }
    }
}
