using System;
using System.Collections.Generic;

//--------------------
// Method Overloading
//--------------------
class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public double Add(double a, double b)
    {
        return a + b;
    }

    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    public int Add(params int[] numbers)
    {
        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }

        return sum;
    }
}

//--------------------
// Runtime Polymorphism
//--------------------
abstract class Shape
{
    public abstract double CalculateArea();
}

class Circle : Shape
{
    public double Radius;

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
    public double Length;
    public double Width;

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

//--------------------
// Method Hiding
//--------------------
class Logger
{
    public void Log()
    {
        Console.WriteLine("Logger Log()");
    }
}

class FileLogger : Logger
{
    public new void Log()
    {
        Console.WriteLine("FileLogger Log()");
    }
}

class Program
{
    static void Main()
    {
        // Method Overloading
        Calculator calc = new Calculator();

        Console.WriteLine(calc.Add(10, 20));
        Console.WriteLine(calc.Add(10.5, 20.5));
        Console.WriteLine(calc.Add(10, 20, 30));
        Console.WriteLine(calc.Add(1, 2, 3, 4, 5));

        Console.WriteLine();

        // Runtime Polymorphism
        List<Shape> shapes = new List<Shape>()
        {
            new Circle(5),
            new Rectangle(10,4)
        };

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.CalculateArea());
        }

        Console.WriteLine();

        // Method Hiding
        Logger logger = new Logger();
        logger.Log();

        FileLogger fileLogger = new FileLogger();
        fileLogger.Log();

        Console.WriteLine();

        Logger obj = new FileLogger();
        obj.Log();
    }
}