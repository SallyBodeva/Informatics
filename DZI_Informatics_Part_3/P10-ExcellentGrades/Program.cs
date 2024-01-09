namespace P10_ExcellentGrades
{
    public  class Program
    {
        static void Main()
        {
            int[] grades = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int excellentGradesCount = 0;
            foreach (var item in grades)
            {
                if (item==6)
                {
                    excellentGradesCount++;
                }
            }
            if (!grades.Any(x=>x==2))
            {
                Console.WriteLine(new string('*',excellentGradesCount));
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
