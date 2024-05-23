using ForestTime.BusinessLayer.Abstract.IAbstracService;
using ForestTime.Entitylayer.Concrete;
using System.Linq.Expressions;

namespace ForestTime.BusinessLayer.Concrete.ConcreteManager
{
    public class BlogManager : IBlogService
    {
        public void Add(Blog entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Blog entity)
        {
            throw new NotImplementedException();
        }

        public Blog Get(Expression<Func<Blog, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetAll(Expression<Func<Blog, bool>>? filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Blog entity)
        {
            throw new NotImplementedException();
        }
    }
}
