using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;


public abstract class Vessel
{
    private string name;
    private Captain captain;

    protected Vessel(string name,double mainWeaponCaliber, double speed, double armorThinkness)
    {
        this.Name = name;
        this.MainWeaponCaliber = mainWeaponCaliber;
        this.Speed = speed;
        this.ArmorThinkness = armorThinkness;
    }

    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Vessel name cannot be null or empty.");
            }
            name = value;
        }
    }
    public Captain Captain
    {
        get { return captain; }
        set
        {
            if (value==null)
            {
                throw new NullReferenceException("Captain cannot be null.");
            }
            captain = value;
        }
    }

    public double MainWeaponCaliber  { get; set; }

    public double Speed  { get; set; }

    public double ArmorThinkness { get; set; }

    public List<string> Targets  { get; set; }

    public void Attack(Vessel target)
    {
        if (target==null)
        {
            throw new NullReferenceException("Target cannot be null.");
        }
        target.ArmorThinkness -= this.MainWeaponCaliber;
        if ((target.ArmorThinkness -= this.MainWeaponCaliber)<0)
        {
            target.ArmorThinkness = 0;
        }
        this.Targets.Add(target.Name);
    }
    public void RepairVessel()
    {
        this.ArmorThinkness = default;
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"- {this.Name}");
        sb.AppendLine($"* Type: {GetType().Name}");
        sb.AppendLine($"*Armor thickness: {this.ArmorThinkness}");
        sb.AppendLine($"*Main weapon caliber: {this.MainWeaponCaliber}");
        sb.AppendLine($"*Speed: {this.Speed} knots");
        sb.Append("* Targets: \" – ");
        if (this.Targets.Any())
        {
            string targetsInfo = string.Join(", ",Targets);
            sb.AppendLine(targetsInfo);
        }
        else
        {
            sb.AppendLine("None");
        }
        return sb.ToString().TrimEnd();
    }
}