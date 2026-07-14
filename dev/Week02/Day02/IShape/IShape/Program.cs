using System;

interface IShape
{
    double CalculateArea();
    double CalculatePerimeter();
}

interface IDrawable
{
    void Draw();
}

class Circle : IShape, IDrawable
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }

    public double CalculatePerimeter()
    {
        return 2 * Math.PI * Radius;
    }

    public void Draw()
    {
        Console.WriteLine("Drawing Circle...");
    }
}

class Program
{
    static void Main()
    {
        Circle circle = new Circle(5);

        circle.Draw();

        Console.WriteLine($"Area : {circle.CalculateArea()}");

        Console.WriteLine($"Perimeter : {circle.CalculatePerimeter()}");
    }
}