using System;
using System.Collections.Generic;
using System.Text;


public class LowPerformanceProcessor:Processor
{
    public override int Generation
    {
        get { return base.Generation; }
        set
        {
            if (value>9)
            {
                throw new ArgumentException($"{nameof(LowPerformanceProcessor)} generation cannot be more than 9!");
            }
            base.Generation = value;
        }
    }
    public override int MineMultiplier
    {
        get
        {
            return 2;
        }
    }
}
