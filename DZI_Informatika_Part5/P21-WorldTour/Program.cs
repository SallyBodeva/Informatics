public class Program
{
    public static void Main()
    {
        string stops = Console.ReadLine();
        while (true)
        {
            string[] input = Console.ReadLine().Split(":");
            if (input[0] == "Travel")
            {
                Console.WriteLine($"Ready for world tour! Planned stops: {stops}");
                Environment.Exit(0);
            }

            string command = input[0];
            switch (command)
            {
                case "Add Stop":
                    int index = int.Parse(input[1]);
                    string location = input[2];
                    if (index >= 0 && index < stops.Length)
                    {
                        stops = stops.Insert(index, location);
                    }
                    Console.WriteLine(stops);
                    break;

                case "Remove Stop":
                    int startIndex = int.Parse(input[1]);
                    int endIndex = int.Parse(input[2]);
                    if (startIndex >= 0 && endIndex < stops.Length && startIndex <= endIndex)
                    {
                       stops = stops.Remove(startIndex, (endIndex - startIndex) + 1);
                    }
                    Console.WriteLine(stops);
                    break;
                case "Switch":
                    string oldLocation = input[1];
                    string newLocation = input[2];
                    stops = stops.Replace(oldLocation, newLocation);
                    Console.WriteLine(stops);
                    break;

            }

        }
    }
}
