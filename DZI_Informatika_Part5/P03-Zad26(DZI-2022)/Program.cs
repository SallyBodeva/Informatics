namespace P03_Zad26_DZI_2022_
{
    internal class Program
    {
        private static List<double> works = new List<double>();
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            ReadPoints(n);
            Console.WriteLine($"valid works - {works.Count}");
            Console.WriteLine($"minimal difference - {МinDpoints():f3} p.");
            Console.WriteLine($"laureates - {Laureates()}");
        }

        private static void ReadPoints(int n)
        {
            for (int i = 0; i < n; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade > 0)
                {
                    works.Add(grade);
                }

            }
        }
        private static double МinDpoints()
        {
            List<double> points = works.OrderByDescending(x => x).ToList();
            double minDiff = double.MaxValue;

            for (int i = 0; i < points.Count - 1; i++)
            {
                double diff = points[i] - points[i + 1];
                if (diff < minDiff && diff != 0)
                {
                    minDiff = diff;
                }
            }
            return minDiff;
        }
        private static int Laureates()
        {
            List<double> points = works.OrderByDescending(x => x).Distinct().Take(3).ToList();
            int count = 0;
            foreach (var item in works)
            {
                if (points.Contains(item))
                {
                    count++;
                }
            }
            return count;
        }
    }
}


