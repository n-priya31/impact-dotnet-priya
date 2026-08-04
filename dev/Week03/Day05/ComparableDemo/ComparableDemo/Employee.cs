using System;

public class Employee : IComparable<Employee>
{
    public int Id { get; set; }

    public string Name { get; set; }

    public double Salary { get; set; }

    // Default sorting by Salary
    public int CompareTo(Employee other)
    {
        return Salary.CompareTo(other.Salary);
    }
}