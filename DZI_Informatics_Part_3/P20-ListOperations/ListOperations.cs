using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P20_ListOperations
{
    public static  class ListOperations
    {
        public static string Print(List<string> list, string separator=", ")
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < list.Count-1; i++)
            {
                sb.Append($"{list[i]}{separator}");
            }
            sb.Append(list[list.Count - 1]);
            return sb.ToString().TrimEnd();
        }
        private static void ChangeList2()
        {
            List<int> nums = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            string[] commands;
            while (true)
            {
                commands = Console.ReadLine().Split(" ");
                string operation = commands[0];
                if (operation == "End")
                {
                    break;
                }
                switch (operation)
                {
                    case "Add":
                        nums.Add(int.Parse(commands[1]));
                        break;

                    case "Insert":
                        int element = int.Parse(commands[1]);
                        int index = int.Parse(commands[2]);
                        nums.Insert(index, element);
                        break;
                    case "Remove":
                        int indexR = int.Parse(commands[1]);
                        nums.RemoveAt(indexR);
                        break;
                    case "Shift left":
                        int count = int.Parse(commands[2]);
                        for (int i = 0; i < count; i++)
                        {
                            int firstElement = nums[0];
                            nums.RemoveAt(0);
                            nums.Add(firstElement);
                        }
                        break;
                    case "Shift rigth":
                        int countR = int.Parse(commands[2]);
                        for (int i = 0; i < countR; i++)
                        {
                            int lastElement = nums[nums.Count - 1];
                            nums.RemoveAt(nums.Count - 1);
                            nums.Insert(0, lastElement);
                        }
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", nums));
        }

        private static void ChangeList()
        {
            List<int> nums = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            string[] commands;
            while (true)
            {
                commands = Console.ReadLine().Split(" ");
                string operation = commands[0];
                if (operation == "end")
                {
                    break;
                }
                switch (operation)
                {
                    case "Delete":
                        while (nums.Contains(int.Parse(commands[1])))
                        {
                            nums.Remove(int.Parse(commands[1]));
                        }
                        break;

                    case "Insert":
                        int element = int.Parse(commands[1]);
                        int index = int.Parse(commands[2]);
                        nums.Insert(index, element);
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
