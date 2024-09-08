using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Director:ClubMember
{
    public Director(string firstName, string lastName, int age, double salary, string directorType) : base(firstName, lastName, age, salary)
    {
        this.DirectorType = directorType;
    }

    public string DirectorType { get; set; }

    public override string Info()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"{this.DirectorType} director: {this.FirstName} {this.LastName}");
        sb.AppendLine($"{this.Salary:f2} lv");
        sb.AppendLine($"{this.Age} years");
        return sb.ToString().TrimEnd();
    }
}