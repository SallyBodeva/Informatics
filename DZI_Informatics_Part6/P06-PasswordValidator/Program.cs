public class Program
{
    static void Main()
    {
        string password = Console.ReadLine();
        bool isValid = true;
        if (password.Length < 6 || password.Length > 10)
        {
            Console.WriteLine("Password must be between 6 and 10 characters");
            isValid = false;
        }
        if (password.Any(x => !char.IsDigit(x) && !char.IsLetter(x)))
        {
            Console.WriteLine("Password must consist only of letters and digits");
            isValid = false;
        }
        if (password.Count(x => char.IsDigit(x)) < 2)
        {
            Console.WriteLine("Password must have at least 2 digits");
            isValid = false;
        }
        if (isValid)
        {
            Console.WriteLine("Password is valid");
        }
    }
}
