namespace OOP_2._1_Polymorphism;

public abstract class Coffee
{
    public abstract void MakeCoffee();
    public void GrindCoffee()
    {
        Console.WriteLine("Kahve cekirdikleri ogutuluyor.");
    }
}

public class Latte : Coffee
{
    public override void MakeCoffee()
    {
        Console.WriteLine("Latte kahve yapiliyor.");
    }
}

public class Mocha : Coffee
{
    public override void MakeCoffee()
    {
        Console.WriteLine("Mocha kahve yapiliyor.");
    }
}