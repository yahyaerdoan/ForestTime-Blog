using Microsoft.AspNetCore.Mvc;

namespace ForestTime.UserInterfaceLayer.ViewComponents.BlogDetailViewComponents
{
    public class BlogDetailViewComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
