using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    public class Account
    {
        public decimal Balance { get; private set; }
        public Account(decimal balance)
        {
            Balance = balance;
        }

        public void Withdraw(decimal amount)
        {
            if (amount > Balance)
            {
                decimal deficit = amount - Balance;

                throw new InsufficientFundsException("Insufficient balance for withdraw", deficit);
            }

            Balance = Balance - amount;

            Console.WriteLine("Withdraw successful");
            Console.WriteLine($"Balance: {Balance}");
        }
    }
}
