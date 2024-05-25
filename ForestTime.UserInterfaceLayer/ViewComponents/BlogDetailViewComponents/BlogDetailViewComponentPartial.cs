using ForestTime.BusinessLayer.Abstract.IAbstracService;
using Microsoft.AspNetCore.Mvc;

namespace ForestTime.UserInterfaceLayer.ViewComponents.BlogDetailViewComponents
{
    public class BlogDetailViewComponentPartial : ViewComponent
    {
        private readonly IBlogService _blogService;

        public BlogDetailViewComponentPartial(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public IViewComponentResult Invoke(int id) 
        {
            var values = _blogService.Get(x=> x.BlogId == id);
            return View(values); 
        }
    }
}
