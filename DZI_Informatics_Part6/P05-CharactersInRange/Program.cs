public class Program
{
    public static void Main()
    {
        char firstSymbol = char.Parse(Console.ReadLine());
        char nextFirst = (char)((int)firstSymbol + 1);
        char secSymbol = char.Parse(Console.ReadLine());
        char nextSec = (char)((int)secSymbol + 1);
        if (nextFirst < secSymbol)
        {
            for (char i = nextFirst; i < secSymbol; i++)
            {
                Console.Write(i + " ");
            }
        }
        else
        {
            for (char i = nextSec; i < firstSymbol; i++)
            {
                Console.Write(i + " ");
            }
        }
       
    }
}
