using System.Collections.Generic;
using System.Linq;
using Checkout;

namespace Tests
{
    public class FakeAccount : IAccount
    {
        private readonly List<Transaction> _transactions;

        private FakeAccount(Money initialBalance)
        {
            _transactions = new List<Transaction> {new Transaction("Initial balance", initialBalance)};
        }

        public static FakeAccount WithInitialBalance(Money initialBalance)
        {
            return new FakeAccount(initialBalance);
        }

        public void Sold(Sku s, Money m)
        {
            _transactions.Add(new Transaction(s.ToString(), m));
        }

        public Money Balance()
        {
            return _transactions.Select(t => t.Value).Aggregate(new Money(0m), (l, r) => l + r);
        }
    }
}
