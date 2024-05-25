using ForestTime.DataAccessLayer.Abstract.IAbstactDal;
using ForestTime.DataAccessLayer.Concrete.Context;
using ForestTime.DataAccessLayer.Concrete.EfGenericRepository;
using ForestTime.Entitylayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ForestTime.DataAccessLayer.Concrete.EntityFramework
{
    public class EfBlogDal : EfGenericRepository<Blog, ForestTimeDbContext>, IBlogDal
    {
        private readonly ForestTimeDbContext _forestTimeDbContext;
        public EfBlogDal(IdentityDbContext<User, Role, int> context, ForestTimeDbContext forestTimeDbContext) : base(context)
        {
            _forestTimeDbContext = forestTimeDbContext;
        }

        public async Task<List<Blog>> GetBlogsWithCategoryAndUserAsync()
        {
            var values = await _forestTimeDbContext.Blogs.AsNoTracking().Include(x => x.Category).Include(y => y.User).ToListAsync();
            return (values);
        }
    }
}
