﻿using MyApplication.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApplication.Services
{
    public class ProductServiceMySql : BaseProductService
    {
        public override void AddProduct(Product product)
        {
            Console.WriteLine("Urun mysqle eklendi.");
        }

        public override void DeleteProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public override void UpdateProduct(Product product)
        {
            
        }
    }
}
