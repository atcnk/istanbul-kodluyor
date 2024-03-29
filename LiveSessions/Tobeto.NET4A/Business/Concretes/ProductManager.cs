using Business.Abstracts;
using DataAccess.Abstracts;
using Entities;

namespace Business.Concretes
{
    public class ProductManager : IProductService
    {
        IProductRepository _productRepository;

        public ProductManager(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void Add(Product product)
        {
            if (product.UnitPrice < 0)
            {
                throw new Exception("urun fiyati 0'dan kucuk olamaz");
            }

            _productRepository.Add(product);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _productRepository.GetAll();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
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
