using System;

public partial class Employee
{
    partial void LogCreation()
    {
        Console.WriteLine("Employee creation logged successfully.");
    }
}