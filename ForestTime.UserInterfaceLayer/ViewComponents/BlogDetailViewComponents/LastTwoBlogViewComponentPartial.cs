using ForestTime.BusinessLayer.Abstract.IAbstracService;
using Microsoft.AspNetCore.Mvc;

namespace ForestTime.UserInterfaceLayer.ViewComponents.BlogDetailViewComponents
{
    public class LastTwoBlogViewComponentPartial : ViewComponent
    {
        private readonly IBlogService _blogService;

        public LastTwoBlogViewComponentPartial(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var values = await _blogService.GetLastTwoBlogByUserIdAsync(id);
            return View(values); 
        }
    }
}
