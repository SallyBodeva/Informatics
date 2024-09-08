using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Coach : ClubMember
{
    public Coach(string firstName, string lastName, int age, double salary, string coachType, int contractLength) : base(firstName, lastName, age, salary)
    {
        CoachType = coachType;
        ContractLength = contractLength;
    }
    public string CoachType { get; set; }
    public int ContractLength { get; set; }
    public override string Info()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"{this.CoachType} coach: {this.FirstName} {this.LastName}");
        sb.AppendLine($"{this.Salary:f2} lv");
        sb.AppendLine($"{this.Age} years");
        return sb.ToString().TrimEnd();
    }
}

