using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Engine
{
    private Controller controller;
    public Engine()
    {
        controller = new Controller();
        Run();
    }

    private void Run()
    {
        while (true)
        {
            try
            {
                List<string> args = Console.ReadLine().Split(' ').ToList();
                string result = string.Empty;

                switch (args[0])
                {
                    case "AddCareItem":
                        result = controller.AddCareItem(args);
                        Console.WriteLine(result);
                        break;
                    case "AddPlant":
                        result = controller.AddPlant(args);
                        Console.WriteLine(result);
                        break;
                    case "GetTotalCaresByPlantId":
                        result = controller.GetTotalCaresByPlantId(args);
                        Console.WriteLine(result);
                        break;
                    case "WaterPlantById":
                        result = controller.WaterPlantById(args);
                        Console.WriteLine(result);
                        break;
                    case "FertilizePlantById":
                        result = controller.FertilizePlantById(args);
                        Console.WriteLine(result);
                        break;
                    case "GetTallestTree":
                        result = controller.GetTallestTree(args);
                        Console.WriteLine(result);
                        break;
                    case "End":
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

