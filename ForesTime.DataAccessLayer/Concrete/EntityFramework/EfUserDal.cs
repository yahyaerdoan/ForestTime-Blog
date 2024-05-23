using ForestTime.DataAccessLayer.Abstract.IAbstactDal;
using ForestTime.DataAccessLayer.Concrete.Context;
using ForestTime.DataAccessLayer.Concrete.EfGenericRepository;
using ForestTime.Entitylayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace ForestTime.DataAccessLayer.Concrete.EntityFramework
{
    public class EfUserDal : EfGenericRepository<User, ForestTimeDbContext>, IUserDal
    {
        public EfUserDal(IdentityDbContext<User, Role, int> context) : base(context)
        {
        }
    }
}
