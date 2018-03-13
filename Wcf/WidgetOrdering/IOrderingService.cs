using System.ServiceModel;
using WidgetOrdering.Models;

namespace WidgetOrdering
{
    [ServiceContract]
    public interface IOrderingService
    {
        [OperationContract]
        PlacedOrder PlaceOrder(Order order);
    }
}
