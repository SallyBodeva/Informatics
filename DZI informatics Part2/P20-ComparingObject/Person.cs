using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

public class Person:IComparable<Person>
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Town { get; set; }

    public int CompareTo([AllowNull] Person other)
    {
        int nameComparisson = string.Compare(this.Name, other.Name);
        if (nameComparisson==0 && this.Age == other.Age && string.Compare(this.Town, other.Town) == 0)
        {
            return 0;
        }
        else if (this.Age>other.Age || (string.Compare(this.Town, other.Town) == 1))
        {
            return 1;
        }
        else 
        {
            return -1;
        }

    }
}