using IShop.BusinessLogic.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IShop.Controllers
{
    public class CategoriesController : ApiController
    {
        private ICategoryService _categoryService = new CategoryService();
        public IHttpActionResult GetAll()
        {
            return Ok(_categoryService.GetAll());
        }

        public IHttpActionResult Get(int id)
        {
            return Ok(_categoryService.Get(id));
        }
    }
}
