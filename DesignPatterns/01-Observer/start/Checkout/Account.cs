using System.Collections.Generic;
using System.Linq;

namespace Checkout
{
    public class Account
    {
        private readonly List<Transaction> _transactions;

        private Account(Money initialBalance)
        {
            _transactions = new List<Transaction> {new Transaction("Initial balance", initialBalance)};
        }

        public void Add(Transaction t)
        {
            _transactions.Add(t);
        }

        public Money Balance()
        {
            return _transactions.Select(t => t.Value).Aggregate(new Money(0m), (l, r) => l + r);
        }

        public static Account WithInitialBalance(Money initialBalance)
        {
            return new Account(initialBalance);
        }
    }
}