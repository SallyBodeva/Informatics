using System;
using System.Collections.Generic;
using System.Text;


public class Battleship : Vessel
{
    public Battleship(string name, double mainWeaponCaliber, double speed) : base(name, mainWeaponCaliber, speed, 300)
    {
    }
   
    public bool SonarMode { get; set; } = false;
}

