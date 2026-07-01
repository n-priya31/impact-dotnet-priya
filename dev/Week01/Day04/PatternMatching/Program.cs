using System;

namespace PatternMatchingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" Type Pattern Matching ");

            DisplayValue(100);
            DisplayValue("Hello");
            DisplayValue(99.99);
            DisplayValue(null);

            Console.WriteLine();

            Console.WriteLine(" Grade Calculator ");

            Console.WriteLine($"Marks : 95 | Grade : {GetGrade(95)}");
            Console.WriteLine($"Marks : 82 | Grade : {GetGrade(82)}");
            Console.WriteLine($"Marks : 73 | Grade : {GetGrade(73)}");
            Console.WriteLine($"Marks : 61 | Grade : {GetGrade(61)}");
            Console.WriteLine($"Marks : 40 | Grade : {GetGrade(40)}");

            Console.WriteLine();

            Console.WriteLine(" Order Discount ");

            Order order1 = new Order { Status = "Premium", Amount = 1500 };
            Order order2 = new Order { Status = "Premium", Amount = 700 };
            Order order3 = new Order { Status = "Regular", Amount = 1500 };
            Order order4 = new Order { Status = "Regular", Amount = 500 };

            Console.WriteLine($"Order 1 Discount : {GetDiscount(order1)}%");
            Console.WriteLine($"Order 2 Discount : {GetDiscount(order2)}%");
            Console.WriteLine($"Order 3 Discount : {GetDiscount(order3)}%");
            Console.WriteLine($"Order 4 Discount : {GetDiscount(order4)}%");

            Console.ReadKey();
        }

        // Demonstrates type pattern matching.
        static void DisplayValue(object value)
        {
            switch (value)
            {
                case int number:
                    Console.WriteLine($"Integer Value : {number}");
                    break;

                case string text:
                    Console.WriteLine($"String Value  : {text}");
                    break;

                case double amount:
                    Console.WriteLine($"Double Value  : {amount}");
                    break;

                case null:
                    Console.WriteLine("Value is Null");
                    break;

                default:
                    Console.WriteLine("Unknown Type");
                    break;
            }
        }

        // Demonstrates switch expression with relational patterns.
        static string GetGrade(int marks)
        {
            return marks switch
            {
                >= 90 => "A",
                >= 80 => "B",
                >= 70 => "C",
                >= 60 => "D",
                _ => "F"
            };
        }

        // Demonstrates property pattern matching.
        static int GetDiscount(Order order)
        {
            return order switch
            {
                { Status: "Premium", Amount: >= 1000 } => 20,
                { Status: "Premium" } => 10,
                { Amount: >= 1000 } => 5,
                _ => 0
            };
        }
    }

    class Order
    {
        public string Status { get; set; }

        public decimal Amount { get; set; }
    }
}