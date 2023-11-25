using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Controller
{
	public Controller()
	{

	}
	private VesselRepository vessels;
	private List<Captain> captains;

	public string HireCaptain(string fullName)
	{
		Captain c = captains.FirstOrDefault(x => x.FullName == fullName);
		if (c!=null)
		{
			return $"Captain {fullName} is already hired.";
        }
		Captain newC = new Captain(fullName);
		captains.Add(newC);
		return $"Captain {fullName} is already hired.";
	}
	public string ProduceVessel(string name,string vesselType,double mainWeaponCaliber,double speed)
	{
		if (vessels.FindByName(name)!=null)
		{
			return $"{vesselType} vessel {name} is already manufactured.";
        }
		Vessel v = null;
		switch (vesselType)
		{
			case nameof(Battleship):
				v = new Battleship(name, mainWeaponCaliber, speed);
				break;
            case nameof(Submarine):
                v = new Submarine(name, mainWeaponCaliber, speed);
                break;
            default:
				return "Invalid vessel type.";
                break;
		}
		vessels.Add(v);
		return $"{vesselType} {name} is manufactured with the main weapon caliber of {mainWeaponCaliber} inches and a maximum speed of {speed} knots.";

    }
	//TODO
}

