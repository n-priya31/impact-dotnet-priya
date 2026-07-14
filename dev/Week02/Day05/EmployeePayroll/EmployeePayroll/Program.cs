using EmployeePayroll;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeePayroll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new FullTimeEmployee
                {
                    Id = 1,
                    Name = "Alice",
                    Department = "IT",
                    MonthlySalary = 60000
                },

                new FullTimeEmployee
                {
                    Id = 2,
                    Name = "Bob",
                    Department = "HR",
                    MonthlySalary = 50000
                },

                new PartTimeEmployee
                {
                    Id = 3,
                    Name = "Charlie",
                    Department = "IT",
                    HourlyRate = 400,
                    HoursWorked = 80
                },

                new PartTimeEmployee
                {
                    Id = 4,
                    Name = "David",
                    Department = "Finance",
                    HourlyRate = 500,
                    HoursWorked = 60
                },

                new ContractEmployee
                {
                    Id = 5,
                    Name = "Eva",
                    Department = "IT",
                    ContractAmount = 75000
                },

                new ContractEmployee
                {
                    Id = 6,
                    Name = "Frank",
                    Department = "Finance",
                    ContractAmount = 55000
                }
            };

            Console.WriteLine("EMPLOYEE PAYROLL");

            decimal totalPayroll = 0;

            foreach (Employee employee in employees)
            {
                decimal salary = employee.CalculateSalary();

                totalPayroll += salary;

                Console.WriteLine(
                    $"{employee.Name,-10} | {employee.Department,-10} | Salary : {salary:C}");

                if (employee is ITaxable taxableEmployee)
                {
                    Console.WriteLine($"Tax : {taxableEmployee.CalculateTax():C}");
                }

                Console.WriteLine();
            }

            Console.WriteLine($"Total Payroll : {totalPayroll:C}");

            Console.WriteLine("\nEmployees Grouped By Department");

            var departmentGroups = employees
                .GroupBy(e => e.Department);

            foreach (var group in departmentGroups)
            {
                Console.WriteLine($"\nDepartment : {group.Key}");

                foreach (Employee employee in group)
                {
                    Console.WriteLine(
                        $"{employee.Name} - {employee.CalculateSalary():C}");
                }
            }

            Console.ReadKey();
        }
    }
}