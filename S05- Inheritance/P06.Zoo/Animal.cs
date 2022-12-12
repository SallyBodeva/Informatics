using System;
using System.Collections.Generic;
using System.Text;


public class Animal
{
    public Animal(string name)
    {
        this.Name = name;
    }

    public string Name { get; set; }

    public override string ToString()
    {
        return $"{GetType().Name}'s name: {this.Name}";
    }
}

