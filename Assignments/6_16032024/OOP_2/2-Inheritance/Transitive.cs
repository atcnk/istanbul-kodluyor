/* Bu 3 sinif birbirinden miras alarak kalitimin birbirine gecen, hiyerarsik bir yapida olabilecegini gostermektedir.
 * C sinifi B sinifindan, B sinifi A sinifindan kalitim almistir.
 * C sinifi hem B hem de A sinifdan degisken ve metotlari kullanabilir.
 * Erisim degistiricisinin public veya protected oldugu metot ve degiskenlerin kalitim alinmis siniflarda da kullanilabildigini gostermektedir.
 */

namespace OOP_2._2_Inheritance;

public class A
{
    public int PublicValue { get; set; }
    protected int ProtectedValue { get; set; }
    private int PrivateValue { get; set; }

    public void FirstMethod()
    {
        Console.WriteLine("Bu metot hiyerarsiye gore en yukaridaki sinifta tanimlandi.");
    }
}

public class B : A
{
    public void Z()
    {
        PublicValue = 1;
        ProtectedValue = 2;
        //PrivateValue = 3;
    }

    public void SecondMethod()
    {
        Console.WriteLine("Bu metot hiyerarsiye gore ortadaki sinifta tanimlandi.");
        FirstMethod();
        //Y();
    }

    protected void X()
    {
        Console.WriteLine("Protected metot.");
    }
}

public class C : B
{
    public void Y()
    {
        PublicValue = 1;
        ProtectedValue = 2;
        //PrivateValue = 3;
    }

    public void ThirdMethod()
    {
        Console.WriteLine("Bu metot hiyerarsiye gore en asagidaki sinifta tanimlandi.");
        SecondMethod();
        FirstMethod();
        Z();
        X();
    }
}
