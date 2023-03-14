using Microsoft.AspNetCore.Mvc;

namespace web1_1.Controllers
{
    public class MoviesController : Controller
    {
        

        [HttpPost]
        public string Index(string searchString, bool notUsed)
        {
            return "From [HttpPost]Index: filter on " + searchString;
        }
    }
}
