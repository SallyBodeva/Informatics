using System;
using System.Collections.Generic;
using System.Text;


public class BankAccount
{
    public BankAccount(string accountNumber, string ownerName, decimal accountBalance)
    {
        this.AccountNumber = accountNumber;
        this.OwnerName = ownerName;
        this.AccountBalance = accountBalance;
    }

    public string AccountNumber { get; private set; }
    public string OwnerName { get; private set; }
    public decimal AccountBalance { get;  set; }
    public void MakeDeposit(decimal amount)
    {
        this.AccountBalance += amount;
        Console.WriteLine($"Account balance: {this.AccountBalance}");
    }
    public void MakeWithdrawal(decimal amount)
    {
        if (this.AccountBalance>=amount)
        {
            this.AccountBalance -= amount;
            Console.WriteLine($"Withdrawn funds: {amount}. Funds available on the account: {this.AccountBalance}");
        }
        else
        {
            Console.WriteLine("Non-Sufficient Funds");
        }
    }
}


