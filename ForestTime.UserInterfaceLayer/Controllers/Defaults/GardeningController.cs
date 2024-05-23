using Microsoft.AspNetCore.Mvc;

namespace ForestTime.UserInterfaceLayer.Controllers.Defaults
{
    public class GardeningController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
