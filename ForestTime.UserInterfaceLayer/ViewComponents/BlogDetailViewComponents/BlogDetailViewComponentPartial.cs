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

        public async Task<IViewComponentResult> InvokeAsync(int id) 
        {
            var values = await _blogService.GetBlogDetailById(id);
            return View(values); 
        }
    }
}
