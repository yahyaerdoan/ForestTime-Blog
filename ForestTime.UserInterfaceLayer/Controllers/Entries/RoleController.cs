using AutoMapper;
using ForestTime.BusinessLayer.Abstract.IAbstracService;
using ForestTime.DataTransferObjectLayer.BlogDtos;
using ForestTime.DataTransferObjectLayer.RoleDtos;
using ForestTime.Entitylayer.Concrete;
using ForestTime.UserInterfaceLayer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ForestTime.UserInterfaceLayer.Controllers.Entries
{
    public class RoleController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<Role> _roleManager;
        private readonly IMapper _mapper;

        public RoleController(UserManager<User> userManager, RoleManager<Role> roleManager, IMapper mapper)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var values = _roleManager.Roles.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateRole()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateRole(CreateRoleDto createRoleDto)
        {
            var values = _mapper.Map<Role>(createRoleDto);
            var result = await _roleManager.CreateAsync(values);
            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        public async Task<IActionResult> DeleteRole(int id)
        {
            var values = _roleManager.Roles.FirstOrDefault(x => x.Id == id);
            await _roleManager.DeleteAsync(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateRole(int id)
        {
            var values = _roleManager.Roles.FirstOrDefault(x => x.Id == id);
            var mappedValue = _mapper.Map<UpdateRoleDto>(values);
            return View(mappedValue);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateRole(UpdateRoleDto updateRoleDto)
        {
            var values = _roleManager.Roles.FirstOrDefault(x => x.Id == updateRoleDto.Id);
            var mappedValue = _mapper.Map(updateRoleDto, values);
            var result = await _roleManager.UpdateAsync(mappedValue);
            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult UserList()
        {
            var values = _userManager.Users.ToList();
            return View(values);
        }

        public async Task<IActionResult> AssingRole(int id)
        {
            var userId = _userManager.Users.FirstOrDefault(x=> x.Id == id);
            TempData["x"] = userId.Id;
            var roles = _roleManager.Roles.ToList();
            var useRoles = await _userManager.GetRolesAsync(userId);
            List<RoleAssingViewModel> roleAssingViewModel = new();
            foreach (var role in roles)
            {
                RoleAssingViewModel model = new RoleAssingViewModel();
                model.RoleId = role.Id;
                model.RoleName = role.Name;
                model.RoleExist = useRoles.Contains(role.Name);
                roleAssingViewModel.Add(model);
            }
            return View(roleAssingViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> AssingRole(List<RoleAssingViewModel> model)
        {
            var userId = (int)TempData["x"];
            var user = _userManager.Users.FirstOrDefault(x => x.Id == userId);
            foreach (var item in model)
            {
                if (item.RoleExist)
                {
                    await _userManager.AddToRoleAsync(user, item.RoleName);
                }
                else
                {
                    await _userManager.RemoveFromRoleAsync(user, item.RoleName);
                }
            }
            return RedirectToAction("UserList");

        }
    }
}
