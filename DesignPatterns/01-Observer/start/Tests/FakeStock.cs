﻿using System;
using System.Collections.Generic;
using Checkout;

namespace Tests
{
    public class FakeStock : IStock
    {
        private readonly Dictionary<Sku, int> _stockLevels;

        private FakeStock(Dictionary<Sku, int> stockLevels)
        {
            _stockLevels = stockLevels;
        }

        public static FakeStock WithStockLevels(Dictionary<Sku, int> stockLevels)
        {
            return new FakeStock(stockLevels);
        }

        public void Sold(Sku s)
        {
            _stockLevels[s] = _stockLevels[s] - 1;
        }

        public int RemainingFor(Sku s)
        {
            return _stockLevels[s];
        }
    }
}
