using System;
using System.Collections.Generic;
using System.Text;

public class StationaryPhone:IStationaryPhone
{
    public StationaryPhone(string phoneNum)
    {
        this.PhoneNum = phoneNum;
    }

    public string PhoneNum { get; set; }
    public void Calling()
    {
        Console.WriteLine($"Dialing... {this.PhoneNum}");
    }
}

