using ForestTime.BusinessLayer.Abstract.IAbstracService;
using Microsoft.AspNetCore.Mvc;

namespace ForestTime.UserInterfaceLayer.ViewComponents.RightSectionViewComponents
{
    public class PopularCategoriesViewComponentPartial : ViewComponent
    {
        private readonly ICategoryService _categoryService;

        public PopularCategoriesViewComponentPartial(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _categoryService.GetCategoriesWithBlogCountsAsync();
            return View(values);
        }
    }
}
