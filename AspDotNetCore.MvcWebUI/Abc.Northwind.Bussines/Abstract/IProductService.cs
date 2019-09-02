﻿using Abc.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abc.Northwind.Bussines.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();

        List<Product> GetByCategoryId(int categoryId);

        void Add(Product product);

        void Delete(Product product);

        void Update(Product product);

        Product GetById(int productId);
    }
}
