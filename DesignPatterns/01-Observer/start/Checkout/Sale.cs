namespace Checkout
{
    public class Sale
    {
        private readonly IPrices _prices;
        private readonly Account _creditAccount;

        public Sale(IPrices prices, Account creditAccount)
        {
            _prices = prices;
            _creditAccount = creditAccount;
        }

        public void Add(Sku s)
        {
            var p = _prices.PriceFor(s);
            _creditAccount.Add(new Transaction(s.ToString(), p));
        }
    }
}
