using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    public string Name { get; set; }
    public string Department { get; set; }
    public decimal Salary { get; set; }
    public DateTime JoiningDate { get; set; }
}

class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>()
        {
            new Employee { Name="Priya", Department="HR", Salary=45000, JoiningDate=new DateTime(2022,5,1)},
            new Employee { Name="Rahul", Department="IT", Salary=65000, JoiningDate=new DateTime(2020,2,15)},
            new Employee { Name="Anu", Department="IT", Salary=70000, JoiningDate=new DateTime(2019,8,20)},
            new Employee { Name="Karthik", Department="Finance", Salary=55000, JoiningDate=new DateTime(2021,3,10)},
            new Employee { Name="John", Department="HR", Salary=52000, JoiningDate=new DateTime(2018,7,5)},
            new Employee { Name="David", Department="Finance", Salary=60000, JoiningDate=new DateTime(2017,11,25)},
            new Employee { Name="Meena", Department="IT", Salary=80000, JoiningDate=new DateTime(2016,1,12)},
            new Employee { Name="Sara", Department="HR", Salary=48000, JoiningDate=new DateTime(2023,4,18)},
            new Employee { Name="Vijay", Department="Finance", Salary=90000, JoiningDate=new DateTime(2015,9,30)},
            new Employee { Name="Arun", Department="IT", Salary=58000, JoiningDate=new DateTime(2021,6,22)}
        };

        // 1. Filter Salary > 50000

        Console.WriteLine("---- Query Syntax ----");

        var highSalaryQuery =
            from emp in employees
            where emp.Salary > 50000
            select emp;

        foreach (var emp in highSalaryQuery)
            Console.WriteLine($"{emp.Name} - {emp.Salary}");

        Console.WriteLine("\n---- Method Syntax ----");

        var highSalaryMethod = employees.Where(emp => emp.Salary > 50000);

        foreach (var emp in highSalaryMethod)
            Console.WriteLine($"{emp.Name} - {emp.Salary}");



        // 2. Order By Salary Descending

        Console.WriteLine("\n---- Query Syntax ----");

        var orderQuery =
            from emp in employees
            orderby emp.Salary descending
            select emp;

        foreach (var emp in orderQuery)
            Console.WriteLine($"{emp.Name} - {emp.Salary}");

        Console.WriteLine("\n---- Method Syntax ----");

        var orderMethod = employees.OrderByDescending(emp => emp.Salary);

        foreach (var emp in orderMethod)
            Console.WriteLine($"{emp.Name} - {emp.Salary}");



        // 3. Group By Department

        Console.WriteLine("\n---- Query Syntax ----");

        var groupQuery =
            from emp in employees
            group emp by emp.Department into dept
            select new
            {
                Department = dept.Key,
                Count = dept.Count(),
                AverageSalary = dept.Average(x => x.Salary)
            };

        foreach (var item in groupQuery)
            Console.WriteLine($"{item.Department} Count={item.Count} Avg={item.AverageSalary}");

        Console.WriteLine("\n---- Method Syntax ----");

        var groupMethod = employees
            .GroupBy(emp => emp.Department)
            .Select(dept => new
            {
                Department = dept.Key,
                Count = dept.Count(),
                AverageSalary = dept.Average(x => x.Salary)
            });

        foreach (var item in groupMethod)
            Console.WriteLine($"{item.Department} Count={item.Count} Avg={item.AverageSalary}");



        // 4. Anonymous Type

        Console.WriteLine("\n---- Query Syntax ----");

        var anonymousQuery =
            from emp in employees
            select new
            {
                emp.Name,
                Experience = DateTime.Now.Year - emp.JoiningDate.Year
            };

        foreach (var item in anonymousQuery)
            Console.WriteLine($"{item.Name} - {item.Experience} Years");

        Console.WriteLine("\n---- Method Syntax ----");

        var anonymousMethod = employees
            .Select(emp => new
            {
                emp.Name,
                Experience = DateTime.Now.Year - emp.JoiningDate.Year
            });

        foreach (var item in anonymousMethod)
            Console.WriteLine($"{item.Name} - {item.Experience} Years");
    }
}