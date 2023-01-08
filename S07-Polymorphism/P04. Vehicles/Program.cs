using System;



public  class Program
{
    static void Main()
    {
        string [] carData = Console.ReadLine().Split(' ');
        string[] truckData = Console.ReadLine().Split(' ');
        Car c = new Car(double.Parse(carData[1]), double.Parse(carData[2]));
        Truck t = new Truck(double.Parse(truckData[1]), double.Parse(truckData[2]));
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] cmd = Console.ReadLine().Split(' ');
            if (cmd[1]== "Car")
            {
                if (cmd[0]=="Drive")
                {
                    c.Drive(double.Parse(cmd[2]));
                }
                else
                {
                    c.Refuel(double.Parse(cmd[2]));
                }
            }
            else
            {
                if (cmd[0] == "Drive")
                {
                    t.Drive(double.Parse(cmd[2]));
                }
                else
                {
                    t.Refuel(double.Parse(cmd[2]));
                }
            }
        }
        Console.WriteLine($"Car: {c.FuelQuantity:F2}");
        Console.WriteLine($"Truck: {t.FuelQuantity:f2}");
    }
}


