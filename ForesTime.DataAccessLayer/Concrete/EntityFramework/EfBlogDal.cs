using ForestTime.DataAccessLayer.Abstract.IAbstactDal;
using ForestTime.DataAccessLayer.Concrete.Context;
using ForestTime.DataAccessLayer.Concrete.EfGenericRepository;
using ForestTime.Entitylayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

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

        public async Task<Blog?> GetBlogDetailById(int id)
        {
            var values = await _forestTimeDbContext.Blogs.AsNoTracking().Where(x=> x.BlogId == id).Include(x=> x.Category).Include(x=> x.User).  FirstOrDefaultAsync();
            return (values);
        }

        public async Task<List<Blog>> GetLastTwoBlogByUserIdAsync(int id)
        {
            int userId = await _forestTimeDbContext.Blogs.AsNoTracking().Where(x=> x.BlogId == id).Select(y=> y.UserId).FirstOrDefaultAsync();
            var values = await _forestTimeDbContext.Blogs.AsNoTracking().Where(x=>x.UserId == userId).OrderByDescending(y=>y.BlogId).Take(2).ToListAsync();

            #region You can simplify your method into a single LINQ query. one chained query, minimizing the number of database calls.

            var valuesChainedQuery = await _forestTimeDbContext.Blogs
                .AsNoTracking()
                .Where(x => x.BlogId == id)
                .SelectMany(blog => _forestTimeDbContext.Blogs
                    .AsNoTracking()
                    .Where(y=> y.UserId == blog.UserId)
                    .OrderByDescending(y=> y.BlogId)
                    .Take(2))
                    .ToListAsync();

            #endregion

            return (valuesChainedQuery);
        }
    }
}
