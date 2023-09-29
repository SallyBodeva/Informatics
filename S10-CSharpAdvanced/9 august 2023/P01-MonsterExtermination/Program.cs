using System;
using System.Collections.Generic;
using System.Linq;


public class Program
{
    static void Main()
    {
        Queue<int> armorMonsters = new Queue<int>(Console.ReadLine().Split(",").Select(int.Parse).ToArray());
        Stack<int> strikingImpact = new Stack<int>(Console.ReadLine().Split(",").Select(int.Parse).ToArray());

        int initialMonstersCount = armorMonsters.Count;
        while (armorMonsters.Count != 0 && strikingImpact.Count != 0)
        {
            int armomFirst = armorMonsters.Peek();
            int strikeLast = strikingImpact.Peek();
            if (strikeLast >= armomFirst)
            {
                armorMonsters.Dequeue();
                strikeLast -= armomFirst;
                strikingImpact.Pop();
                if (strikeLast != 0)
                {
                    int lastStackValue = strikingImpact.Pop();
                    lastStackValue += strikeLast;
                    strikingImpact.Push(lastStackValue);
                }
            }
            else
            {
                strikingImpact.Pop();
                int firstMonsterImpact = armorMonsters.Dequeue();
                armorMonsters.Enqueue(firstMonsterImpact -= strikeLast);
            }
        }
        if (armorMonsters.Count == 0)
        {
            Console.WriteLine($"All monsters have been killed!");
            Console.WriteLine($"Total monsters killed: {initialMonstersCount}");
        }
        else
        {
            Console.WriteLine($"The soldier has been defeated.");
            Console.WriteLine($"Total monsters killed: {initialMonstersCount - armorMonsters.Count}");
        }
    }
}