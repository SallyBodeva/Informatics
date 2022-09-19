using System;

namespace P11_TournamentOfChristmas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = 0;
            int wins = 0;
            int loses = 0;

            int tournaments = int.Parse(Console.ReadLine());
            for (int i = 0; i < tournaments; i++)
            {
                while (true)
                {
                    string cmd = Console.ReadLine();
                    if (cmd == "Finish")
                    {
                        break;
                    }
                    string result = Console.ReadLine();
                    if (result=="win")
                    {
                        money += 20;
                        wins++;
                    }
                    else
                    {
                        loses++;
                    }
                    
                }
                if (wins > loses)
                {
                    money += money * 0.1;
                }
            }
            if (wins>loses)
            {
                money += money * 0.2;
                Console.WriteLine($"You won the tournament! Total raised money: {money}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {money}");
            }
        }
    }
}
