namespace OOP;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int CategoryId { get; set; }

    public Product()
    {
        
    }

    public Product(int id, string name, int categoryId)
    {
        Id = id;
        Name = name;
        CategoryId = categoryId;
    }
}
