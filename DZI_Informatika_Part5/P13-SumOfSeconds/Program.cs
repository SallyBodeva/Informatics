public class Program
{
    public static void Main()
    {
        int firstTime = int.Parse(Console.ReadLine());
        int secondTime = int.Parse(Console.ReadLine());
        int thirdTime = int.Parse(Console.ReadLine());

        int sum = firstTime+secondTime+thirdTime;

        int minutes = sum / 60;
        int secs = sum % 60;

        Console.WriteLine($"{minutes}:{secs.ToString("00")}");

    }
}
