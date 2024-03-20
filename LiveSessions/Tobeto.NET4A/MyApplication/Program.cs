using MyApplication.Entities;
using MyApplication.Services;

Console.WriteLine("Hello, World!");

Product product = new Product();
product.Name = "Monitor";
product.UnitPrice = 10;
product.Id = 1;

BaseProductService productService = new ProductServiceMySql();
productService.AddProductWithLogging(product);
//productService.Deneme = 10;

BaseProductService productService2 = new ProductService();
productService2.AddProductWithLogging(product);

// sistemle servis arasinda soyut bir servis olusturacagiz
// sistem her zaman tek bi yerle iletisim halinde olacak
// soyut servis: servislerin servis olabilmesi icin gereksinimlerini belirler
// oncesine bi de araya yari soyut servis ekleyebiliyoruz
// 