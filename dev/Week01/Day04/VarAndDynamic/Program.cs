using System;

namespace Task1_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // var
            Console.WriteLine(" VAR ");

            var message = "Hello";

            Console.WriteLine($"Value : {message}");
            Console.WriteLine($"Type  : {message.GetType()}");

            // Uncomment the line below to see the compile-time error
            // message = 100;

            Console.WriteLine();

            // dynamic
            Console.WriteLine(" DYNAMIC EXAMPLE ");

            dynamic value = "Hello";

            Console.WriteLine($"Value : {value}");
            Console.WriteLine($"Type  : {value.GetType()}");

            value = 100;

            Console.WriteLine($"Value : {value}");
            Console.WriteLine($"Type  : {value.GetType()}");

            value = true;

            Console.WriteLine($"Value : {value}");
            Console.WriteLine($"Type  : {value.GetType()}");

            Console.WriteLine();


            // Dynamic 
            Console.WriteLine(" DYNAMIC METHOD ");

            Add(10, 20);
            Add("Hello ", "World");

            Console.ReadKey();
        }

        static void Add(dynamic a, dynamic b)
        {
            Console.WriteLine($"First Value  : {a}");
            Console.WriteLine($"First Type   : {a.GetType()}");

            Console.WriteLine($"Second Value : {b}");
            Console.WriteLine($"Second Type  : {b.GetType()}");

            Console.WriteLine($"Result       : {a + b}");
            Console.WriteLine();
        }
    }
}