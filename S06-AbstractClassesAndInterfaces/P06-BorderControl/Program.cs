using System;
using System.Collections.Generic;

public class Program
{
    static void Main()
    {

        IVistitors n = null;
        List<IVistitors> visitors = new List<IVistitors>();

        List<IVistitors> fakeVisitors = new List<IVistitors>();
        while (true)
        {
            string[] info = Console.ReadLine().Split(' ');
            if (info[0] == "End")
            {
                break;
            }
            if (info.Length == 3)
            {
                n = new Citizen(info[0], int.Parse(info[1]), info[2]);
            }
            else if (info.Length == 2)
            {
                n = new Robot(info[0], info[1]);
            }
            visitors.Add(n);
        }
        string fakeIds = Console.ReadLine();
        foreach (var visitor in visitors)
        {
            int lengthId = visitor.Id.Length;
            if (visitor.Id[lengthId - 1] == fakeIds[2] && visitor.Id[lengthId - 2] == fakeIds[1] && visitor.Id[lengthId - 3] == fakeIds[0] )
            {
                fakeVisitors.Add(visitor);
            }
        }
        foreach (var item in fakeVisitors)
        {
            Console.WriteLine(item.Id);
        }
    }
}

