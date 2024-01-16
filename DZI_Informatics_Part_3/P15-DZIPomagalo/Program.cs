using System.Data;

namespace P15_DZIPomagalo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AfterOneSec();
        }

        private static void AfterOneSec()
        {
            int hh = int.Parse(Console.ReadLine());
            int MM = int.Parse(Console.ReadLine());
            int ss = int.Parse(Console.ReadLine());

            TimeOnly time = new TimeOnly(hh, MM, ss);

            //TimeOnly newTime = time.AddSeconds(1);
            Console.WriteLine(newTime.ToString("hh,MM,ss"));
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
