using Microsoft.AspNetCore.Mvc;

namespace ForestTime.UserInterfaceLayer.ViewComponents.PageTitleViewComponents
{
    public class PageTitleViewComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke(string title) {  return View("Default", title); }
    }
}
