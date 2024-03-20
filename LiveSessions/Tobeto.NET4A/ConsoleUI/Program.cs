using ConsoleUI;

int number = 0;
string text = "Merhaba";

// OOP => gercek hayattaki nesneyi bilgisayara tanitmak

// ilgili kaliptan uretilen bir ornek, yeni bir urun
// instance
Product product = new(1, "Kazak"); // constructor, ctor -> Yapici blok
Product product2 = new Product();
product2.Name = "Klavye";
product2.Id = 2;

Customer customer = new();

// User'in minimum gereksinimlerini karsilayabilecek bir obje
User user = new Admin();
User user2 = new Customer();
user.LastName = "Deneme";
// user.Role = "Deneme;

// yazilim isci siniflara da nesene olarak bakar. Manager, DaL
// Veritabanin nesnesi -> MssqlNesnesi, PostgresqlNesnesi

// OOP Concepts -> Constructor, Access Modifiers, Inheritance, Polymorphism.,
// Abstraction, Interface