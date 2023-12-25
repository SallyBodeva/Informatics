using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07_HighwayToPeak
{
    public class Engine
    {
        private static Controller controller;
        public Engine()
        {
            controller = new Controller();
            Run();
        }

        private void Run()
        {
            while (true)
            {
                List<string> args = Console.ReadLine().Split(' ').ToList();
                string result = string.Empty;

                try
                {
                    string command = args[0];
                    switch (command)
                    {
                        case "AddPeak":
                            result = controller.AddPeak(args[1], int.Parse(args[2]), args[3]);
                            break;
                        case "NewClimberAtCamp":
                            result = controller.NewClimberAtCamp(args[1], bool.Parse(args[2]));
                            break;
                        case "AttackPeak":
                            result = controller.AttackPeak(args[1], args[2]);
                            break;
                        case "CampRecovery":
                            result = controller.CampRecovery(args[1], int.Parse(args[2]));
                            break;
                        case "BaseCampReport":
                            result = controller.BaseCampReport();
                            break;
                        case "OverallStatistics":
                            result = controller.OverallStatistics();
                            break;
                        default:
                            result = "Error";
                            break;
                    }
                }
                catch (Exception ex)
                {
                    result = ex.Message;
                }
                Console.WriteLine(result);
            }
        }
    }
}
