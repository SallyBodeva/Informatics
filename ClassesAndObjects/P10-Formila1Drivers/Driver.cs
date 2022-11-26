using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

public class Driver
{
    public Driver(string name, int age, float totalTime, float speed)
    {
        this.Name = name;
        this.Age = age;
        this.TotalTime = totalTime;
        this.Speed = speed;
    }

    public string Name { get; private set; }
    public int Age { get; private set; }
    public float TotalTime { get; private set; }
    public float Speed { get; private set; }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"DriverName: {this.Name}");
        sb.AppendLine($"  DriverAge: {this.Age}");
        sb.AppendLine($"    Time: {this.TotalTime}");
        sb.AppendLine($"    Speed: {this.Speed}");
        return sb.ToString().TrimEnd();
    }
}

