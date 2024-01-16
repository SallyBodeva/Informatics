using System.Data;

namespace P15_DZIPomagalo
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        private static void GradeInfo()
        {
            int grade = int.Parse(Console.ReadLine());
            switch (grade)
            {
                case 2:
                    Console.WriteLine("Слаб");
                    break;
                case 3:
                    Console.WriteLine("Среден");
                    break;
                case 4:
                    Console.WriteLine("Добър");
                    break;
                case 5:
                    Console.WriteLine("Много добър");
                    break;
                case 6:
                    Console.WriteLine("Отличен");
                    break;
                default:
                    Console.WriteLine("невалидна оценка");
                    break;
            }
        }

        private static void Coordinates()
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if (x == 0)
            {
                Console.WriteLine("V");
            }
            if (y == 0)
            {
                Console.WriteLine("H");
            }
            if (x > 0 && y > 0) Console.WriteLine("I");
            if (x < 0 && y > 0) Console.WriteLine("II");
            if (x < 0 && y < 0) Console.WriteLine("III");
            if (x > 0 && y < 0) Console.WriteLine("IV");
        }

        private static void AfterOneSec()
        {
            int hh = int.Parse(Console.ReadLine());
            int MM = int.Parse(Console.ReadLine());
            int ss = int.Parse(Console.ReadLine());

            TimeOnly time = new TimeOnly(hh, MM, ss);

            //TimeOnly newTime = time.AddSeconds(1);
            //Console.WriteLine(newTime.ToString("hh,MM,ss"));
        }

        private static void AfterOneSecWithInts()
        {
            int hh = int.Parse(Console.ReadLine());
            int MM = int.Parse(Console.ReadLine());
            int ss = int.Parse(Console.ReadLine());
            if (hh > 23 || MM > 59 || ss > 59)
            {
                Console.WriteLine("Invalid data");
            }
            ss += 1;
            if (ss == 60)
            {
                ss = 00;
                MM++;
                if (MM == 60)
                {
                    MM = 00;
                    hh++;
                }
                if (hh > 23)
                {
                    hh = 00;
                }
            }

            Console.WriteLine($"{hh.ToString("00")} {MM.ToString("00")} {ss.ToString("00")}");
        }

        private static void WallsCovering()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            int wallArea = a * b;
            int tileArea = c * d;

            int neededTiles = wallArea / tileArea;
            Console.WriteLine(neededTiles);
        }
    }
}
