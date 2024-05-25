using ForestTime.BusinessLayer.Abstract.IAbstracService;
using ForestTime.DataAccessLayer.Abstract.IAbstactDal;
using ForestTime.Entitylayer.Concrete;
using System.Linq.Expressions;

namespace ForestTime.BusinessLayer.Concrete.ConcreteManager
{
    public class BlogManager : IBlogService
    {
        private readonly IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

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

        public List<Blog> GetBlogsWithCategoryAndUser()
        {
           var values = _blogDal.GetBlogsWithCategoryAndUser();
            return values;
        }

        public void Update(Blog entity)
        {
            throw new NotImplementedException();
        }
    }
}
