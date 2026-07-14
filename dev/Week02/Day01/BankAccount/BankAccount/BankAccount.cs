using System;
using System.Collections.Generic;

namespace BankingApp
{
    internal class BankAccount
    {
        private decimal _balance;
        private List<string> _history = new List<string>();

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                _balance += amount;
                Console.WriteLine($"₹{amount} deposited successfully.");
                _history.Add($"Deposited ₹{amount}");
            }
            else
            {
                Console.WriteLine("Enter a valid amount.");
                _history.Add($"Failed Deposit: ₹{amount}");
            }
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Enter a valid amount.");
                _history.Add($"Failed Withdrawal: ₹{amount}");
            }
            else if (amount > _balance)
            {
                Console.WriteLine("Insufficient balance.");
                _history.Add($"Failed Withdrawal: ₹{amount} (Insufficient Balance)");
            }
            else
            {
                _balance -= amount;
                Console.WriteLine($"₹{amount} withdrawn successfully.");
                _history.Add($"Withdrawn ₹{amount}");
            }
        }

        public decimal GetBalance()
        {
            return _balance;
        }

        public void PrintHistory()
        {
            Console.WriteLine("\nTransaction History");

            if (_history.Count == 0)
            {
                Console.WriteLine("No transactions found.");
                return;
            }

            foreach (string transaction in _history)
            {
                Console.WriteLine(transaction);
            }
        }
    }
}