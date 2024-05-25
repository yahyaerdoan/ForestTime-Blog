using ForestTime.BusinessLayer.Abstract.IAbstracService;
using Microsoft.AspNetCore.Mvc;

namespace ForestTime.UserInterfaceLayer.ViewComponents.BlogDetailViewComponents
{
    public class AboutAuthorViewComponentPartial : ViewComponent
    {
        private readonly IUserService _userService;

        public AboutAuthorViewComponentPartial(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var values = await _userService.GetAuthorInfoByBlogIdAsync(id);
            return View(values);
        }
    }
}
