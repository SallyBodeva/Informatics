using System;
using System.Collections.Generic;
using System.Text;


public class GameVideoCard:VideoCard
{
    public override int Ram
    {
        get { return base.Ram; }
        set
        {
            if (value<=0 || value>32)
            {
                throw new ArgumentException($"{nameof(GameVideoCard)} ram cannot less or equal to 0 and more than 32!");
            }
            base.Ram = value;
        }
    }
    public override int Generation
    {
        get { return base.Generation; }
        set
        {
            if (value>9)
            {
                throw new ArgumentException("Game video card generation cannot be more than 9!");
            }
            base.Generation = value;
        }
    }
    public override double MinedMoneyPerHour
    {
        get
        {
            return base.MinedMoneyPerHour * 2;
        }
    }
}

