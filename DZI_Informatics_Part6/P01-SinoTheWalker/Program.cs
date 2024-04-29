public class Program
{
    static void Main()
    {
        int[] time = Console.ReadLine().Split(":").Select(int.Parse).ToArray();
        TimeOnly timeLeaves = new TimeOnly(time[0], time[1], time[2]);

        int steps = int.Parse(Console.ReadLine());
        int secPerStep = int.Parse(Console.ReadLine());

        int additionalTime = steps * secPerStep;
        timeLeaves.AddMinutes(additionalTime/60);
        double secs = additionalTime % 60.00;
        timeLeaves.AddMinutes(secs);
        Console.WriteLine(timeLeaves);
    }
}
