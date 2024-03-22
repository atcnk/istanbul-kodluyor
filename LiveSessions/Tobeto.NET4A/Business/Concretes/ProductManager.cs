using Business.Abstracts;
using Entities;

namespace Business.Concretes
{
    public class ProductManager : IProductService
    {
        List<Product> products;

        public ProductManager()
        {
            this.products = new List<Product>();
        }

        public void Add(Product product)
        {
            products.Add(product);
        }

        public void Delete(int id)
        {
            products.Remove(GetById(id));
        }

        public List<Product> GetAll()
        {
            return this.products;
        }

        public Product GetById(int id)
        {
            return products.FirstOrDefault(p => p.Id == id);
        }

        public void Update(Product product)
        {
            Product existingProduct = GetById(product.Id);

            if (existingProduct is not null)
            {
                existingProduct.Name = product.Name;
                existingProduct.UnitPrice = product.UnitPrice;
            }
            else
            {
                throw new ArgumentException("Guncellenecek bir urun bulunamadi.");
            }
        }
    }
}
