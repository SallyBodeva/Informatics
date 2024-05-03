public class Program
{
    public static void Main()
    {
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());

        double distanceX = Math.Sqrt(Math.Pow(x1,2)+ Math.Pow(y1, 2));
        double distanceY = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));
        string result = distanceX <= distanceY ? $"({x1}, {y1})" : $"({x2}, {y2})";
        Console.WriteLine(result);
    }
}
