using ExtensionMethods;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========== Extension Method 1 ==========\n");

            string sentence = "";

            Console.WriteLine("Original : " + sentence);
           

            Console.WriteLine("\n========== Extension Method 2 ==========\n");

            List<int> numbers = new List<int>();

            Console.WriteLine("Is list empty?");
            Console.WriteLine(numbers.IsNullOrEmpty());

            numbers.Add(10);
            numbers.Add(20);

            Console.WriteLine("After adding elements:");
            Console.WriteLine(numbers.IsNullOrEmpty());



            Console.WriteLine("\n========== Extension Method 3 ==========\n");

            int[] testNumbers =
            {
                0,
                7,
                15,
                20,
                45,
                99,
                100,
                115,
                342,
                999
            };

            foreach (int number in testNumbers)
            {
                Console.WriteLine($"{number} -> {number.ToWords()}");
            }



            Console.WriteLine("\n========== Anonymous Types ==========\n");

            List<Employee> employees = new List<Employee>()
            {
                new Employee
                {
                    Name="Alice",
                    MonthlySalary=50000
                },

                new Employee
                {
                    Name="Bob",
                    MonthlySalary=65000
                },

                new Employee
                {
                    Name="Charlie",
                    MonthlySalary=40000
                }
            };


            var annualSalary = employees.Select(e => new
            {
                Name = e.Name,
                AnnualSalary = e.MonthlySalary * 12
            });


            foreach (var employee in annualSalary)
            {
                Console.WriteLine(
                    $"Name : {employee.Name}  Annual Salary : {employee.AnnualSalary:C}");
            }



            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}