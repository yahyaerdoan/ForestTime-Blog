using ForestTime.DataAccessLayer.Abstract.IAbstactDal;
using ForestTime.DataAccessLayer.Concrete.Context;
using ForestTime.DataAccessLayer.Concrete.EfGenericRepository;
using ForestTime.Entitylayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ForestTime.DataAccessLayer.Concrete.EntityFramework
{
    public class EfCategoryDal : EfGenericRepository<Category, ForestTimeDbContext>, ICategoryDal
    {
        private readonly ForestTimeDbContext _forestTimeDbContext;

        public EfCategoryDal(IdentityDbContext<User, Role, int> context, ForestTimeDbContext forestTimeDbContext) : base(context)
        {
            _forestTimeDbContext = forestTimeDbContext;
        }

        public async Task<List<(string CategoryName, int BlogCount)>> GetCategoriesWithBlogCountsAsync()
        {
            var categoriesCount = await _forestTimeDbContext.Categories
                .AsNoTracking()
                .Select(c => new { CategoryName = c.Name, BlogCount = c.Blogs.Count})
                .ToListAsync();

            return categoriesCount
                .Select(c=> (c.CategoryName, categoriesCount.Count))
                .ToList();              
        }
    }
}
