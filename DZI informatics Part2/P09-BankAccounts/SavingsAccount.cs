using System;
using System.Collections.Generic;
using System.Text;

namespace P09_BankAccounts
{
    public class SavingsAccount:BankAccount
    {
        public void CalculateInterest()
        {
            this.Balance += this.Balance * 0.055m;
        }
    }
}
