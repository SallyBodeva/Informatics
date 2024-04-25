using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Village
{
	private string name;
	private string location;
	private List<Peasant> peasants;

	public Village(string name, string location)
	{
		this.Name = name;
		this.Location = location;
		peasants = new List<Peasant>();
	}

	public string Name
	{
		get { return name; }
		set
		{
			if (value.Length < 2 || value.Length > 40)
			{
				throw new ArgumentException("Name should be between 2 and 40 characters!");
			}
			name = value;
		}
	}
	public string Location
	{
		get { return location; }
		set
		{
			if (value.Length < 3 || value.Length > 45)
			{
				throw new ArgumentException("Location should be between 3 and 45 characters!");
			}
			location = value;
		}
	}
	public int Resource { get; set; }

	public void AddPeasant(Peasant peasant)
	{
		this.peasants.Add(peasant);
	}
	public int PassDay()
	{
		int productivitySum = this.peasants.Sum(x => x.Productivity);
		this.Resource += productivitySum;
		return productivitySum;
	}
	public List<Peasant> KillPeasants(int count)
	{
		List<Peasant> toKill = peasants.Take(count).ToList(); ;
		peasants.RemoveRange(0,count);
		return toKill;
	}
	public override string ToString()
	{
		StringBuilder sb = new StringBuilder();
		sb.AppendLine($"Village - {Name} ({Location})");
		sb.AppendLine($"Resources - {Resource}");
		sb.AppendLine($"Peasants – ({this.peasants.Count})");
		peasants.ForEach(x => sb.AppendLine(x.ToString()));
		return base.ToString();
	}
}

