using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;

public class StackOfStrings:Stack<string>
{
    public bool isEmpty()
    {
        if (base.Count<1)
        {
            return true;
        }
        return false;
    }
    public Stack<string> AddRange(Stack<string> elements)
    {
        while (elements.Count>0)
        {
            base.Push(elements.Peek());
            elements.Pop();
        }
        return elements;
    }
}

