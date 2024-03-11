namespace P06_Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
                string number = Console.ReadLine();
				int n = int.Parse(number);
                if (n<0)
                {
                    throw new Exception();
                }
                Console.WriteLine(number);

                string reversedNum = new string(number.Reverse().ToArray());
                if (number==reversedNum)
                {
                    Console.WriteLine("yes");
                }

                //char[] array = new char[number.Length];
                //int insertIndex = 0;
                //for (int i = number.Length - 1; i >= 0; i--)
                //{
                //    array[insertIndex] = number[i];
                //    insertIndex++;
                //}
                //string reversedNumver = string.Join("", array);
                //if (number == reversedNumver)
                //{
                //    Console.WriteLine($"{number} is a palindrome");
                //}
                //else
                //{
                //    Console.WriteLine($"{number} is not a palindrome");
                //}
            }
            catch (Exception)
			{
                Console.WriteLine("Incorrectly entered number");
            }
        }
    }
}

