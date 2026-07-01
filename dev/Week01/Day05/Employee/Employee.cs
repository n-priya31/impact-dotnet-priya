using System;

public partial class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }

    public Employee(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public void CreateEmployee()
    {
        Console.WriteLine($"Employee Created: {Name}");
        LogCreation(); // partial method call
    }

    partial void LogCreation(); // declaration only
}