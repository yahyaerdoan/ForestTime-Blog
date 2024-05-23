using ForestTime.BusinessLayer.Abstract.IAbstracService;
using Microsoft.AspNetCore.Mvc;

namespace ForestTime.UserInterfaceLayer.ViewComponents.LayoutViewComponents
{
    public class LayoutFirstTreeSectionViewComponentPartial : ViewComponent
    {
        private readonly IBlogService _blogService;

        public LayoutFirstTreeSectionViewComponentPartial(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public IViewComponentResult Invoke() 
        {
           var values = _blogService.GetAll();
            return View(values);
        }
    }
}
