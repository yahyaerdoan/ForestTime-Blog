using Microsoft.AspNetCore.Mvc;

namespace ForestTime.UserInterfaceLayer.ViewComponents.LayoutViewComponents
{
    public class LayoutScriptViewComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
