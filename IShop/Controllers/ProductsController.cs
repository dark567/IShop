using IShop.BusinessLogic.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IShop.Controllers
{
    public class ProductsController : ApiController
    {
        IProductService _productService = new ProductService();

        public IHttpActionResult GetAll()
        {
            return Ok(_productService.GetAll());
        }

        public IHttpActionResult Get(int id)
        {
            return Ok(_productService.Get(id));
        }
    }
}
