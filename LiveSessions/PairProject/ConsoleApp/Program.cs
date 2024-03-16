using PairProject;

Brand brand1 = new Brand(1, "Eti", "Atistirmaliklar", 1);
Brand brand2 = new Brand();
brand2.Id = 2;
brand2.Name = "BMW";
brand2.Description = "Araba";
brand2.CategoryId = 2;

BrandManager brandManager = new();
brandManager.Add(brand1);
brandManager.Add(brand2);

var brands = brandManager.GetAll();

foreach (var brand in brands)
{
    Console.WriteLine($"Marka adi: {brand.Name} - Id'si: {brand.Id} - Aciklamasi: {brand.Description} - Kategori Id'si: {brand.CategoryId}");
}

brandManager.RemoveAll();

if (brandManager.GetAll().Count == 0)
{
    Console.WriteLine("Butun markalar silinmistir.");
}