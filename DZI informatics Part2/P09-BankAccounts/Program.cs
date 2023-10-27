
using System;
using System.Text;

namespace P09_BankAccounts
{
    public class Program
    {
        static void Main()
        {
            StringBuilder sb = Intro();
            Console.WriteLine(sb.ToString());
            BankAccount bA= null;
            int backAcountType = int.Parse(Console.ReadLine());
            switch (backAcountType)
            {
                case 1:
                    bA = new SavingsAccount();
                    break;

                case 2:
                    bA = new CheckingAccount();
                    break;

                case 3:
                    bA = new CertificateOfDeposit();
                    break;

            }
            Console.WriteLine(Commands().ToString());
            Console.Write("Изберете действие: ");
            while (true)
            {
                int commandType = int.Parse(Console.ReadLine());
                if (commandType==4)
                {
                    Environment.Exit(0);
                }
                decimal amount = 0;
                switch (commandType)
                {
                    case 1:
                        Console.Write("Въведете сума за внасяне: ");
                        amount = decimal.Parse(Console.ReadLine());
                        break;
                    case 2:
                        Console.Write("Въведете сума за теглене: ");
                        amount = 200;
                        break;
                }
            }
            //TO DO.....
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
            sb.Append("Въведете номер на избраната сметка:");
            return sb;
        }
    }
}
