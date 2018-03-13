using System;
using System.Linq;
using WidgetOrdering.Models;

namespace WidgetOrdering
{
    public class OrderingService : IOrderingService
    {
        public PlacedOrder PlaceOrder(Order order)
        {
            var rnd = new Random();

            var pricedOrderLines =
                order.OrderLines
                    .Select(x => new PricedOrderLine
                    {
                        ProductCode = x.ProductCode,
                        Quantity = x.Quantity,
                        Cost = 0.5m * x.Quantity
                    })
                    .ToList();

            var subtotal = pricedOrderLines.Sum(x => x.Cost);
            var shipping = 2.5m;

            return new PlacedOrder
            {
                OrderId = rnd.Next(1, 10000),
                CustomerName = order.CustomerName,
                BillingAddress = order.BillingAddress,
                ShippingAddress = order.ShippingAddress,
                OrderLines = pricedOrderLines,
                Subtotal = subtotal,
                Shipping = shipping,
                Total = subtotal + shipping
            };
        }
    }
}