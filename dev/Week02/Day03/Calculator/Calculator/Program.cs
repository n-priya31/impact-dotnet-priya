using System;

class Calculator
{
    public static double Add(double a, double b)
    {
        Console.WriteLine($"Addition: {a + b}");
        return a + b;
    }

    public static double Subtract(double a, double b)
    {
        Console.WriteLine($"Subtraction: {a - b}");
        return a - b;
    }

    public static double Multiply(double a, double b)
    {
        Console.WriteLine($"Multiplication: {a * b}");
        return a * b;
    }

    public static double Divide(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Cannot divide by zero.");
            return 0;
        }

        Console.WriteLine($"Division: {a / b}");
        return a / b;
    }
}

// Delegate
delegate double MathOperation(double a, double b);

class Program
{
    static void Main()
    {
        // Single Delegate
        MathOperation operation;

        operation = Calculator.Add;
        operation(10, 5);

        operation = Calculator.Subtract;
        operation(10, 5);

        operation = Calculator.Multiply;
        operation(10, 5);

        operation = Calculator.Divide;
        operation(10, 5);

        Console.WriteLine();

        // Multicast Delegate
        MathOperation multiOperation = Calculator.Add;
        multiOperation += Calculator.Multiply;

        multiOperation(10, 5);

        Console.WriteLine();

        // Func Delegate
        Func<double, double, double> funcOperation = Calculator.Add;
        funcOperation(10, 5);

        funcOperation = Calculator.Multiply;
        funcOperation(10, 5);
    }
}