using Microsoft.AspNetCore.Mvc;

namespace ForestTime.UserInterfaceLayer.Controllers.Defaults
{
    public class IndoorLivingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
