namespace OOP;

public class ProductManager
{
    private InMemoryProductRepository _repository;

    public ProductManager()
    {
        _repository = new InMemoryProductRepository();
    }

    public void Add(Product product)
    {
        if (product.Name is null)
        {
            throw new Exception("Product Name bos olamaz");
        }
        else
        {
            _repository.Add(product);
        }
    }
    
    public List<Product> GetAll()
    {
        return _repository.GetAll();
    }
}
