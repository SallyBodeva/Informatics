﻿using ChristmasPastryShop.Models.Cocktails.Contracts;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ChristmasPastryShop.Models.Cocktails
{
    public abstract class Cocktail : ICocktail
    {
        private string name;

        public Cocktail(string name, string size, double price)
        {
            this.Name = name;
            this.Size = size;
            this.Price = price;
            if (size == "Middle")
            {
                this.Price = (this.Price * 2) / 3;
            }
            else if (size == "Small")
            {
                this.Price = this.Price / 3;
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Name cannot be null or whitespace!");
                }
                name = value;
            }
        }

        public string Size { get; set; }

        public double Price { get; set; }

        public override string ToString()
        {
            return $"{this.Name} ({this.Size}) - {this.Price:f2} lv";
        }
    }
}
