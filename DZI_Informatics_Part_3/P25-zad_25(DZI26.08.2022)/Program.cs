namespace P25_zad_25_DZI26._08._2022_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double a = int.Parse(Console.ReadLine());
                double b = int.Parse(Console.ReadLine());

                double result1 = (-1)*Math.Sqrt(b/a);
                double result2 = Math.Sqrt(b/a);
                if (a>0 && b<0)
                {
                    Console.WriteLine("Няма реални корени");
                }
                else if (a < 0 && b > 0)
                {
                    Console.WriteLine("Всички корени са решение");
                }
                else if (a < 0 && b < 0)
                {
                    Console.WriteLine($"Решенията са (-inf; {result1:f2}) U ({result2:f2}; +inf)");
                }
                else
                {
                    Console.WriteLine($"Решенията са ({result1:f2};{result2:f2})");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Некоректно въведено число.");
            }
        }
    }
}
