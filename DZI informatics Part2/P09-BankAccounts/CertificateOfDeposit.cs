using System;
using System.Collections.Generic;
using System.Text;

namespace P09_BankAccounts
{
    public class CertificateOfDeposit:BankAccount
    {
        private const decimal ServiceFee = 2.5m;
        public DateTime MaturityDate  { get; set; }
        public void WithdrawOnMaturity()
        {
            if (MaturityDate<DateTime.Now)
            {
                this.Balance -= ServiceFee;
            }
        }
    }
}
