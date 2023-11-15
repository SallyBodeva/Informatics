using P22_CryptoMiningSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;


public class Controller
{
    private Dictionary<string, User> users = new Dictionary<string, User>();
    public string RegisterUser(List<string> args)
    {
        string name = args[1];
        double money = double.Parse(args[2]);
        User u = new User() { Name = name, Money = money };
        if (users.ContainsKey(name))
        {
            return $"Username: {name} already exists!";
        }
        else
        {
            users.Add(name, u);
            return $"Successfully registered user – {name}!";
        }
    }

    public string CreateComputer(List<string> args)
    {
        string name = args[1];
        string processorType = args[2];
        string processorModel = args[3];
        int processorGeneration = int.Parse(args[4]);
        double processorPrice = double.Parse(args[5]);
        string videoCardType = args[6];
        string videoCardModel = args[7];
        int videoCardGeneration = int.Parse(args[8]);
        int videoCardRam = int.Parse(args[9]);
        double videoCardPrice = double.Parse(args[10]);
        int computerRam = int.Parse(args[11]);
        if (!users.ContainsKey(name))
        {
            return $"Username: {name} does not exist!";
        }
        if (processorType!="Low" && processorType!="High")
        {
            return "Invalid type processor!";
        }
        if (videoCardType!="Game" && videoCardType!="Mine")
        {
            return "Invalid type video card!";
        }
        User u = users[name];
        if (u.Money<(processorPrice+videoCardPrice))
        {
            return $"User: {name} - insufficient funds!";
        }
        Processor p = null;
        switch (processorType)
        {
            case "Low":
                p = new LowPerformanceProcessor() { Model = processorModel, Price = processorPrice, Generation = processorGeneration };
                break;
            case "High":
                p = new HighPerformanceProcessor() { Model = processorModel, Price = processorPrice, Generation = processorGeneration };
                break;
        }
        VideoCard v = null;
        switch (videoCardType)
        {
            case "Game":
                v = new GameVideoCard() { Model = videoCardModel, Price = videoCardPrice, Generation = videoCardGeneration,Ram=videoCardRam };
                break;
            case "Mine":
                v = new MineVideoCard() { Model = videoCardModel, Price = videoCardPrice, Generation = videoCardGeneration, Ram = videoCardRam };
                break;
        }
        Computer c = new Computer() { Processor = p, VideoCard = v, Ram = computerRam };
        users[name].Computer = c;
        return $"Successfully created computer for user: {name}!";
    }

    public string Mine()
    {
        double minedMoney = 0;
        foreach (var user in users)
        {
            minedMoney += user.Value.Computer.MinedAmountPerHour * 24;
            user.Value.Computer.Processor.LifeWorkingHours-=24;
            user.Value.Computer.VideoCard.LifeWorkingHours -= 24;
            user.Value.Money += user.Value.Computer.MinedAmountPerHour * 24;
        }
        return $"Daily profits: {minedMoney}!";
        
    }

    public string UserInfo(List<string> args)
    {
        string name = args[1];
        User u = users[name];
        if (users.ContainsKey(name))
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {name} - Stars: {u.Stars}");
            sb.AppendLine($"Balance: {u.Money}");
            if (u.Computer!=null)
            {
                sb.AppendLine($"PC Ram: {u.Computer.Ram}");
                sb.AppendLine($"- {u.Computer.Processor.GetType().Name} – {u.Computer.Processor.Model} – {u.Computer.Processor.Generation}");
                sb.AppendLine($"- {u.Computer.VideoCard.GetType().Name} – {u.Computer.VideoCard.Model} – {u.Computer.VideoCard.Generation}");
                sb.AppendLine($"* Video card Ram: {u.Computer.VideoCard.Ram}");
            }
            return sb.ToString().TrimEnd();
        }
        return $"Username: {name} does not exist!";
    }

    public string Shutdown()
    {
        StringBuilder sb = new StringBuilder();
        foreach (var user in users)
        {
            sb.AppendLine($"Name: {user.Value.Name} - Stars: {user.Value.Stars}");
            sb.AppendLine($"Balance: {user.Value.Money}");
            if (user.Value.Computer != null)
            {
                sb.AppendLine($"PC Ram: {user.Value.Computer.Ram}");
                sb.AppendLine($"- {user.Value.Computer.Processor.GetType().Name} – {user.Value.Computer.Processor.Model} – {user.Value.Computer.Processor.Generation}");
                sb.AppendLine($"- {user.Value.Computer.VideoCard.GetType().Name} – {user.Value.Computer.VideoCard.Model} – {user.Value.Computer.VideoCard.Generation}");
                sb.AppendLine($"* Video card Ram: {user.Value.Computer.VideoCard.Ram}");
            }
        }
        sb.AppendLine($"System total profits: {users.Values.Sum(x=>x.Money)}!!!");
        return sb.ToString().TrimEnd();
    }

}

