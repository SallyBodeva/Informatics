using System;
using System.Collections.Generic;
using System.Text;

namespace P22_CryptoMiningSystem
{
    public class HighPerformanceProcessor:Processor
    {
        public override int Generation
        {
            get { return base.Generation; }
            set
            {
                if (value > 9)
                {
                    throw new ArgumentException($"{nameof(HighPerformanceProcessor)} generation cannot be more than 9!");
                }
                base.Generation = value;
            }
        }
        public override int MineMultiplier
        {
            get
            {
                return 8;
            }
        }
    }
}
