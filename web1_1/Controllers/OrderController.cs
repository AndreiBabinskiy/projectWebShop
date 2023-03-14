using Microsoft.AspNetCore.Mvc;

namespace web1_1.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
