using System;

namespace NullableDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nullable int with HasValue

            int? age = null;

            Console.WriteLine("Age Example");

            if (age.HasValue)
            {
                Console.WriteLine($"Age: {age.Value}");
            }
            else
            {
                Console.WriteLine("Age is not available.");
            }

            Console.WriteLine();

            age = 25;

            if (age.HasValue)
            {
                Console.WriteLine($"Age: {age.Value}");
            }
            else
            {
                Console.WriteLine("Age is not available.");
            }

            Console.WriteLine();

            // -----------------------------
            // ApplyDiscount Method
            // -----------------------------

            ApplyDiscount(null);

            ApplyDiscount(10);
        }

        static void ApplyDiscount(double? discount)
        {
            double finalDiscount = discount ?? 5;

            Console.WriteLine($"Discount Applied: {finalDiscount}%");
        }
    }
}