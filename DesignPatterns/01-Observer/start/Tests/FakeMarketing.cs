using System.Collections.Generic;
using Checkout;

namespace Tests
{
    public class FakeMarketing : IMarketing
    {
        private readonly List<Sku> _history;

        public FakeMarketing()
        {
            _history = new List<Sku>();
        }

        public void Sold(Sku s, Money m)
        {
            _history.Add(s);
        }

        public List<Sku> History()
        {
            return _history;
        }
    }
}
