
public class Program
{
    public static void Main()
    {
        int floors = int.Parse(Console.ReadLine());
        int rooms = int.Parse(Console.ReadLine());

        for (int i = floors; i > 0; i--)
        {
            for (int j = 0; j < rooms; j++)
            {
                string letter = i == floors ? "L" : i % 2 == 0 ? "A" : "O";

                Console.Write($"{letter}{i+1}{j} ");
            }
            Console.WriteLine( );
        }
    }
}
