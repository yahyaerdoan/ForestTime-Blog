using ForestTime.BusinessLayer.Abstract.IGenericService;
using ForestTime.Entitylayer.Concrete;

namespace ForestTime.BusinessLayer.Abstract.IAbstracService
{
    public interface IBlogService : IGenericService<Blog>
    {
        Task<Blog?> GetBlogDetailById(int id);
        Task<List<Blog>> GetBlogsWithCategoryAndUserAsync();
        Task<List<Blog>> GetLastTwoBlogByUserIdAsync(int id);
    } 
}
