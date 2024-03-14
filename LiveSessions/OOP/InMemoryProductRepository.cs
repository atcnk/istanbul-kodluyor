namespace OOP;

public class InMemoryProductRepository
{
    private List<Product> _products;

    public InMemoryProductRepository()
    {
        _products = new List<Product>();

    }
    public List<Product> GetAll()
    {
        return _products;
    }

    public void Add(Product product)
    {
        _products.Add(product);
    }
}
