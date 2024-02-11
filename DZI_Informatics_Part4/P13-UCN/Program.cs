namespace P13_UCN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string UCN = Console.ReadLine();

            string gender = (UCN[8] % 2 == 0) ? "Man" : "Woman";

            int dateOfBirth = int.Parse(UCN.Substring(4, 2));
            int monthOfBirth = int.Parse( UCN.Substring(2, 2));
            string yearOfBirth = string.Empty;
            if (monthOfBirth>40)
            {
                yearOfBirth = "20" + UCN.Substring(0, 2);
                monthOfBirth -= 40;
            }
            if (monthOfBirth>20 && monthOfBirth<40)
            {
                yearOfBirth = "19" + UCN.Substring(4, 2);
                monthOfBirth -= 20;
            }
            DateTime birtdate = new DateTime(int.Parse(yearOfBirth), monthOfBirth, dateOfBirth);
            Console.WriteLine($"{gender} is born on" +
                $" {dateOfBirth.ToString("00")}/{monthOfBirth.ToString("00")}/{yearOfBirth} " +
                $"and is {DateTime.UtcNow.Year-birtdate.Year} years old");

        }
    }
}
