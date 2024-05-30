using ForestTime.BusinessLayer.Abstract.IAbstracService;
using Microsoft.AspNetCore.Mvc;

namespace ForestTime.UserInterfaceLayer.Controllers.BlogDetails
{
    public class BlogDetailController : Controller
    {
        private readonly IBlogService _blogService;

        public BlogDetailController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public IActionResult Index(int id)
        {
            var values = _blogService.Get(x=> x.BlogId == id);
            _blogService.IncreaseBlogViewingCount(id);
            ViewBag.BlogViewingCount = id;
            return View(values);
        }
    }
}
