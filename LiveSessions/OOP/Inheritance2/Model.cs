using OOP.GenericType;

namespace OOP.Inheritance2;

public class Model : BaseEntity<short>
{
    public string Name { get; set; }
    public int BrandId { get; set; }
}
