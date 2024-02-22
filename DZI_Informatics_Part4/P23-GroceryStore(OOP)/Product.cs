using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P23_GroceryStore_OOP_
{
    public abstract class Product : IComparable<Product>, ICost
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public double Price { get; private set; }
        public int Quantity { get; private set; }
        public double Discount { get; private set; } = 0;

        public int CompareTo(Product? other)
        {
            int comparison = other.Price.CompareTo(this.Price);
            if (comparison == 0)
            {
                comparison = this.Name.CompareTo(other.Name);
            }
            return comparison;
        }

        public virtual double GetCost()
        {
            return this.Quantity * this.Price;
        }
        public void SetPrice(double newPrice)
        {
            this.Price = newPrice;
        }
        public void SetQuantity(int newQauntity)
        {
            this.Quantity = newQauntity;
        }
        public void SetDiscount(double newDiscount)
        {
            this.Discount = newDiscount;
        }
        public override string ToString()
        {
            return $"Product {this.Name} with Id {this.Id} costs {this.Price}, " +
                $"the available quantity is {this.Quantity}";
        }
    }
}
