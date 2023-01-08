using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

public class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<BaseHero> heros = new List<BaseHero>();
        BaseHero h = null;
        for (int i = 0; i < n; i++)
        {
            string name = Console.ReadLine();
            string type = Console.ReadLine();
            switch (type)
            {
                case "Paladin":
                    h = new Paladin(name);
                    heros.Add(h);
                    Console.WriteLine(h.CastAbility());
                    break;
                case "Druid":
                    h = new Druid(name);
                    heros.Add(h);
                    Console.WriteLine(h.CastAbility());
                    break;
                case "Rogue":
                    h = new Rogue(name);
                    heros.Add(h);
                    Console.WriteLine(h.CastAbility());
                    break;
                case "Warrior":
                    h = new Warrior(name);
                    heros.Add(h);
                    Console.WriteLine(h.CastAbility());
                    break;
                default:
                    Console.WriteLine("Invalid hero!");
                    break;
            }
        }
        int bossPower = int.Parse(Console.ReadLine());
        int herosPower = heros.Sum(x => x.Power);

        if (herosPower > bossPower)
        {
            Console.WriteLine("Victory");
        }
        else
        {
            Console.WriteLine("Defeat...");
        }
    }
}

