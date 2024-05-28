using ForestTime.DataAccessLayer.Abstract.IGenericRapository;
using ForestTime.Entitylayer.Concrete;

namespace ForestTime.DataAccessLayer.Abstract.IAbstactDal
{
    public interface IBlogDal : IGenericRepository<Blog>
    {
        Task<Blog?> GetBlogDetailById(int id);
        Task<List<Blog>> GetBlogsWithCategoryAndUserAsync();
        Task<List<Blog>> GetLastTwoBlogByUserIdAsync(int id);
        Task<List<Blog>> GetBlogsByUserIdAsync(int id);
    }
}
