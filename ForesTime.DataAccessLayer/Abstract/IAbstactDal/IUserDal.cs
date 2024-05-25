using ForestTime.DataAccessLayer.Abstract.IGenericRapository;
using ForestTime.Entitylayer.Concrete;

namespace ForestTime.DataAccessLayer.Abstract.IAbstactDal
{
    public interface IUserDal : IGenericRepository<User>
    {
        Task<User?> GetAuthorInfoByBlogIdAsync(int id);
    }   
}
