namespace P11_DZi_25zad_
{
    public class Program
    {
        public static void Main()
        {
			try
			{
                string number = Console.ReadLine();
                int n = int.Parse(number);
                if (n < 0)
                {
                    Console.WriteLine("Incorrectly entered number");
                }
                else
                {
                    char[] arrayOfNumer = number.ToCharArray();
                    Array.Reverse(arrayOfNumer);
                    string reversedNum = new string(arrayOfNumer);

                    if (reversedNum == number)
                    {
                        Console.WriteLine($"{number} is a palindrome");
                    }
                    else
                    {
                        Console.WriteLine($"{number} is NOT a palindrome");
                    }
                }
            }
			catch (Exception)
			{
                Console.WriteLine("Incorrectly entered number");
            }
        }
    }
}
