namespace OOP_2._2_Inheritance;

public abstract class Shape
{
    public abstract string GetName();
    public abstract double Perimeter();
    public abstract double Area();

    public void LogPerimeter() => Console.WriteLine($"{GetName()} seklinin cevresi: {Perimeter()}");

    public void LogArea() => Console.WriteLine($"{GetName()} seklin alani: {Area()}");
}

public class Square : Shape
{
    private double _side;

    public Square(double side)
    {
        Side = side;
    }

    public double Side
    {
        get => _side;
        set
        {
            if (value <= 0)
            {
                Console.WriteLine("Karenin bir kenari 0 veya 0'dan kucuk olamaz.");
                return;
            }

            _side = value;
        }
    }

    public override string GetName() => "Kare";
    public override double Perimeter() => _side * 4;
    public override double Area() => Math.Pow(_side, 2);
}

public class Rectangle : Shape
{
    private double _length;
    private double _width;

    public Rectangle(double length, double width)
    {
        _length = length;
        _width = width;
    }

    public double Length
    {
        get => _length;
        set
        {
            if (value <= 0)
            {
                Console.WriteLine("Dortgenin uzunlugu 0 veya 0'dan kucuk olamaz.");
                return;
            }

            _length = value;
        }
    }

    public double Width
    {
        get => _width;
        set
        {
            if (value <= 0)
            {
                Console.WriteLine("Dortgenin genisligi 0 veya 0'dan kucuk olamaz.");
                return;
            }

            _width = value;
        }
    }

    public override string GetName() => "Dortgen";
    public override double Perimeter() => (_length * 2) + (_width * 2);
    public override double Area() => _length * _width;
    public bool IsSquare() => _length == _width;
    public void LogIsSquare() => Console.WriteLine($"Dortgen sekli bir kare{(IsSquare() ? "dir." : " degildir.")}");
}

public class Circle : Shape
{
    private double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }

    public override string GetName() => "Daire";
    public override double Perimeter() => _radius * Math.PI * 2;
    public override double Area() => Math.Pow(_radius, 2) * Math.PI;
}