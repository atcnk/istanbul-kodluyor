using MyApplication.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApplication.Services
{
    // Servisler genelde metot tanimlamasi yapar

    // interface ile birlikte bi standart saglamis oluyoruz
    // bu standartlara uyan, implemente eden bi class istiyoruz

    public class ProductService : BaseProductService
    {
        public override void AddProduct(Product product)
        {
            Console.WriteLine("Urun mssqle eklendi.");
        }

        public override void DeleteProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public override void UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
