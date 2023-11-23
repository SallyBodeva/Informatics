using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;


public class Captain
{
    private string fullName;

    public Captain(string fullName)
    {
        this.FullName = fullName;
    }

    public string FullName
    {
        get { return fullName; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Captain full name cannot be null or empty string.");
            }
            fullName = value;
        }
    }

    public int CombatExperience { get; set; } = 0;

    public List<Vessel> Vessels { get; set; }

    public void AddVessel(Vessel vessel)
    {
        if (vessel == null)
        {
            throw new NullReferenceException("Null vessel cannot be added to the captain.");
        }
        this.Vessels.Add(vessel);
    }
    public void IncreaseCombatExperience()
    {
        this.CombatExperience += 10;
    }
    public string Report()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"{FullName} has {CombatExperience} combat experience and commands {this.Vessels.Count} vessels.");
        if (this.Vessels.Any())
        {
            foreach (var v in Vessels)
            {
                sb.AppendLine($"- {v.Name}");
                sb.AppendLine($"* Type: {v.GetType().Name}");
                sb.AppendLine($"*Armor thickness: {v.ArmorThinkness}");
                sb.AppendLine($"*Main weapon caliber: {v.MainWeaponCaliber}");
                sb.AppendLine($"*Speed: {v.Speed} knots");
                if (v.Targets.Any())
                {
                    sb.AppendLine($"* Targets: {string.Join(" ", v.Targets)}");
                }
                else
                {
                    sb.AppendLine("* Targets: None");
                }
                //*Sonar / Submerge mode: ON / OFF" 

            }
        }
        return sb.ToString().TrimEnd();
    }
}