using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    public class InsufficientFundsException : Exception
    {
        public decimal DeficitAmount { get; }

        public InsufficientFundsException(string message, decimal deficitAmount) : base(message)
        {
            DeficitAmount = deficitAmount;
        }

    }
}
