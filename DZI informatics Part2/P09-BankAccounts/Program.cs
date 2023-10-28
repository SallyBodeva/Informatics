
using System;
using System.Text;
using System.Threading;

namespace P09_BankAccounts
{
    public class Program
    {
        static void Main()
        {
            StringBuilder sb = Intro();
            Console.Write(sb.ToString());
            int backAcountType = int.Parse(Console.ReadLine());
            Console.Write($"Въведете начален баланс: ");
            decimal initialBalance = decimal.Parse(Console.ReadLine());
            switch (backAcountType)
            {
                case 1:
                    SavingsAccount sA = new SavingsAccount() {Balance=initialBalance};
                    SavingAccountMethods(sA);
                    break;

                case 2:
                    CheckingAccount aC = new CheckingAccount() { Balance = initialBalance };
                    CheckingAccountMethods(aC);
                    break;

                case 3:
                    CertificateOfDeposit cD = new CertificateOfDeposit() { Balance = initialBalance };
                    CertificateOfDepositMethods(cD);
                    break;
            }
        }
        private static void SavingAccountMethods(SavingsAccount account)
        {
            while (true)
            {
                Console.WriteLine(Commands().ToString());
                Console.Write("Изберете действие: ");
                int commandNum = int.Parse(Console.ReadLine());
                decimal amount = 0;
                switch (commandNum)
                {
                    case 1:
                        Console.Write("Въведете сума за внасяне: ");
                        amount = decimal.Parse(Console.ReadLine());
                        break;
                    case 2:
                        Console.Write("Въведете сума за теглене: ");
                        amount = decimal.Parse(Console.ReadLine()); ;
                        break;
                    case 3:
                        Console.WriteLine("Изчисляване на лихва...");
                        Thread.Sleep(3000);
                        account.CalculateInterest();
                        break;
                    case 4:
                        Console.WriteLine("Благодарим, че използвахте банковия управител!");
                        Environment.Exit(0);
                        break;
                }
            }
        }
        private static void CheckingAccountMethods(CheckingAccount account)
        {
            while (true)
            {
                Console.WriteLine(Commands().ToString());
                Console.Write("Изберете действие: ");
                int commandNum = int.Parse(Console.ReadLine());
                decimal amount = 0;
                switch (commandNum)
                {
                    case 1:
                        Console.Write("Въведете сума за внасяне: ");
                        amount = decimal.Parse(Console.ReadLine());
                        break;
                    case 2:
                        Console.Write("Въведете сума за теглене: ");
                        amount = 200;
                        break;
                    case 3:
                        Console.WriteLine("Такса обслужване...");
                        Thread.Sleep(3000);
                        account.DeductFees();
                        break;
                    case 4:
                        Console.WriteLine("Благодарим, че използвахте банковия управител!");
                        Environment.Exit(0);
                        break;
                }
            }
        }
        private static void CertificateOfDepositMethods(CertificateOfDeposit account)
        {
            while (true)
            {
                Console.WriteLine(Commands().ToString());
                Console.Write("Изберете действие: ");
                int commandNum = int.Parse(Console.ReadLine());
                decimal amount = 0;
                switch (commandNum)
                {
                    case 1:
                        Console.Write("Въведете сума за внасяне: ");
                        amount = decimal.Parse(Console.ReadLine());
                        break;
                    case 2:
                        Console.Write("Въведете сума за теглене: ");
                        amount = 200;
                        break;
                    case 3:
                        Console.WriteLine("Теглене след изтичане на срока...");
                        Thread.Sleep(3000);
                        account.WithdrawOnMaturity();
                        break;
                    case 4:
                        Console.WriteLine("Благодарим, че използвахте банковия управител!");
                        Environment.Exit(0);
                        break;
                }
            }
        }
        private static StringBuilder Commands()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Изберете действие:");
            sb.AppendLine("1.Внасяне");
            sb.AppendLine("2.Теглене");
            sb.AppendLine("3.Изчисляване на лихва");
            sb.AppendLine("4.Изход");
            return sb;
        }
        private static StringBuilder Intro()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Добре дошли в банковия управител!");
            sb.AppendLine("Моля, изберете вид сметка:");
            sb.AppendLine("1.Спестовна сметка");
            sb.AppendLine("2.Разплащателна сметка");
            sb.AppendLine("3.Сметка със срок на депозита");
            sb.Append("Въведете номер на избраната сметка: ");
            return sb;
        }
    }
}
