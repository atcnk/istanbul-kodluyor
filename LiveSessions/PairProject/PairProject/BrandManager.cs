namespace PairProject;

public class BrandManager
{
    private InMemoryBrandRepository _brandRepository;

    public BrandManager()
    {
        _brandRepository = new InMemoryBrandRepository();
    }

    public void Add(Brand brand)
    {
        if (brand.Name is null)
        {
            throw new Exception("Brand Name bos birakilamaz.");
        }
        else
        {
            _brandRepository.Add(brand);
        }
    }

    public List<Brand> GetAll()
    {
        return _brandRepository.GetAll();
    }

    public void Remove(Brand brand)
    {
        _brandRepository.Remove(brand);
    }

    public void RemoveAll()
    {
        _brandRepository.RemoveAll();
    }
}
