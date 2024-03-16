namespace PairProject;

public class Brand
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int CategoryId { get; set; }

    public Brand()
    {
    
    }

    public Brand(int id, string name, string description, int categoryId)
    {
        Id = id;
        Name = name;
        Description = description;
        CategoryId = categoryId;
    }
}
