using EmployeePayroll;

namespace EmployeePayroll
{
    public class PartTimeEmployee : Employee
    {
        public decimal HourlyRate { get; set; }

        public int HoursWorked { get; set; }

        public override decimal CalculateSalary()
        {
            return HourlyRate * HoursWorked;
        }
    }
}