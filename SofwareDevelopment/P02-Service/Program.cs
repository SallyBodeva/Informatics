using P02_Service.Data;
using System.Linq;
namespace P02_Service
{
    public class Program
    {
        private static AppDbContext context = new AppDbContext();
        static void Main()
        {
            GetUnassignedReports();
            GetReportsCategories();
            GetMostReportedCategory();
            GetBirthdayReport();
        }

        private static void GetBirthdayReport()
        {
            var result = context.Reports
                            .Where(x => x.OpenDate.Day == x.User.Birthdate.Value.Day &&
                            x.OpenDate.Month == x.User.Birthdate.Value.Month)
                            .OrderBy(x => x.User.UserName).ThenBy(x => x.Category.Name)
                            .Select(x => $"{x.User.UserName} {x.Category.Name}");

            Console.WriteLine(string.Join(Environment.NewLine, result));
        }

        private static void GetMostReportedCategory()
        {
            var result = context.Categories.Take(5)
                .Where(x => x.Reports.Any())
                .Select(x =>
                    new
                    {
                        Name = x.Name,
                        ReportsNum = x.Reports.Count()
                    }).OrderByDescending(x => x.ReportsNum).ThenBy(x => x.Name);
            foreach (var r in result)
            {
                Console.WriteLine($"{r.Name} {r.ReportsNum}");
            }
        }

        private static void GetReportsCategories()
        {
            var result = context.Reports
                .Where(x => x.CategoryId != null)
                .OrderBy(x => x.Description).ThenBy(x => x.Category.Name)
                .Select(x => $"{x.Description} {x.Category.Name}").ToList();

            Console.WriteLine(string.Join(Environment.NewLine, result));
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
