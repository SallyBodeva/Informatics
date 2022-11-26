using System;
using System.Collections.Generic;
using System.Text;


public class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Employee()
    {
        this.Name = "No name";
        this.Age = 1;
    }
    public Employee(int age)
    {
        this.Name = "No name";
        this.Age = age;
    }
    public Employee(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }
    public override string ToString()
    {
        return $"{this.Name}-{this.Age}";
    }
}

