using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Department
{
    private readonly List<Employee> employees = new List<Employee>();
    public void AddMember(Employee member)
    {
        this.employees.Add(member);
    }
    public Employee GetOldest()
    {
        return this.employees.OrderBy(x => x.Age).Last();
    }

}

