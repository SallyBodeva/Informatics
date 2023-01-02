using System;
using System.Collections.Generic;
using System.Text;

public class LieutenantGeneral : Private
{
    public LieutenantGeneral(string id, string firstName, string lastName, decimal salary) : base(id, firstName, lastName, salary)
    {
    }
    private List<Private> privates;
}

