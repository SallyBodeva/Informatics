namespace P24_zad_26_DZI_26._8_22_
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Human> humans = new List<Human>();
            Human h = null;
            for (int i = 0; i < n; i++)
            {
                Console.Write($"First name: ");
                string firstName = Console.ReadLine();
                Console.Write($"Last name: ");
                string lastName = Console.ReadLine();
                Console.Write($"Age: ");
                int  age = int.Parse(Console.ReadLine());
                Console.Write($"Your choice[s - student] , [w - worker]: ");
                char type = char.Parse(Console.ReadLine());
                switch (type)
                {
                    case 's':
                        Console.Write($"Grade: ");
                        double grade = double.Parse(Console.ReadLine());
                        h = new Student(firstName, lastName, age, grade);
                        humans.Insert(0,h);
                        break;
                    case 'w':
                        Console.Write($"Wage: ");
                        double wage = double.Parse(Console.ReadLine());
                        Console.Write($"Hours worked: ");
                        int hoursWorked = int.Parse(Console.ReadLine());
                        h = new Worker(firstName, lastName, age, wage, hoursWorked);
                        humans.Insert(0, h);
                        break;
                    default:
                        break;
                }
            }
            foreach (var human in humans)
            {
                Console.WriteLine(human.ToString());
            }
        }
    }
}
