using MyApplication.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApplication.Services
{
    public abstract class BaseProductService : IProductService
    {
        // somut ile soyutu bir arada kullandik
        public virtual void AddProductWithLogging(Product product)
        {
            Console.WriteLine("Loglama islemi yapildi");
            AddProduct(product);
        }

        public abstract void AddProduct(Product product);

        public abstract void DeleteProduct(Product product);

        public abstract void UpdateProduct(Product product);
    }
}
