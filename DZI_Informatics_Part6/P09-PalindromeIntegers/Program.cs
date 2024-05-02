public class Program
{
    static void Main()
    {
        while (true)
        {
            string number = Console.ReadLine();
            if (number=="END")
            {
                break;
            }
            string newReversedNum = new string(number.Reverse().ToArray());
            if (number == newReversedNum) { Console.WriteLine(true);  }
            else { Console.WriteLine(false); }
        }

    }
}
