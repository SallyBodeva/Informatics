using System;
using System.Linq;

public class Program
{
    static void Main()
    {
        while (true)
        {
            try
            {
                string[] data = Console.ReadLine().Split(' ').ToArray();
                if (data[0] == "Beast!")
                {
                    break;
                }
                switch (data[0])
                {
                    case "Dog":
                        Dog d = new Dog(data[1], int.Parse(data[2]), data[3]);
                        Console.WriteLine(d);
                        d.ProduceSound();
                        break;
                    case "Cat":
                        Cat c = new Cat(data[1], int.Parse(data[2]), data[3]);
                        Console.WriteLine(c);
                        c.ProduceSound();
                        break;
                    case "Frog":
                        Frog f = new Frog(data[1], int.Parse(data[2]), data[3]);
                        Console.WriteLine(f);
                        f.ProduceSound();
                        break;
                    case "Kitten":
                        Kitten k = new Kitten(data[1], int.Parse(data[2]), data[3]);
                        Console.WriteLine(k);
                        k.ProduceSound();
                        break;
                    case "Tomcat":
                        Tomcat t = new Tomcat(data[1], int.Parse(data[2]), data[3]);
                        Console.WriteLine(t);
                        t.ProduceSound();
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

