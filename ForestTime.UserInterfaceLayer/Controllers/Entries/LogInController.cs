using ForestTime.DataTransferObjectLayer.RegisterDtos;
using ForestTime.Entitylayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ForestTime.UserInterfaceLayer.Controllers.Entries
{
    public class LogInController : Controller
    {
        private readonly SignInManager<User> _signInManager;

        public LogInController(SignInManager<User> signInManager)
        {
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(CreateLogInDto createLogInDto)
        {
            var result = await _signInManager.PasswordSignInAsync(createLogInDto.UserName, createLogInDto.Password, true, true);
            if (result.Succeeded)
            {
                return RedirectToAction("Default", "Home");
            }
            return View();
        }
    }
}
