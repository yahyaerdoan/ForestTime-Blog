using Microsoft.AspNetCore.Mvc;

namespace ForestTime.UserInterfaceLayer.ViewComponents.LayoutViewComponents
{
    public class LayoutFooterViewCopmponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke() {  return View(); }
    }
}
