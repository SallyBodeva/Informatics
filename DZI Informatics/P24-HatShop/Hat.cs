using System;
using System.Collections.Generic;
using System.Text;

namespace P24_HatShop
{
    public class Hat
    {
        private double price;

        public Hat(string type, string color, double price)
        {
            this.Type = type;
            this.Color = color;
            this.Price = price;
        }

        public string Type { get; set; }
        public string Color { get; set; }
        public double Price
        {
            get => price; set
            {
                if (value>100)
                {
                    throw new ArgumentException("Invalid hat price!");
                }
                price = value;
            }
        }
        public override string ToString()
        {
            return $"Hat {Type} with color {Color} costs {Price:f2} ";
        }
    }
}
