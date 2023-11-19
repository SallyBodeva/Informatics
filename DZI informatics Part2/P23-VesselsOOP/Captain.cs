using System;
using System.Collections.Generic;
using System.Text;


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
}

