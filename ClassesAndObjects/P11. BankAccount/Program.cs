using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main()
    {
        List<string> dataCustomer = Console.ReadLine().Split(' ').ToList();
        BankAccount customer = new BankAccount(dataCustomer[0], dataCustomer[1] + " " + dataCustomer[2], decimal.Parse(dataCustomer[3]));
        while (true)
        {
            List<string> cmd = Console.ReadLine().Split(' ').ToList();
            if (cmd[0]=="End")
            {
                break;
            }
            switch (cmd[0])
            {
                case "Deposit":
                    customer.MakeDeposit(decimal.Parse(cmd[1]));
                    break;
                case "Withdrawal":
                    customer.MakeWithdrawal(decimal.Parse(cmd[1]));
                    break;
            }
        }
    }
}

