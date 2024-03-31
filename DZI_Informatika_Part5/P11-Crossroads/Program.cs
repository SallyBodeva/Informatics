public class Program
{
    public static void Main()
    {
        int secs = int.Parse(Console.ReadLine());
        int freeWind = int.Parse(Console.ReadLine());
        Queue<string> cars = new Queue<string>();
        string cmd = string.Empty;
        while ((cmd = Console.ReadLine())!="END")
        {
            if (cmd!="green")
            {
                cars.Enqueue(cmd);
            }
            else
            {
               
            }
        }
    }
}