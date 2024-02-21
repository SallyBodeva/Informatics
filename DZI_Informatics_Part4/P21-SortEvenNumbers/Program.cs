namespace P21_SortEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] initialArray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int count = EvenNumCount(initialArray);
            int[] newArray = new int[count];
            FillTheArray(initialArray, newArray);
            Console.WriteLine(string.Join(" ",newArray));
            SelectionSort(newArray);
            Console.WriteLine(string.Join(" ", newArray));
        }

        public static int EvenNumCount(int[] array)
        {
            int evenNum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]%2==0)
                {
                    evenNum++;
                }
            }
            return evenNum;
        }
        public static void FillTheArray(int[]array,int[] newarray)
        {
            int insertIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]%2==0)
                {
                    newarray[insertIndex] = array[i];
                    insertIndex++;
                }
               
            }
        }
        public static void SelectionSort(int[] array)
        {
            int t = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int minIndex = 0;
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = array[minIndex];
                array[minIndex] = array[i];
                array[i] = temp;
            }

        }
    }
}
