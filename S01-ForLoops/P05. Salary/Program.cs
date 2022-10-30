using System;


public class Program
{
    static void Main()
    {
        int sites = int.Parse(Console.ReadLine());
        double salary = double.Parse(Console.ReadLine());
        for (int i = 1; i <= sites; i++)
        {
            string website = Console.ReadLine();
            switch (website)
            {
                case "Facebook":
                    salary -= 150;
                    break;
                case "Instagram":
                    salary -= 100;
                    break;
                case "Reddit":
                    salary -= 50;
                    break;
            }
            if (salary<=0)
            {
                Console.WriteLine("You have lost your salary.");
                break;
            }
        }
        if (salary>0)
        {
            Console.WriteLine(salary);
        }
       
    }
}

