using P02_Service.Data;

namespace P02_Service
{
    public class Program
    {
        private static AppDbContext context = new AppDbContext();
        static void Main()
        {
            GetUnassignedReports();
        }

        private static void GetUnassignedReports()
        {
            var result = context.Reports
                 .Where(x => x.EmployeeId == null).OrderBy(x => x.OpenDate).ThenBy(x => x.Description)
                 .Select(x => $"{x.Description} {x.OpenDate.ToString("dd-MM-yyyy")}")
                 .ToList();

            Console.WriteLine(string.Join(Environment.NewLine, result));
        }
    }
}
