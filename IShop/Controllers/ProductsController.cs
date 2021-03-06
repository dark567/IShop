﻿using IShop.BusinessLogic.Services;
using IShop.Domain.Models;
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

        [HttpPost]
        public HttpResponseMessage Add([FromBody] Product product) //[FromBody] означает что из тела запроса а не из заголовка
        {
            if (!ModelState.IsReadOnly)
            {
                var errorMessage = new HttpResponseMessage(HttpStatusCode.BadRequest);
                errorMessage.Content = new StringContent("Name can't be empty");
                return errorMessage;
            }
            _productService.Add(product);
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        [HttpPut]
        public IHttpActionResult Update([FromBody] Product product)
        {
            _productService.Update(product);
            return Ok();
        }
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            _productService.Delete(id);
            return Ok();
        }
    }
}
