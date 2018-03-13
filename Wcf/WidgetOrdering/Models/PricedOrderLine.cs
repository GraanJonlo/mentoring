using System.Runtime.Serialization;

namespace WidgetOrdering.Models
{
    [DataContract]
    public class PricedOrderLine
    {
        [DataMember] public string ProductCode { get; set; }
        [DataMember] public int Quantity { get; set; }
        [DataMember] public decimal Cost { get; set; }
    }
}