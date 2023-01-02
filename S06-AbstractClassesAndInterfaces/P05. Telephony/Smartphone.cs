using System;
using System.Collections.Generic;
using System.Text;


public class Smartphone:ISmartphone
{
    public Smartphone(string phoneNum)
    {
        this.PhoneNum = phoneNum;
    }
    public Smartphone()
    {

    }

    public string PhoneNum { get; set; }
    public string URL { get; set; }
    public void Calling()
    {
        Console.WriteLine($"Calling...{this.PhoneNum}");
    }
    public void Browsing()
    {
        Console.WriteLine($"Browsing: {this.URL}!");
    }
}

