﻿using Microsoft.AspNetCore.Mvc;
using Entities;
using Business.Abstracts;
using Business.Concretes;

namespace WebAPI.Controllers
{
    // api/products diye bir istek gelirse products controller devreye girecek demis oluyoruz 
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IProductService productService;

        public ProductsController(IProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet]
        public List<Product> GetAll()
        {
            return productService.GetAll();
        }

        [HttpPost]
        public void Add([FromBody] Product product)
        {
            productService.Add(product);
        }
    }
}
