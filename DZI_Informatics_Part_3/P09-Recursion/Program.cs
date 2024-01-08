namespace P09_Recursion
{
    internal class Program
    {
        static void Main()
        {
            //TODO
        }
        public static int Factorial(int n)
        {
            int factorial = 0;
            if (n==1)
            {
                return 1;
            }
            return n*Factorial(n - 1);
        }
        public static string ReturnN(int n)
        {
            if (n==1)
            {
                return "1";
            }
            return n + " "+ $"{ReturnN(n-1)}";
        }

    }
}
