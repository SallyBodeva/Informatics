public class Program
{
    static void Main()
    {
        int[] nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        while (true)
        {
            string[] input = Console.ReadLine().Split(" ");
            string cmd = input[0];
            switch (cmd)
            {
                case "swap":
                    int index1 = int.Parse(input[1]);
                    int index2 = int.Parse(input[2]);

                    int firstElement = nums[index1];
                    nums[index1]= nums[index2];
                    nums[index2] = firstElement;
                    break;
                case "multiply":
                     index1 = int.Parse(input[1]);
                     index2 = int.Parse(input[2]);

                    nums[index1] *= nums[index2];
                    break;
                case "decrease":
                    for (int i = 0; i < nums.Length; i++)
                    {
                        nums[i] = nums[i] - 1;
                    }
                    break;
                case "end":
                    Console.WriteLine(string.Join(", ",nums));
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
