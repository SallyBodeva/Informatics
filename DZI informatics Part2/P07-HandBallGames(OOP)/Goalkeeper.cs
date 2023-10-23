using System;
using System.Collections.Generic;
using System.Text;

namespace P07_HandBallGames_OOP_
{
    public class Goalkeeper : Player
    {
        public Goalkeeper(string name) : base(name, 2.5)
        {
        }

        public override void DecreaseRating()
        {
            this.Rating -= 1.25;
        }

        public override void IncreaseRating()
        {
            this.Rating += 0.75;
        }
    }
}
