using System;


public class StartUp
{
    static void Main(string[] args)
    {
        Employee em1 = new Employee();
        em1.Name = "John";
        em1.Age = 20;
        em1.Name = "Joy";
        em1.Age = 18;
        em1.Name = "Tommy";
        em1.Age = 43;
    }
}
public class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
}


