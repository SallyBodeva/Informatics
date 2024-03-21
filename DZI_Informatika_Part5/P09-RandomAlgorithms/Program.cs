public class Program
{
    static void Main()
    {
     
    }
    public static int CalculateCombination(int n, int k)
    {
        if (k == 0 || k == n)
        {
            return 1; 
        }
        else if (k > n)
        {
            return 0; 
        }
        else
        {
            return CalculateCombination(n - 1, k - 1) + CalculateCombination(n - 1, k);
        }
    }
}





