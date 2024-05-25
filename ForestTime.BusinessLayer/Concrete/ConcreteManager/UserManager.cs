using ForestTime.BusinessLayer.Abstract.IAbstracService;
using ForestTime.DataAccessLayer.Abstract.IAbstactDal;
using ForestTime.Entitylayer.Concrete;
using System.Linq.Expressions;

namespace ForestTime.BusinessLayer.Concrete.ConcreteManager
{
    public class UserManager : IUserService
    {
       private readonly IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void Add(User entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(User entity)
        {
            throw new NotImplementedException();
        }

        public User Get(Expression<Func<User, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll(Expression<Func<User, bool>>? filter = null)
        {
            throw new NotImplementedException();
        }

        public async Task<User?> GetAuthorInfoByBlogIdAsync(int id)
        {
            var values = await _userDal.GetAuthorInfoByBlogIdAsync(id);
            return values;
        }

        public void Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
