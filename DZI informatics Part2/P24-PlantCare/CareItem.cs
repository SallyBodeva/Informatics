using System;
using System.Collections.Generic;
using System.Text;

public class CareItem
{
    private string name;

    public CareItem(string name, bool status)
    {
        this.Name = name;
        this.Status = status;
    }

    public string Name
    {
        get { return name; }
        set
        {
            if (value.Length<2 || value.Length>40)
            {
                throw new ArgumentException("Name should be between 2 and 40 characters!");
            }
            name = value;
        }
    }
    public bool Status { get; set; }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"CareItem {Name}");
        sb.AppendLine($"Status: {Status}");
        return base.ToString();
    }
}
