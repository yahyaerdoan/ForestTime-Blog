using ForestTime.BusinessLayer.Abstract.IAbstracService;
using ForestTime.DataAccessLayer.Abstract.IAbstactDal;
using ForestTime.DataTransferObjectLayer.CategoryDtos;
using ForestTime.Entitylayer.Concrete;
using System.Linq.Expressions;

namespace ForestTime.BusinessLayer.Concrete.ConcreteManager
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Add(Category entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Category entity)
        {
            throw new NotImplementedException();
        }

        public Category Get(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll(Expression<Func<Category, bool>>? filter = null)
        {
            throw new NotImplementedException();
        }

        public async Task<List<CategoryBlogCountDto>> GetCategoriesWithBlogCountsAsync()
        {
            var values = await _categoryDal.GetCategoriesWithBlogCountsAsync();
            return values;
        }

        public void Update(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
