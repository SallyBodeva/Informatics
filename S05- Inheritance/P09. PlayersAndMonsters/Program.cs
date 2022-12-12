using System;


public class Program
{
    static void Main()
    {
        string type = Console.ReadLine();
        string name = Console.ReadLine();
        int level = int.Parse(Console.ReadLine());
        Hero h;
        switch (type)
        {
            case "Elf":
                h = new Elf(name, level);
                break;
            case "MuseElf":
                h = new MuseElf(name, level);
                break;
            case "Wizard":
                h = new Wizard(name, level);
                break;
            case "DarkWizard":
                h = new DarkKnight(name, level);
                break;
            case "SoulMaster":
                h = new SoulMaster(name, level);
                break;
            case "Knight":
                h = new Knight(name, level);
                break;
            case "DarkKnight":
                h = new DarkKnight(name, level);
                break;
            case "BladeKnight":
                h = new BladenKnight(name, level);
                break;
                default:
                h = null;
                break;
        }
        Console.WriteLine(h);
    }
}

