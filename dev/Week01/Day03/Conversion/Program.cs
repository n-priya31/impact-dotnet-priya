using System;

namespace TypeConversionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Implicit Conversion

            Console.WriteLine("Implicit Conversion");

            int number = 100;

            long longNumber = number;
            float floatNumber = longNumber;
            double doubleNumber = floatNumber;

            Console.WriteLine($"int    : {number}");
            Console.WriteLine($"long   : {longNumber}");
            Console.WriteLine($"float  : {floatNumber}");
            Console.WriteLine($"double : {doubleNumber}");

            // Explicit Conversion

            Console.WriteLine("\n Explicit Conversion ");

            double price = 99.99;

            int wholeNumber = (int)price;

            Console.WriteLine($"Double : {price}");
            Console.WriteLine($"Integer: {wholeNumber}");

            // is Operator

            Console.WriteLine("\n is Operator ");

            object value = 100;

            Console.WriteLine(value is int);
            Console.WriteLine(value is string);

            // as Operator

            Console.WriteLine("\n as Operator ");

            object text = "Hello World";

            string result = text as string;

            Console.WriteLine(result);

            object numberObject = 100;

            string invalid = numberObject as string;

            Console.WriteLine(invalid == null);

            // Convert.ToInt32()

            Console.WriteLine("\n Convert.ToInt32() ");

            string numberString = "250";

            int convertedNumber = Convert.ToInt32(numberString);

            Console.WriteLine(convertedNumber);

            // int.TryParse()

            Console.WriteLine("\n int.TryParse() ");

            string input = "ABC";

            bool success = int.TryParse(input, out int parsedNumber);

            Console.WriteLine($"Success: {success}");

            if (success)
            {
                Console.WriteLine(parsedNumber);
            }
            else
            {
                Console.WriteLine("Invalid integer.");
            }
        }
    }
}