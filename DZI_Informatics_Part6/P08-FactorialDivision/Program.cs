public class Program
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine($"{(Factorial(a) / Factorial(b)):f2}");
    }
    public static double Factorial(double n)
    {
        if (n<=1)
        {
            return n;
        }
        return n*=Factorial(n-1);
    }
}
