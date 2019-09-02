using Abc.Northwind.Bussines.Abstract;
using Abc.Northwind.MvcWebUI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abc.Northwind.MvcWebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public ActionResult Index(int page=1, int categoryId=0)
        {
            int pageSize = 10;
            var products = _productService.GetByCategoryId(categoryId).Skip((page-1)*pageSize).Take(pageSize).ToList();
            ProductListViewModel model = new ProductListViewModel
            {
                Products = products,
                PageCount = (int)Math.Ceiling(products.Count / (double)pageSize),
                PageSize = pageSize,
                CurrentCategory = categoryId,
                CurrentPage = page
            };
            return View(model);
        }

        public ActionResult AddToCart()
        {

            return View();
        }

        public string Session()
        {
            HttpContext.Session.SetString("city", "istanbul");
            HttpContext.Session.SetInt32("age", 32);

            HttpContext.Session.GetString("city");
            return string.Empty;
        }
    }
}
