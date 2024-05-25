using ForestTime.DataAccessLayer.Abstract.IAbstactDal;
using ForestTime.DataAccessLayer.Concrete.Context;
using ForestTime.DataAccessLayer.Concrete.EfGenericRepository;
using ForestTime.Entitylayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ForestTime.DataAccessLayer.Concrete.EntityFramework
{
    public class EfUserDal : EfGenericRepository<User, ForestTimeDbContext>, IUserDal
    {
        private readonly ForestTimeDbContext _forestTimeDbContext;

        public EfUserDal(IdentityDbContext<User, Role, int> context, ForestTimeDbContext forestTimeDbContext) : base(context)
        {
            _forestTimeDbContext = forestTimeDbContext;
        }

        public async Task<User?> GetAuthorInfoByBlogIdAsync(int id)
        {
            var values = await _forestTimeDbContext.Blogs.AsNoTracking().Where(x=> x.BlogId == id).Select(y=> y.User).FirstOrDefaultAsync();
            return values;
        }
    }
}
