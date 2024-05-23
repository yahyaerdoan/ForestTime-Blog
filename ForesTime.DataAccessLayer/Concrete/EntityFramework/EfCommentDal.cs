using ForestTime.DataAccessLayer.Abstract.IAbstactDal;
using ForestTime.DataAccessLayer.Concrete.Context;
using ForestTime.DataAccessLayer.Concrete.EfGenericRepository;
using ForestTime.Entitylayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestTime.DataAccessLayer.Concrete.EntityFramework
{
    public class EfCommentDal : EfGenericRepository<Comment, ForestTimeDbContext>, ICommentDal
    {
        public EfCommentDal(IdentityDbContext<User, Role, int> context) : base(context)
        {
        }
    }
}
