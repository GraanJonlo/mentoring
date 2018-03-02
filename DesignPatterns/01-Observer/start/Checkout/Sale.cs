namespace Checkout
{
    public class Sale
    {
        private readonly IPrices _prices;
        private readonly IAccount _account;

        public Sale(IPrices prices, IAccount account)
        {
            _prices = prices;
            _account = account;
        }

        public void AddItem(Sku s)
        {
            Money p = _prices.PriceFor(s);
            _account.Sold(s, p);
        }
    }
}
