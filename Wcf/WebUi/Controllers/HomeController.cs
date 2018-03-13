using System.Web.Mvc;
using WebUi.WidgetSvc;

namespace WebUi.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Order order)
        {
            using (var service = new OrderingServiceClient("BasicHttpBinding_IOrderingService"))
            {
                PlacedOrder result = service.PlaceOrder(order);
                return View("OrderPlaced", result);
            }
        }
    }
}