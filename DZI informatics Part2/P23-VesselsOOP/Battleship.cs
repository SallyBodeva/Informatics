using System;
using System.Collections.Generic;
using System.Text;


public class Battleship : Vessel
{
    public Battleship(string name, double mainWeaponCaliber, double speed) : base(name, mainWeaponCaliber, speed, 300)
    {
    }
   
    public bool SonarMode { get; set; } = false;
    public void ToggleSonarMode()
    {
        if (SonarMode==false)
        {
            this.SonarMode = true;
            this.MainWeaponCaliber += 40;
            this.Speed -= 5;
        }
        else
        {
            this.SonarMode = false;
            this.MainWeaponCaliber -= 40;
            this.Speed += 5;
        }
    }
    public override string ToString()
    {
        if (SonarMode)
        {
            return $"*Sonar mode: ON";
        }
        else
        {
            return $"*Sonar mode: OFF";
        }
    }
    public void RepairVessel()
    {
        this.ArmorThinkness = 300;
    }
}

