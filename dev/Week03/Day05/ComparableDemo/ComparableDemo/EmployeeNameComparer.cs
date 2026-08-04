using System.Collections.Generic;

public class EmployeeNameComparer : IComparer<Employee>
{
    // Custom sorting by Name
    public int Compare(Employee x, Employee y)
    {
        return x.Name.CompareTo(y.Name);
    }
}