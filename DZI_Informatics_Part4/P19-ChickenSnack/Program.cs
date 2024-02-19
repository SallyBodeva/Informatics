namespace P19_ChickenSnack
{
    public class Program
    {
        static void Main()
        {
            int[] money = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] prices = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int mealsCount = 0;

            Stack<int> stackMoney = new Stack<int>(money);
            Queue<int> queuePrices = new Queue<int>(prices);

            while (stackMoney.Count!=0 && queuePrices.Count!=0)
            {
                int lastMoney = stackMoney.Pop();
                int firstPrice = queuePrices.Dequeue();

                if (lastMoney==firstPrice)
                {
                    mealsCount++;
                }
                else if(lastMoney>firstPrice)
                {
                    mealsCount++;
                    int diff = lastMoney - firstPrice;
                    if (stackMoney.Count>0) { stackMoney.Pop(); }
                    stackMoney.Push(lastMoney + diff);
                }
            }
            if (mealsCount>=4)
            {
                Console.WriteLine($"Gluttony of the day! Henry ate {mealsCount} foods.");
            }
            else if (queuePrices.Any())
            {
                Console.WriteLine($"Henry ate: {mealsCount} foods.");
            }
            else if (mealsCount > 1)
            {
                Console.WriteLine($"Henry ate: {mealsCount} foods.");
            }
            else if (mealsCount==1)
            {
                Console.WriteLine($"Henry ate: {mealsCount} food.");
            }
            else
            {
                Console.WriteLine("Henry remained hungry. He will try next weekend again.");
            }
        }
    }
}

