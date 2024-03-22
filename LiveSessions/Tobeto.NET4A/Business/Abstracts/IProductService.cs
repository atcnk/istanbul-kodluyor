using Entities;

namespace Business.Abstracts
{
    public interface IProductService
    {
        Product GetById(int id);
        List<Product> GetAll();
        void Add(Product product);
        void Update(Product product);
        void Delete(int id);
    }
}
