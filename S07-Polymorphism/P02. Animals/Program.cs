using System;


public class Program
{
    static void Main()
    {
        Animal dog = new Dog("Pesho", "Meat");
        Animal cat = new Cat("Pisana", "Whiskas");
        Console.WriteLine(dog.ExplainSelf());
        Console.WriteLine(cat.ExplainSelf());
    }
}

