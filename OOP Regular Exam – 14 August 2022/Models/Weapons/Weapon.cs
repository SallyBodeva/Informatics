using PlanetWars.Models.Weapons.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlanetWars.Models.Weapons
{
    public  abstract class Weapon : IWeapon
    {
        private int destructionLevel;

        public Weapon(double price, int destructionLevel)
        {
            this.Price = price;
            this.DestructionLevel = destructionLevel;
        }

        public double Price { get; private set; }

        public int DestructionLevel
        {
            get
            {
                return destructionLevel;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(Utilities.Messages.ExceptionMessages.TooLowDestructionLevel); ;
                }
                if (value>10)
                {
                    throw new ArgumentException(Utilities.Messages.ExceptionMessages.TooHighDestructionLevel);
                }
                destructionLevel = value;
            }
        }
    }
}
