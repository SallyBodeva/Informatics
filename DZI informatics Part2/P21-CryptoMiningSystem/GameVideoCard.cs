using System;
using System.Collections.Generic;
using System.Text;

namespace P21_CryptoMiningSystem
{
    public class GameVideoCard:VideoCard
    {
        public override int Generation
        {
            get { return base.Generation; }
            set
            {
                if (value>9)
                {
                    throw new ArgumentException("GameVideoCard");
                }
                base.Generation = value;
            }
        }
    }
    //TODO
}
