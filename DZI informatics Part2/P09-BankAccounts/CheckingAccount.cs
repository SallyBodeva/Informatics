using System;
using System.Collections.Generic;
using System.Text;

namespace P09_BankAccounts
{
    public class CheckingAccount:BankAccount
    {
        private const decimal Servicefee = 2.5m;
        public void DeductFees()
        {
            this.Balance -= Servicefee;
        }
    }
}
