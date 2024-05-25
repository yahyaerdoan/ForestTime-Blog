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

        public async Task<IViewComponentResult> InvokeAsync() 
        {
            var values = await _blogService.GetBlogsWithCategoryAndUserAsync();
            return View(values); 
        }
    }
}
