using RobotService.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace P02_RobotService
{
    public class Engine : IEngine
    {
        Controller c;
        public Engine()
        {
            c = new Controller();
        }
        public void Run()
        {
            StringBuilder sb = new StringBuilder();
            string result= string.Empty;
            try
            {
                while (true)
                {
                    string[] input = Console.ReadLine().Split(' ');
                    string command = input[0];
                    switch (command)
                    {
                        case "Exit":
                            Environment.Exit(0);
                            break;
                        case "CreateRobot":
                            result = c.CreateRobot(input[1], input[2]);
                            break;
                        case "CreateSupplement":
                            result = c.CreateSupplement(input[1]);
                            break;
                        case "UpgardeRobot":
                            result = c.UpgradeRobot(input[1], input[2]);
                            break;
                        case "PerformService":
                            result = c.PerformService(input[1], int.Parse(input[2]), int.Parse(input[3]));
                            break;
                        case "RobotRecovery":
                            result = c.RobotRecovery(input[1], int.Parse(input[2]));
                            break;
                        case "Report":
                            result = c.Report();
                            break;
                    }
                    sb.AppendLine(result);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine(sb.ToString().TrimEnd());
        }
    }
}
