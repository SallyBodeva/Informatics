public class Program
{
    public static void Main()
    {
        int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        while (true)
        {
            string[] cmd = Console.ReadLine().Split(" ");
            switch (cmd[0])
            {
                case "exchange":
                    int index = int.Parse(cmd[1]);
                    if (index<0 && index>=array.Length)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        int[] firstHalf = array.Take(index + 1).ToArray();
                        int[] secondHalf = array.Skip(index + 1).ToArray();
                        int[] newArray = new int[array.Length];
                        Array.Copy(secondHalf, newArray,secondHalf.Length);
                        Array.Copy(firstHalf,0,newArray,firstHalf.Length-1,firstHalf.Length);
                        array = newArray;
                        Console.WriteLine(string.Join(" ",array));
                        break;
                    }
                    break;
                case "max":
                    string type = cmd[1];
                    if (type=="odd")
                    {
                        Console.WriteLine(Array.IndexOf(array,array.Where(x => x % 2 == 1).OrderByDescending(x => x).FirstOrDefault()));
                    }
                    else
                    {
                        Console.WriteLine(Array.IndexOf(array, array.Where(x => x % 2 == 0).OrderByDescending(x => x).FirstOrDefault()));
                    }
                    break;
                case "min":
                    type = cmd[1];
                    if (type == "odd")
                    {
                        Console.WriteLine(Array.IndexOf(array, array.Where(x => x % 2 == 1).OrderBy(x => x).FirstOrDefault()));
                    }
                    else
                    {
                        Console.WriteLine(Array.IndexOf(array, array.Where(x => x % 2 == 0).OrderBy(x => x).FirstOrDefault()));
                    }
                    break;
                case "first":
                    int count = int.Parse(cmd[1]);
                    type = cmd[2];
                    if (type == "odd")
                    {
                        Console.WriteLine(string.Join(" ",array.Where(x=>x%2==1).Take(count)));
                    }
                    else
                    {
                        Console.WriteLine(string.Join(" ", array.Where(x => x % 2 == 0).Take(count)));
                    }
                    break;
                case "last":
                    count = int.Parse(cmd[1]);
                    type = cmd[2];
                    Array.Reverse(array);
                    if (type == "odd")
                    {
                        Console.WriteLine(string.Join(" ", array.Where(x => x % 2 == 1).Take(count)));
                    }
                    else
                    {
                        Console.WriteLine(string.Join(" ", array.Where(x => x % 2 == 0).Take(count)));
                    }
                    Array.Reverse(array);
                    break;
                case "end":
                    Environment.Exit(0);
                    break;
                 
            }
        }
    }
}