﻿using IShop.BusinessLogic.Services;
using IShop.Domain.Models;
using System.Web.Http;

namespace IShop.Controllers
{
    public class CategoriesController : ApiController
    {
        private ICategoryService _categoryService = new CategoryService();

        [HttpGet]
        public IHttpActionResult GetAll()
        {
            return Ok(_categoryService.GetAll());
        }

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var category = _categoryService.Get(id);
            if (category == null)
                return NotFound();
            return Ok();
        }

        [HttpPost]
        public IHttpActionResult Add([FromBody] Category category) //[FromBody] означает что из тела запроса а не из заголовка
        {
            if (string.IsNullOrEmpty(category.Name))
                return Ok("Can't be empty");

            _categoryService.Add(category);
            return Ok();
        }

        [HttpPut]
        public IHttpActionResult Update([FromBody] Category category)
        {
            _categoryService.Update(category);
            return Ok();
        }
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            _categoryService.Delete(id);
            return Ok();
        }
    }
}
