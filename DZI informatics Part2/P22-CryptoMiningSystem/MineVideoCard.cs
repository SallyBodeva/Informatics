using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;


public class MineVideoCard:VideoCard
{
    public override int Ram
    {
        get { return base.Ram; }
        set
        {
            if (value <= 0 || value > 32)
            {
                throw new ArgumentException($"{nameof(MineVideoCard)} ram cannot less or equal to 0 and more than 32!");
            }
            base.Ram = value;
        }
    }
    public override int Generation
    {
        get { return base.Generation; }
        set
        {
            if (value>6)
            {
                throw new ArgumentException("Mine video card generation cannot be more than 6!");
            }
            base.Generation = value;
        }
    }
    public override double MinedMoneyPerHour
    {
        get
        {
            return base.MinedMoneyPerHour * 8;
        }
    }
    public override int LifeWorkingHours
    {
        get
        {
            return base.LifeWorkingHours * 2;
        }
    }
}

