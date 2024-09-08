using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class FootballPlayer : ClubMember
{
    public FootballPlayer(string firstName, string lastName, int age, double salary, string position, int contactLength,int matches,int goals, int assist) : base(firstName, lastName, age, salary)
    {
        this.Position = position;
        this.ConstractLength = contactLength;
        this.Matches = matches;
        this.Goals = goals;
        this.Assist = assist;
    }
    public string Position { get; set; }
    public int ConstractLength { get; set; }
    public int Matches { get; set; }

    public int Goals { get; set; }
    public int Assist { get; set; }
    public override string Info()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"{this.FirstName} {this.LastName} - {this.Position}");
        sb.AppendLine($"{this.Salary:f2} lv");
        sb.AppendLine($"{this.Age} years");
        sb.AppendLine($"{this.Goals} goals and {this.Assist} assists in {this.Matches}matches");
        return sb.ToString().TrimEnd();
    }
}
