using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WidgetOrdering.Models
{
    [DataContract]
    public class Order
    {
        [DataMember] public string CustomerName { get; set; }
        [DataMember] public Address BillingAddress { get; set; }
        [DataMember] public Address ShippingAddress { get; set; }
        [DataMember] public List<OrderLine> OrderLines { get; set; }
    }
}