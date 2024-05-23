using ForestTime.BusinessLayer.Abstract.IAbstracService;
using ForestTime.DataTransferObjectlayer.RegisterDtos;
using ForestTime.Entitylayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ForestTime.UserInterfaceLayer.Controllers.Entries
{
    public class RegisterController : Controller
    {
        private readonly UserManager<User> _userManager;

        public RegisterController(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(CreateUserDto createUserDto)
        {
            User user = new User()
            {
                FirstName = createUserDto.FirstName,
                LastName = createUserDto.LastName,
                UserName = createUserDto.UserName,
                Email = createUserDto.Email,
            };

            var result = await _userManager.CreateAsync(user, createUserDto.Password);
                 if (result.Succeeded)
            {
                return RedirectToAction("Default", "Home");
            }
            return View();
        }
    }
}
