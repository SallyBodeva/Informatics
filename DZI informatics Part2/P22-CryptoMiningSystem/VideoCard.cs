using System;
using System.Collections.Generic;
using System.Text;


public class VideoCard : Components
{
    private readonly double minedMoneyPerHour;

    public virtual int Ram { get; set; }

    public virtual double MinedMoneyPerHour
    {
        get
        {
            return this.Ram*(base.Generation / 10);
        }
    }
    public override int LifeWorkingHours
    {
        get
        {
            return this.Ram * (base.Generation * 10);
        }
    }
}
