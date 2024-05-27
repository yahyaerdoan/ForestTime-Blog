using ForestTime.BusinessLayer.Abstract.IGenericService;
using ForestTime.DataTransferObjectLayer.CategoryDtos;
using ForestTime.Entitylayer.Concrete;

namespace ForestTime.BusinessLayer.Abstract.IAbstracService
{
    public interface ICategoryService : IGenericService<Category>
    {
        Task<List<CategoryBlogCountDto>> GetCategoriesWithBlogCountsAsync();
    } 
}
