using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Principal;
using System.Text;

namespace P03_ClothingMagazine
{
    public class Cloth
    {
        private int size;
        private string color;
        private string type;

        public Cloth(string color, int size, string type)
        {
            this.Color = color;
            this.Size = size;
            this.Type = type;
        }

        public int Size
        {
            get { return size; }
            set
            {
                size = value;
            }
        }
        public string Color
        {
            get { return color; }
            set
            {
                color = value;
            }
        }
        public string Type
        {
            get { return type; }
            set
            {
                type = value;
            }
        }
        public override string ToString()
        {
            return $"Product: {this.Type} with size {this.Size}, color {this.Color}";
        }
    }
}
