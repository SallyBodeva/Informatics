using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace P16_Store
{
    public class Item:IComparable<Item>
    {
        private string description;
        private double price;

        public Item(string description, double price)
        {
            this.Description = description;
            this.Price = price;
        }

        public string Description
        {
            get => description; private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid description...");
                }
                description = value;
            }
        }
        public double Price
        {
            get => price; private set
            {
                if (value<=0)
                {
                    throw new ArgumentException("Invalid price...");
                }
                price = value;
            }
        }

        public int CompareTo([AllowNull] Item other)
        {
            int comapre = this.Description.CompareTo(other.Description);
            return comapre;
        }
        public override string ToString()
        {
            return $"„{this.Description} ({this.Price})“";
        }
    }
}
