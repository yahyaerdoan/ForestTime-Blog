using ForestTime.DataAccessLayer.Abstract.IGenericRapository;
using ForestTime.Entitylayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestTime.DataAccessLayer.Abstract.IAbstactDal
{
    public interface ICommentDal : IGenericRepository<Comment>
    {
    }
}
