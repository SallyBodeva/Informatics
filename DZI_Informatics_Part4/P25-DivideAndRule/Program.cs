using System.Globalization;

namespace P25_DivideAndRule
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Period> periods = new List<Period>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(',');
                if (input[0]=="P")
                {
                    DateTime startDate = DateTime.ParseExact(input[1], "yyyy-MM-dd", CultureInfo.InvariantCulture);
                    DateTime endDate = DateTime.ParseExact(input[2], "yyyy-MM-dd", CultureInfo.InvariantCulture);
                    double price = double.Parse(input[3]);
                    Period p = new Period(startDate, endDate) { Price=price};
                    periods.Add(p);
                }
                else if (input[0] == "Q")
                {
                    DateTime startTime = DateTime.ParseExact(input[1], "yyyy-MM-dd'T'HH:mm:sszzz", CultureInfo.InvariantCulture);
                    DateTime endTime = DateTime.ParseExact(input[2], "yyyy-MM-dd'T'HH:mm:sszzz", CultureInfo.InvariantCulture);
                    double quantity = double.Parse(input[3]);

                    DistributeQuantity(periods, startTime, endTime, quantity);
                }
            }
            static void DistributeQuantity(List<Period> periods, DateTime startTime, DateTime endTime, double quantity)
            {
                var relevantPeriods = periods.Where(p => p.StartDate <= startTime && p.EndDate >= endTime).ToList();

                double totalDays = (endTime - startTime).TotalDays;

                foreach (var period in relevantPeriods)
                {
                    double daysInPeriod = (period.EndDate - period.StartDate).TotalDays;
                    double proportion = daysInPeriod / totalDays;
                    double distributedQuantity = quantity * proportion;
                    period.Quantity += distributedQuantity;
                }
            }
        }
    }
    public class Period
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }
        public Period(DateTime startDate, DateTime endDate)
        {
            StartDate = startDate;
            EndDate = endDate;
        }
    }

}
