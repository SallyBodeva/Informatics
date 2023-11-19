using System;
using System.Collections.Generic;
using System.Text;


public class Submarine : Vessel
{
    public Submarine(string name, double mainWeaponCaliber, double speed) : base(name, mainWeaponCaliber, speed, 200)
    {
    }

    public bool SubmergeMode { get; set; } = false;
}

