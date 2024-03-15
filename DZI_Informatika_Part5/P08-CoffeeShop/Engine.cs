using P08_CoffeeShop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Engine
{
    public Engine()
    {
        Run();
    }

    private void Run()
    {
        CoffeeShop coffeeShop = new CoffeeShop();
        string result = string.Empty;
        try
        {
            while (true)
            {
                string[] command = Console.ReadLine().Split(" ");
                if (command[0]=="END")
                {
                    Environment.Exit(0);
                }
                switch (command[0])
                {
                    case "Add":
                        string type = command[1];
                        double price = double.Parse(command[2]);
                        coffeeShop.AddCoffee(type, price);
                        result = $"Added Coffee {type}.";
                        break;
                    case "AveragePrice":
                        double startPrice = double.Parse(command[1]);
                        double endPrice = double.Parse(command[2]);
                        result = $"Average result: {coffeeShop.AveragePriceInRange(startPrice, endPrice)}";
                        break;
                    case "FilterCoffees":
                        double filterPrice = double.Parse(command[1]);
                        result = $"Filtered coffees: {string.Join(" ",coffeeShop.FilterCoffeesByPrice(filterPrice))}";
                        break;
                    case "SortByType":
                        coffeeShop.SortAscendingByType();
                        break;
                    case "SortByPrice":
                        coffeeShop.SortDescendingByPrice();
                        break;
                    case "CheckCoffee":
                        string checkType = command[1];
                        result = coffeeShop.CheckCoffeeIsInCoffeeShop(checkType) ? result = $"Coffee {checkType} is available." : $"Coffee {checkType} is not available.";
                        break;
                    case "Print":
                        result = string.Join(Environment.NewLine, coffeeShop.ProvideInformationAboutAllCoffees());
                        break;
                    default:
                        result = "Something went wrong!";
                        break;
                }
                Console.WriteLine(result);
            }
        }
        catch (Exception ex)
        {
            result = ex.Message;
        }
    }
}

