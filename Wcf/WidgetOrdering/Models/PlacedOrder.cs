using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WidgetOrdering.Models
{
    [DataContract]
    public class PlacedOrder
    {
        [DataMember] public int OrderId { get; set; }
        [DataMember] public string CustomerName { get; set; }
        [DataMember] public Address BillingAddress { get; set; }
        [DataMember] public Address ShippingAddress { get; set; }
        [DataMember] public List<PricedOrderLine> OrderLines { get; set; }
        [DataMember] public decimal Subtotal { get; set; }
        [DataMember] public decimal Shipping { get; set; }
        [DataMember] public decimal Total { get; set; }
    }
}