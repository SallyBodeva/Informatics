using System;
using System.Collections.Generic;
using System.Text;


public class Submarine : Vessel
{
    public Submarine(string name, double mainWeaponCaliber, double speed) : base(name, mainWeaponCaliber, speed, 200)
    {
    }

    public bool SubmergeMode { get; set; } = false;
    public void ToggleSubmergeMode()
    {
        if (this.SubmergeMode==false)
        {
            this.SubmergeMode = true;
            this.MainWeaponCaliber += 40;
            this.Speed -= 4;
        }
        else
        {
            this.SubmergeMode = false;
            this.MainWeaponCaliber -= 40;
            this.Speed += 4;
        }
    }
    public void RepairVessel()
    {
        this.ArmorThinkness = 200;
    }
    public override string ToString()
    {
        if (this.SubmergeMode)
        {
            return $"*Submerge mode: ON";
        }
        else
        {
            return $"*Submerge mode: OFF";
        }
    }
}

