using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;


public abstract class Plant
{
    private string name;
    private string type;
    private double humidityLevel;
    private double fertilityLevel;

    protected Plant(int id,string name, string type, double humidityLevel, double fertilityLevel)
    {
        this.Id = id;
        this.Name = name;
        this.Type = type;
        this.HumidityLevel = humidityLevel;
        this.FertilityLevel = fertilityLevel;
    }

    public int Id { get; set; }

    public string Name
    {
        get { return name; }
        set
        {
            if (value.Length < 3 || value.Length > 30)
            {
                throw new ArgumentException("Name should be between 3 and 30 characters!");
            }
            name = value;
        }
    }
    public string Type
    {
        get { return type; }
        set
        {
            if (value.Length < 3 || value.Length > 30)
            {
                throw new ArgumentException("Type should be between 3 and 30 characters!");
            }
            type = value;
        }
    }
    public List<CareItem> CareItems { get; set; } = new List<CareItem>();
    public double HumidityLevel
    {
        get { return humidityLevel; }
        set
        {
            if (value < 0 || value > 1)
            {
                throw new ArgumentException("Humidity Level should be between 0 and 1!");
            }
            humidityLevel = value;
        }
    }
    public double FertilityLevel
    {
        get { return fertilityLevel; }
        set
        {
            if (value < 0 || value > 1)
            {
                throw new ArgumentException("Fertility Level should be between 0 and 1!");
            }
            fertilityLevel = value;
        }
    }
    public void AddCareItem(CareItem careItem)
    {
        this.CareItems.Add(careItem);
    }
    public int TotalCaresDone()
    {
        return this.CareItems.Count(x => x.Status == true);
    }
    public bool Water(double percent)
    {
        if (this.HumidityLevel+percent<1)
        {
            this.HumidityLevel += percent;
            return true;
        }
        return false;
    }
    public bool Fertilize(double percent)
    {
        if (this.FertilityLevel + percent < 1)
        {
            this.FertilityLevel += percent;
            return true;
        }
        return false;
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Id: {Id}");
        sb.AppendLine($"Name: {Name}");
        sb.AppendLine($"Type: {Type}");
        sb.AppendLine($"Humidity Level: {HumidityLevel:f2} %");
        sb.AppendLine($"Fertility Level: {FertilityLevel:f2} %");
        return sb.ToString().TrimEnd();
    }
}