namespace OOP_2._1_Polymorphism;

public class Sport
{
    public virtual void DescriptionLog()
    {
        Console.WriteLine("Aciklama yazdirma base'i.");
    }
}

public class Football : Sport
{
    public override void DescriptionLog()
    {
        Console.WriteLine("Futbol.");
    }
}

public class Basketball : Sport
{
    public override void DescriptionLog()
    {
        base.DescriptionLog();
        Console.WriteLine("Basketbol.");
    }
}