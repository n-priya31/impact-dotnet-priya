using System;

namespace TuplesAndDeconstructionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" Get Minimum and Maximum ");

            // Integer array
            int[] numbers = { 15, 4, 9, 22, 7, 1 };

            // Deconstruct the returned tuple into two variables
            var (min, max) = GetMinMax(numbers);

            Console.WriteLine($"Minimum Value : {min}");
            Console.WriteLine($"Maximum Value : {max}");

            Console.WriteLine();

            Console.WriteLine(" Employee Lookup ");

            // Deconstruct the returned employee tuple
            var (name, age, department) = GetEmployee();

            Console.WriteLine($"Employee Name : {name}");
            Console.WriteLine($"Age           : {age}");
            Console.WriteLine($"Department    : {department}");

            Console.ReadKey();
        }

        /// Returns the minimum and maximum values from an integer array.
        static (int Min, int Max) GetMinMax(int[] numbers)
        {
            int min = numbers[0];
            int max = numbers[0];

            foreach (int number in numbers)
            {
                if (number < min)
                {
                    min = number;
                }

                if (number > max)
                {
                    max = number;
                }
            }

            // Return a named tuple
            return (min, max);
        }

        /// Returns employee details as a named tuple.
        static (string Name, int Age, string Department) GetEmployee()
        {
            return ("Smith", 40, "Service");
        }
    }
}