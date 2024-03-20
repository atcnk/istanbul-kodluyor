using MyApplication.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApplication.Services
{
    // nesnenin soyut hali somut bir icerik barindiramaz.
    // soyutladigimizda su isimize yarayacak:
    // biz bu soyutlamadan turemis classlar yaratmak istedigimizde bu interface'i implemente edecegim
    public interface IProductService
    {
        public void AddProduct(Product product);
        public void UpdateProduct(Product product);
        public void DeleteProduct(Product product); 
    }
}
