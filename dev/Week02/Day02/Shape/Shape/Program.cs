using System;

abstract class Shape
{
    // Abstract Method
    public abstract double CalculateArea();

    // Concrete Method
    public void DisplayArea()
    {
        Console.WriteLine($"Area : {CalculateArea()}");
    }
}

class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

class Rectangle : Shape
{
    public double Length { get; set; }
    public double Width { get; set; }

    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }

    public override double CalculateArea()
    {
        return Length * Width;
    }
}

class Program
{
    static void Main()
    {
        Circle circle = new Circle(5);
        Rectangle rectangle = new Rectangle(10, 4);

        Console.WriteLine("Circle");
        circle.DisplayArea();

        Console.WriteLine();

        Console.WriteLine("Rectangle");
        rectangle.DisplayArea();

        // Uncomment to observe the compile-time error

        // Shape shape = new Shape();
    }
}