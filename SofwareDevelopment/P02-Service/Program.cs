using P02_Service.Data;

namespace P02_Service
{
    public class Program
    {
        private static AppDbContext context = new AppDbContext();
        static void Main()
        {
            //var result = context.Reports.Take(5).Select(x =>
            //new
            //{
            //    CategoryName = x.Category.Name,
            //    Count = y=>y.S
            //}).OrderByDescending(x => x.Count).OrderBy(x => x.CategoryName);
            //Console.WriteLine(string.Join(Environment.NewLine,result));

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
