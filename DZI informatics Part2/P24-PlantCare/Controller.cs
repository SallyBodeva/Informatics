using System;
using System.Collections.Generic;
using System.Text;


public class Controller
{
    private Dictionary<int,Plant> plants = new Dictionary<int, Plant>();
    public string AddCareItem(List<string> args)
    {
        int plantId = int.Parse(args[0]);
        string name = args[1];
        bool status = bool.Parse(args[2]);
        Plant p = plants[plantId];
        if (p != null)
        {
            p.AddCareItem(new CareItem(name, status));
            return $"Created Care {name} for {plantId}!";
        }
        else
        {
            return "Plant not found!.";
        }
    }

    public string AddPlant(List<string> args)
    {
        int id = int.Parse(args[0]);
        string name = args[1];
        double humidityLevel = double.Parse(args[2]);
        double fertilityLevel = double.Parse(args[3]);
        string type = args[4];
        if (this.plants.ContainsKey(id))
        {
            return $"Plant with ID {id} already exists!";
        }
        Plant p = null;
        switch (type)
        {
            case "flower":
                string color = args[5];
                p = new FloweringPlant(id, name, humidityLevel, fertilityLevel, color);
                break;

            case "tree":
                int height = int.Parse(args[5]);
                p = new TreePlant(id, name, humidityLevel, fertilityLevel, height);
                break;
        }
        plants.Add(id, p);
        return $"Created Plant {name} with ID {id}!";
    }
    public string GetTotalCaresByPlantId(List<string> args)
    {
        int id = int.Parse(args[0]);
        if (!plants.ContainsKey(id))
        {
            return "Plant not found!.";
        }
        Plant p = plants[id];
        return $"Total cares for plant {id}: {p.TotalCaresDone()}";
    }
    public string WaterPlantById(List<string> args)
    {
        int id = int.Parse(args[0]);
        double percent = double.Parse(args[1]);
        Plant p = plants[id];
        if (p.Water(percent))
        {
            return $"Plant {id} was watered successfully!";
        }
        return $"Plant {id} could not be watered!.";
    }
    public string FertilizePlantById(List<string> args)
    {
        int id = int.Parse(args[0]);
        double percent = double.Parse(args[1]);
        Plant p = plants[id];
        if (p.Fertilize(percent))
        {
            return $"Plant {id} was fertilized  successfully!";
        }
        return $"Plant {id} could not be fertilized !.";
    }
    public string GetTallestTree(List<string> args)
    {
        //TODO: Add some logic here …
    }

}

