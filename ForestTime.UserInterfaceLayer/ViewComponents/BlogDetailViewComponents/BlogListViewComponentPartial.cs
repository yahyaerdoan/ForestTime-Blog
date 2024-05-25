using ForestTime.BusinessLayer.Abstract.IAbstracService;
using Microsoft.AspNetCore.Mvc;

namespace ForestTime.UserInterfaceLayer.ViewComponents.BlogDetailViewComponents
{
    public class BlogListViewComponentPartial : ViewComponent
    {
        private readonly IBlogService _blogService;

        public BlogListViewComponentPartial(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public IViewComponentResult Invoke() 
        {
            var values = _blogService.GetBlogsWithCategoryAndUser();
            return View(values); 
        }
    }
}
