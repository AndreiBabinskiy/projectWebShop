using Microsoft.AspNetCore.Mvc;

namespace web1_1.Controllers
{
    public class PaymentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
