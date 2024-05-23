using Microsoft.AspNetCore.Mvc;

namespace ForestTime.UserInterfaceLayer.Controllers.Defaults
{
    public class OutdoorLivingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
