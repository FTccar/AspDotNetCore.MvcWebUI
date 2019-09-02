using Abc.Northwind.Bussines.Abstract;
using Abc.Northwind.DataAccess.Abstract;
using Abc.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abc.Northwind.Bussines.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categorydal)
        {
            _categoryDal = categorydal;
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }
    }
}
