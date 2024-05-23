using Microsoft.AspNetCore.Mvc;

namespace ForestTime.UserInterfaceLayer.Controllers.Defaults
{
    public class ShoppingGuidesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
