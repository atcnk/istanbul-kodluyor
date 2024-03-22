namespace Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double UnitPrice { get; set; }

        public Product(int id, string name, double unitPrice)
        {
            Id = id;
            Name = name;
            UnitPrice = unitPrice;
        }
    }
}
