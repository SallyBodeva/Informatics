using System;
using System.Collections.Generic;
using System.Text;


public class Citizen:IVistitors
{
    public Citizen(string name, int age, string id, string birthday)
    {
        this.Name = name;
        this.Age = age;
        this.Id = id;
        Birthday = birthday;
    }

    public string Name { get; private set; }
    public int Age { get; private set; }
    public string Id { get;  set; }
    public string Birthday { get; set; }
}

