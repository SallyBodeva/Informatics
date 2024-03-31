public class Program
{
    public static void Main()
    {
        int secs = int.Parse(Console.ReadLine());
        int freeWind = int.Parse(Console.ReadLine());
        Queue<string> cars = new Queue<string>();
        int passedCars = 0;
        string cmd = string.Empty;
        while ((cmd = Console.ReadLine())!="END")
        {
            if (cmd!="green")
            {
                cars.Enqueue(cmd);
            }
            else
            {
                List<char> car = new List<char>(cars.Peek().ToCharArray());
                for (int i = 0; i < secs; i++)
                {
                    if (car.Count<=0)
                    {
                        break;
                    }
                    car.RemoveAt(0);
                    passedCars++;
                    //TODO
                }
                if (car.Count>0 && car.Count>freeWind)
                {
                    Console.WriteLine("A crash happened!");
                    Console.WriteLine($"{car} was hit at {car[0]}.");
                    Environment.Exit(0);
                }
            }
        }
        Console.WriteLine("Everyone is safe.");
        Console.WriteLine($"{passedCars} total cars passed the crossroads.");
    }
}
