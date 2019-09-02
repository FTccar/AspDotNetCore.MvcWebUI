using Abc.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Abc.Core.DataAccess;

namespace Abc.Northwind.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        //Custom operations
    }
}
