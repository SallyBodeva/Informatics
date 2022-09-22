using System;
public class Program
{
    static void Main()
    {
        int joineryCount = int.Parse(Console.ReadLine());
        string typeJoinery = Console.ReadLine();
        string optionDelivery = Console.ReadLine();

        double sum = 0;
        if (joineryCount < 10)
        {
            Console.WriteLine("Invalid order");
        }
        else
        {
            switch (typeJoinery)
            {
                case "90X130":
                    sum += (joineryCount * 110);
                    if (joineryCount > 30 && joineryCount <= 60)
                    {
                        sum -= sum * 0.05;
                    }
                    if (joineryCount > 60)
                    {
                        sum -= sum * 0.08;
                    }
                    break;

                case "100X150":
                    sum += (joineryCount * 140);
                    if (joineryCount > 40 && joineryCount <= 80)
                    {
                        sum -= sum * 0.06;
                    }
                    if (joineryCount > 80)
                    {
                        sum -= sum * 0.1;
                    }
                    break;

                case "130X180":
                    sum += (joineryCount * 190);
                    if (joineryCount > 20 && joineryCount <= 50)
                    {
                        sum -= sum * 0.07;
                    }
                    if (joineryCount > 50)
                    {
                        sum -= sum * 0.12;
                    }
                    break;
                case "200X300":
                    sum += (joineryCount * 250);
                    if (joineryCount > 25 && joineryCount <= 50)
                    {
                        sum -= sum * 0.09;
                    }
                    if (joineryCount > 50)
                    {
                        sum -= sum * 0.14;
                    }
                    break;
            }
            if (optionDelivery == "With delivery")
            {
                sum += 60;
            }
            if (joineryCount > 99)
            {
                sum -= sum * 0.04;
            }
           
            else if (optionDelivery == "Without delivery")
            {

            }
            Console.WriteLine($"{sum:f2} BGN");
        }
      
    }
}

