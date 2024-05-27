using ForestTime.DataAccessLayer.Abstract.IGenericRapository;
using ForestTime.DataTransferObjectLayer.CategoryDtos;
using ForestTime.Entitylayer.Concrete;

namespace ForestTime.DataAccessLayer.Abstract.IAbstactDal
{
    public interface ICategoryDal : IGenericRepository<Category>
    {
        Task<List<CategoryBlogCountDto>> GetCategoriesWithBlogCountsAsync();
    }   
}
