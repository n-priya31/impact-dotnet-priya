using EmployeePayroll;

namespace EmployeePayroll
{
    public class FullTimeEmployee : Employee, ITaxable
    {
        public decimal MonthlySalary { get; set; }

        public override decimal CalculateSalary()
        {
            return MonthlySalary;
        }

        // Example tax = 10%
        public decimal CalculateTax()
        {
            return MonthlySalary * 0.10m;
        }
    }
}