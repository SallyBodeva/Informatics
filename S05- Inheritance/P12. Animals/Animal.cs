using System;
using System.Collections.Generic;
using System.Text;


public class Animal
{
    public Animal(string name, int age, string gender)
    {
        this.Name = name;
        this.Age = age;
        this.Gender = gender;
    }

    public virtual void ProduceSound()
    {

    }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
    public override string ToString()
    {
        return "Cat \r\nTom 12 Male\r\n"; 
    }
}
    

