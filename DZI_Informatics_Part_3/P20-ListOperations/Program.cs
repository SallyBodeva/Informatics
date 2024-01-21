namespace P20_ListOperations
{
    public class Program
    {
        static void Main()
        {

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

        private static void Train()
        {
            List<int> wagons = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            int maxPassengers = int.Parse(Console.ReadLine());
            string[] cmd;
            while (true)
            {
                cmd = Console.ReadLine().Split(" ");
                if (cmd[0] == "end")
                {
                    break;
                }
                if (cmd[0] == "Add")
                {
                    wagons.Add(int.Parse(cmd[1]));
                }
                else
                {
                    int passengers = int.Parse(cmd[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + passengers < maxPassengers)
                        {
                            wagons[i] += passengers;
                        }
                        else
                        {
                            //TODO

                        }
                    }
                }
            }
        }
    }
}
