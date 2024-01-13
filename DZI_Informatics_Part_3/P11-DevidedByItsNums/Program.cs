namespace P11_DevidedByItsNums
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                int n = int.Parse(Console.ReadLine());
                bool devided = true;
                while (n != 0)
                {
                    int digit = n % 10;
                    if (n % digit != 0)
                    {
                        devided = false;
                    }
                    n /= 10;
                }
                Console.WriteLine(devided);
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong!");
            }
        }
    }
}


