using System;
using System.Collections.Generic;

public class Program
{
    static void Main()
    {
        StackOfStrings stackOfStrings = new StackOfStrings();
        Console.WriteLine(stackOfStrings.isEmpty());
        Stack<string> fullStack = new Stack<string>();
        fullStack.Push("sb");
        fullStack.Push("sab");
        stackOfStrings.AddRange(fullStack);
        Console.WriteLine(stackOfStrings.isEmpty());
         
    }
}

