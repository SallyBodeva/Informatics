using System;
using System.Collections.Generic;
using System.Text;

namespace P07_HandBallGames_OOP_
{
    public class CenterBack : Player
    {
        public CenterBack(string name) : base(name, 4)
        {
        }

        public override void DecreaseRating()
        {
            this.Rating -= 1;
        }

        public override void IncreaseRating()
        {
            this.Rating += 1;
        }
    }
}
