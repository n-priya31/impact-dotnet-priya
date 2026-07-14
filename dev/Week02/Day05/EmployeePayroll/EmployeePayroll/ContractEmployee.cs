using EmployeePayroll;

namespace EmployeePayroll
{
    public class ContractEmployee : Employee
    {
        public decimal ContractAmount { get; set; }

        public override decimal CalculateSalary()
        {
            return ContractAmount;
        }
    }
}