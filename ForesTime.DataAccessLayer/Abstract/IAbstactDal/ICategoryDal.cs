using ForestTime.DataAccessLayer.Abstract.IGenericRapository;
using ForestTime.Entitylayer.Concrete;

namespace ForestTime.DataAccessLayer.Abstract.IAbstactDal
{
    public interface ICategoryDal : IGenericRepository<Category>
    {
        Task<List<(string CategoryName, int BlogCount)>> GetCategoriesWithBlogCountsAsync();
    }   
}
