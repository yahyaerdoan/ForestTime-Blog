using AutoMapper;
using ForestTime.BusinessLayer.Abstract.IAbstracService;
using ForestTime.DataTransferObjectLayer.BlogDtos;
using ForestTime.Entitylayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ForestTime.UserInterfaceLayer.Areas.User.Controllers
{
    [Authorize]
    [Area("User")]
    [Route("User/{controller}/{action}/{id?}")]
    public class BlogController : Controller
    {
		private readonly IMapper _mapper;
		private readonly IBlogService _blogService;
        private readonly UserManager<Entitylayer.Concrete.User> _userManager;


		public BlogController(IBlogService blogService, UserManager<Entitylayer.Concrete.User> userManager, IMapper mapper)
		{
			_blogService = blogService;
			_userManager = userManager;
			_mapper = mapper;
		}

		public async Task<IActionResult> Index()
        {
            var userId = await _userManager.FindByNameAsync(User.Identity.Name);
            var values = await _blogService.GetBlogsByUserIdAsync(userId.Id);
            return View(values);
        }

        [HttpGet]
		public async Task<IActionResult> CreateBlog()
		{			
			return View();
		}
        [HttpPost]
		public async Task<IActionResult> CreateBlog(CreateBlogDto createBlogDto)
		{
			var userId = await _userManager.FindByNameAsync(User.Identity.Name);
            createBlogDto.UserId = userId.Id;
            createBlogDto.CreatedDate = DateTime.Now;
            createBlogDto.UpdatedDate = DateTime.Now;
			createBlogDto.ViewingCount = 1;
			createBlogDto.Status = true;
			createBlogDto.CategoryId = 2;
            var values = _mapper.Map<Blog>(createBlogDto);
			_blogService.Add(values);
			return RedirectToAction("Index", "Blog");
		}
	}
}
