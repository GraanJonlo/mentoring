using System.Runtime.Serialization;

namespace WidgetOrdering.Models
{
    [DataContract]
    public class OrderLine
    {
        [DataMember] public string ProductCode { get; set; }
        [DataMember] public int Quantity { get; set; }
    }
}