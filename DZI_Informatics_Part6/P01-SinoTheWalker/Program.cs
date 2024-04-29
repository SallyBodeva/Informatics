public class Program
{
    static void Main()
    {
        int[] time = Console.ReadLine().Split(":").Select(int.Parse).ToArray();

        int steps = int.Parse(Console.ReadLine());
        int secPerStep = int.Parse(Console.ReadLine());

        int minutes = (steps * secPerStep) / 60;
        int secs = (steps * secPerStep) % 60;

        if ((time[1] + minutes)>=60)
        {
            time[0] += 1;
            time[1] = (time[1] + minutes) % 60;
        }
        else
        {
            time[1] += minutes;
        }
        if ((time[2] + secs) >= 60)
        {
            time[1] += 1;
            time[2] = (time[2] + secs) % 60;
        }
        else
        {
            time[2] += minutes;
        }
        Console.WriteLine($"{time[0]}:{time[1]}:{time[2].ToString("00")}");
    }
}
