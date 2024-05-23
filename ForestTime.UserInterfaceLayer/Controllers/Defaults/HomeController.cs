using ForestTime.UserInterfaceLayer.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ForestTime.UserInterfaceLayer.Controllers.Defaults
{
    public class HomeController : Controller
    {
        public IActionResult Default()
        {
            return View();
        }
    }
}