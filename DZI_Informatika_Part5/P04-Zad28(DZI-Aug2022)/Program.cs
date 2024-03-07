namespace P04_Zad28_DZI_Aug2022_
{
    internal class Program
    {
        static void Main()
        {
            string rallyName = Console.ReadLine();
            int year = int.Parse(Console.ReadLine());

            Rally r = new Rally(rallyName, year);
            string cmd = string.Empty;
            while ((cmd = Console.ReadLine()) != "q")
            {
                switch (cmd)
                {
                    case "a":
                        string pilotName = Console.ReadLine();
                        int age = int.Parse(Console.ReadLine());
                        string category = Console.ReadLine();
                        string carModel = Console.ReadLine();
                        int hPower = int.Parse(Console.ReadLine());
                        Car c = new Car(carModel, hPower);
                        Pilot p = new Pilot(pilotName, age, c, category);
                        r.AddPilot(p);
                        break;
                    case "v":
                        Console.WriteLine(r.ToString());
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
