using Abc.Northwind.Entities.Concrete;
using Abc.Core.DataAccess;

namespace Abc.Northwind.DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
        //Custom operations
    }
}
