using ForestTime.DataAccessLayer.Abstract.IAbstactDal;
using ForestTime.DataAccessLayer.Concrete.Context;
using ForestTime.DataAccessLayer.Concrete.EfGenericRepository;
using ForestTime.Entitylayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace ForestTime.DataAccessLayer.Concrete.EntityFramework
{
    public class EfCategoryDal : EfGenericRepository<Category, ForestTimeDbContext>, ICategoryDal
    {
        public EfCategoryDal(IdentityDbContext<User, Role, int> context) : base(context)
        {
        }
    }
}
