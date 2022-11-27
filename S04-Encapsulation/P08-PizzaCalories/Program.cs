using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

public class Program
{
    static void Main()
    {
        Dough d = null;
        List<Topping> toppings = new List<Topping>();
        Pizza p = null;
        while (true)
        {
            try
            {
                List<string> cmd = Console.ReadLine().Split(' ').ToList();
                if (cmd[0] == "END")
                {
                    break;
                }
                if (cmd[0] == "Pizza")
                {
                    p = new Pizza(cmd[1]);
                }
                if (cmd[0] == "Dough")
                {
                     d = new Dough(cmd[1], cmd[2], double.Parse(cmd[3]));
                    p.Dough = d;
                }
                if (cmd[0]=="Topping")
                {
                    Topping t = new Topping(cmd[1], double.Parse(cmd[2]));
                    toppings.Add(t);
                    p.Toppings = toppings;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Environment.Exit(0);
            }
        }

        Console.WriteLine($"{p.Name} - {p.TotalCalories:f2} Calories.");
    }
}

