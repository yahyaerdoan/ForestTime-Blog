using ForestTime.BusinessLayer.Abstract.IGenericService;
using ForestTime.Entitylayer.Concrete;

namespace ForestTime.BusinessLayer.Abstract.IAbstracService
{
    public interface IBlogService : IGenericService<Blog>
    {
        Task<List<Blog>> GetBlogsWithCategoryAndUserAsync();
    } 
}
