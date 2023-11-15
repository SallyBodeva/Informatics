using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P22_CryptoMiningSystem
{
    public class Engine
    {
        private Controller controller;

        public Engine()
        {
            controller = new Controller();
            this.Run();
        }

        public void Run()
        {
            while (true)
            {
                List<string> args = Console.ReadLine().Split(", ").ToList();
                string cmd = args[0];
                try
                {
                    switch (cmd)
                    {
                        case "RegisterUser":
                            Console.WriteLine(controller.RegisterUser(args));
                            break;
                        case "CreateComputer":
                            Console.WriteLine(controller.CreateComputer(args));
                            break;
                        case "Mine":
                            Console.WriteLine(controller.Mine());
                            break;
                        case "UserInfo ":
                            Console.WriteLine(controller.UserInfo(args));
                            break;
                        case "Shutdown":
                            Console.WriteLine(controller.Shutdown());
                            Environment.Exit(0);
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
