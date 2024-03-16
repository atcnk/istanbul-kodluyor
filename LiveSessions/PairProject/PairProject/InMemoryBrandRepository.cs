namespace PairProject;

public class InMemoryBrandRepository
{
    private List<Brand> _brands;

    public InMemoryBrandRepository()
    {
        _brands = new List<Brand>();
    }

    public void Add(Brand brand)
    {
        _brands.Add(brand);
    }

    public List<Brand> GetAll()
    {
        return _brands;
    }

    public void Remove(Brand brand)
    {
        _brands.Remove(brand);
    }

    public void RemoveAll()
    {
        _brands.Clear();
    }
}
