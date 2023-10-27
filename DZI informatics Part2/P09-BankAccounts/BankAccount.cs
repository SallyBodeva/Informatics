using System;
using System.Collections.Generic;
using System.Text;

namespace P09_BankAccounts
{
    public abstract class BankAccount
    {
        public string AccountNumber  { get; set; }
        public decimal Balance { get; set; }
        public void Deposit(decimal amount)
        {
            this.Balance += amount;
        }
        public void Withdraw(decimal amount)
        {
            if (this.Balance>=amount)
            {
                this.Balance -= amount;
            }
        }
    }
}
