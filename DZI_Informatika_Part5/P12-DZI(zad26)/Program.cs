namespace P12_DZI_zad26_
{
    public class Program
    {
        private static List<double> grades = new List<double>();
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            while (grades.Count!=n)
            {
                double grdae = double.Parse(Console.ReadLine());
                grades.Add(grdae);
            }
          
            List<double> validWorks = ReadPoints();
            Console.WriteLine($"valid works - {validWorks.Count}");
            Console.WriteLine($"minimal difference - {МinDpoints(validWorks):f3} p.");
            Console.WriteLine($"laureates - {Laureates(validWorks)}");
        }
        private static int Laureates(List<double> validGr)
        {
            List<double> maxThreee = validGr.OrderByDescending(x => x).Distinct().Take(3).ToList();
            int count = 0;
            foreach (var item in validGr)
            {
                if (maxThreee.Contains(item))
                {
                    count++;
                }
            }
            return count;
        }
        private static double МinDpoints(List<double> grades)
        {
            List<double> distinct = grades.OrderByDescending(x => x).Distinct().ToList();
            double minDiff = double.MaxValue;
            for (int i = 0; i < distinct.Count-1; i++)
            {
                double diff = distinct[i] - distinct[i + 1];
                if(diff<minDiff && diff!=0)
                {
                    minDiff = distinct[i] - distinct[i + 1];
                }
            }
            return minDiff;
        }
        private static List<double> ReadPoints()
        {
            return grades.Where(x => x > 0).ToList();
        }
        private static int GetCount()
        {
            int n = 0;
            while (true)
            {
                n = int.Parse(Console.ReadLine());
                if (n > 3 && n > 10000)
                {
                    break;
                }
            }
            return n;
        }
    }
}
