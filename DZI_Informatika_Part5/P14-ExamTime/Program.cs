
public class Program
{
    public static void Main()
    {
        int examHour = int.Parse(Console.ReadLine());
        int examMinutes = int.Parse(Console.ReadLine());

        TimeOnly exam = new TimeOnly(examHour, examMinutes);

        int studentHour = int.Parse(Console.ReadLine());
        int studentMinutes = int.Parse(Console.ReadLine());

        TimeOnly studentArrival = new TimeOnly(studentHour, studentMinutes);

        if (exam<studentArrival)
        {
            Console.WriteLine("Late");
            int diff = (exam - studentArrival).Minutes;
            Console.WriteLine(diff);
        }
        else if (exam==studentArrival)
        {
            Console.WriteLine("On time");
        }
        else
        {
            Console.WriteLine("On time");
            int diff = (studentArrival - exam).Minutes;
            Console.WriteLine(diff);
        }
    }

}