using ForestTime.BusinessLayer.Abstract.IAbstracService;
using ForestTime.Entitylayer.Concrete;
using System.Linq.Expressions;

namespace ForestTime.BusinessLayer.Concrete.ConcreteManager
{
    public class RoleManager : IRoleService
    {
        public void Add(Role entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Role entity)
        {
            throw new NotImplementedException();
        }

        public Role Get(Expression<Func<Role, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Role> GetAll(Expression<Func<Role, bool>>? filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Role entity)
        {
            throw new NotImplementedException();
        }
    }
}
