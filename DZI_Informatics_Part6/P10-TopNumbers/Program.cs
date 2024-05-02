using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        for (int i = 1; i <= number; i++)
        {
            if (IsDevisible(i) && HasOddNumber(i))
            {
                Console.WriteLine(i);
            }
        }
      
    }
    public static bool IsDevisible(int number)
    {
        int sum = 0;
        while (number > 0)
        {
            int digit = number % 10;
            sum += digit;
            number /= 10;
        }
        if (sum%8==0)
        {
            return true;
        }
        return false;
    }
    public static bool HasOddNumber(int number)
    {
        string n = number.ToString();
        if (n.Any(x=>int.Parse(x.ToString())%2==1))
        {
            return true;
        }
        return false;
    }
}