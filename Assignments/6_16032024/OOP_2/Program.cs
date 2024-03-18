using OOP_2._1_Polymorphism;
using OOP_2._2_Inheritance;
using OOP_2._3_GenericType;
using OOP_2._5_Encapsulation;

PolymorphismWithVirtualOverride();
PolymorphismWithAbstractClass();
InheritanceExample1();
GenericTypeExample();
EncapsulationExample();

static void PolymorphismWithVirtualOverride()
{
    Football football = new Football();
    Basketball basketball = new Basketball();

    football.DescriptionLog();
    basketball.DescriptionLog();

    Console.WriteLine("Futbol ve basketbolun aciklama kisimlarini yazdirdik.");
    Console.WriteLine("Base class icerisi farkli olmasina ragmen ayni metot uzerinden farkli bir aciklama yazdirdik.");
    Console.WriteLine("Basketbol metodunu override ederken metodun base'ini kullandigimiz icin hem kendisi hem de base'ini yazdirdik.");
}

static void PolymorphismWithAbstractClass()
{
    Mocha mocha = new Mocha();
    Latte latte = new Latte();

    mocha.GrindCoffee();
    latte.GrindCoffee();
    mocha.MakeCoffee();
    latte.MakeCoffee();

    Console.WriteLine("Abstrac kullanarak polymorphism gerceklestirdik.");
    Console.WriteLine("Kahve yapma metodunun icini bos birakarak kahve turleri siniflarinda doldurduk.");
    Console.WriteLine("Bunun yaninda kahve ogutmek ortak bir eylem oldugu icin o metodu override etmedik, direkt abstract class'ta icini doldurduk.");
}

static void InheritanceExample1()
{
    Bow bow = new Bow();
    bow.Name = "Steel Bow";
    bow.AttackDamage = 27;
    bow.AttackCooldown = 0.6f;
    bow.Durability = 100;
    bow.Weight = 55.3f;
    bow.ArrowType = "Iron Arrow";
    bow.Speed = 7.3f;

    FireStaff fireStaff = new FireStaff();
    fireStaff.Name = "Ancient Fire Staff";
    fireStaff.AttackDamage = 46;
    fireStaff.AttackCooldown = 1.1f;
    fireStaff.Durability = 100;
    fireStaff.Weight = 125;
    fireStaff.BurnDamage = 3;
}

static void GenericTypeExample()
{
    DataHolder<string> stringDataHolder = new DataHolder<string>();
    DataHolder<int> integerDataHolder = new DataHolder<int>();

    stringDataHolder.Data = "OOP";
    integerDataHolder.Data = 10;

    Console.WriteLine($"stringDataHolder degiskeni icerisinde: {stringDataHolder.Data} degiskeni tutulmaktadir.");
    Console.WriteLine($"integerDataHolder degiskeni icerisinde: {integerDataHolder.Data} degiskeni tutulmaktadir.");
    Console.WriteLine("Bu iki degisken de DataHolder sinifindan yaratilmis olmasina ragmen generic yapisindan dolayi hem string hem de integer gibi farkli degisken turlerinde olabilir.");
}

static void EncapsulationExample()
{
    Player player = new Player();
    player.Health = 100;

    Console.WriteLine($"Oyuncunun cani: {player.Health}");

    for (int i = 0; i < 5; i++)
    {
        player.Health -= 21;
        Console.WriteLine($"Oyuncu 21 hasar aliyor, oyuncunun cani: {player.Health} oldu.");
    }

    Console.WriteLine("Oyuncu 16 cani varken 21 hasar aldi ama cani eksiye degil 0'a dustu.");
}

