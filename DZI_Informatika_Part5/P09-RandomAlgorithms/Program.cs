public class Program
{
    static void Main()
    {
     
    }
    public static int CalculateCombination(int n, int k)
    {
        if (k == 0 || k == n)
        {
            return 1; // Base case: combination is 1 if k is 0 or equal to n
        }
        else if (k > n)
        {
            return 0; // Base case: combination is 0 if k is greater than n
        }
        else
        {
            // Recursive formula for combination: C(n, k) = C(n-1, k-1) + C(n-1, k)
            return CalculateCombination(n - 1, k - 1) + CalculateCombination(n - 1, k);
        }
    }
}





