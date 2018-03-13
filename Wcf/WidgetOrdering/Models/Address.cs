using System.Runtime.Serialization;

namespace WidgetOrdering.Models
{
    [DataContract]
    public class Address
    {
        [DataMember] public string Address1 { get; set; }
        [DataMember] public string Address2 { get; set; }
        [DataMember] public string City { get; set; }
        [DataMember] public string County { get; set; }
        [DataMember] public string PostCode { get; set; }
    }
}