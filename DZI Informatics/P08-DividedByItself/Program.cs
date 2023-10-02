using System;

namespace P08_DividedByItself
{
    public class Program
    {
        static void Main()
        {
            string num = Console.ReadLine();
            int number = int.Parse(num);
            int digits = num.Length;
            int count = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i]=='-')
                {
                    digits--;
                    i++;
                }
                int n = int.Parse(num[i].ToString());
                if (number % n==0)
                {
                    count += 1;
                }
            }
            if (count==digits)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
