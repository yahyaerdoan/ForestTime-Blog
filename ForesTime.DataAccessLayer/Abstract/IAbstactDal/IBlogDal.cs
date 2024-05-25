using ForestTime.DataAccessLayer.Abstract.IGenericRapository;
using ForestTime.Entitylayer.Concrete;

namespace ForestTime.DataAccessLayer.Abstract.IAbstactDal
{
    public interface IBlogDal : IGenericRepository<Blog>
    {
        Task<List<Blog>> GetBlogsWithCategoryAndUserAsync();
    }
}
