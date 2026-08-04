using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Priya", Salary = 50000 },
            new Employee { Id = 2, Name = "Rahul", Salary = 45000 },
            new Employee { Id = 3, Name = "Anita", Salary = 70000 },
            new Employee { Id = 4, Name = "Karthik", Salary = 60000 },
            new Employee { Id = 5, Name = "John", Salary = 55000 },
            new Employee { Id = 6, Name = "Meena", Salary = 48000 },
            new Employee { Id = 7, Name = "Arun", Salary = 80000 },
            new Employee { Id = 8, Name = "Divya", Salary = 52000 },
            new Employee { Id = 9, Name = "Vijay", Salary = 65000 },
            new Employee { Id = 10, Name = "Sneha", Salary = 58000 }
        };

        Console.WriteLine("Sorted by Salary (IComparable)\n");

        employees.Sort();

        foreach (var employee in employees)
        {
            Console.WriteLine($"{employee.Name} - ₹{employee.Salary}");
        }

        Console.WriteLine();

        Console.WriteLine("Sorted by Name (IComparer)\n");

        employees.Sort(new EmployeeNameComparer());

        foreach (var employee in employees)
        {
            Console.WriteLine($"{employee.Name} - ₹{employee.Salary}");
        }

        Console.ReadKey();
    }
}