using Checkout;
using FakeItEasy;
using Xunit;

namespace Tests
{
    public class SaleTests
    {
        [Fact]
        public void TotalsPriceForItems()
        {
            var prices = A.Fake<IPrices>();
            var a = new Sku("A");
            var b = new Sku("B");
            A.CallTo(() => prices.PriceFor(a)).Returns(new Money(0.5m));
            A.CallTo(() => prices.PriceFor(b)).Returns(new Money(0.45m));

            IAccount account = FakeAccount.WithInitialBalance(new Money(0m));
            var sale = new Sale(prices, account);

            sale.AddItem(a);
            sale.AddItem(b);

            Assert.Equal(new Money(0.95m), account.Balance());
        }
    }
}
