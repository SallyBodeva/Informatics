namespace P15_SortingAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(" ", SelectionSort(new int[] { 5, 0, 19, 2, 22, 109, 77 })));
        }
        public static int[] SelectionSort(int[] array)
        {
            int[] orderedList = new int[array.Length];
            Array.Copy(array, orderedList, array.Length); 

            for (int i = 0; i < orderedList.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < orderedList.Length; j++)
                {
                    if (orderedList[j] < orderedList[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = orderedList[minIndex];
                orderedList[minIndex] = orderedList[i];
                orderedList[i] = temp;
            }

            return orderedList;
        }

    }
}
