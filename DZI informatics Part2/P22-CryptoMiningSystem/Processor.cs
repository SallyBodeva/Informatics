using System;
using System.Collections.Generic;
using System.Text;


public class Processor:Components
{
    public virtual int MineMultiplier { get;}

    public override int LifeWorkingHours
    {
        get { return this.Generation * 100; }
    }
}

