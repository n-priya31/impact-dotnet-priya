namespace EmployeePayroll
{
    public abstract class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Department { get; set; }

        // Every employee calculates salary differently
        public abstract decimal CalculateSalary();
    }
}