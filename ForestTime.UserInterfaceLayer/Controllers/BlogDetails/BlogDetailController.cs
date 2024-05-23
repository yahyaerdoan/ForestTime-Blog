using Microsoft.AspNetCore.Mvc;

namespace ForestTime.UserInterfaceLayer.Controllers.BlogDetails
{
    public class BlogDetailController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
