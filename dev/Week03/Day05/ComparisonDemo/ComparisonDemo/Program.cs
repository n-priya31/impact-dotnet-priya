using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Interface & Abstract ===");

        Car car = new Car("Toyota");

        car.ShowBrand();
        car.Start();
        car.Drive();

        Console.WriteLine();

        Console.WriteLine("=== Static Methods ===");

        Console.WriteLine($"Factorial(5) = {MathHelper.Factorial(5)}");
        Console.WriteLine($"IsPrime(17) = {MathHelper.IsPrime(17)}");
        Console.WriteLine($"GCD(18,24) = {MathHelper.GCD(18, 24)}");

        Console.WriteLine();

        Console.WriteLine("=== Instance Methods ===");

        OrderProcessor order = new OrderProcessor
        {
            OrderId = 101,
            CustomerName = "Priya"
        };

        order.ProcessOrder();

        Console.ReadKey();
    }
}