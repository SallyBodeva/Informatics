using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P23_GroceryStore_OOP_
{
    public class Food:Product,IComparable<Food>
    {
        public Food(int days)
        {
            this.ExpiryDate= DateTime.UtcNow.AddDays(days);
        }
        public DateTime ExpiryDate { get; private set; }
        public string Unit { get; private set; }

        public int CompareTo(Food? other)
        {
            int comparison = this.ExpiryDate.CompareTo(other.ExpiryDate);
            if (comparison==0)
            {
                comparison = this.Quantity.CompareTo(other.Quantity);
            }
            return comparison;
        }
        public void SetExpiryDate(DateTime newDate)
        {
            this.ExpiryDate = newDate;
        }
        public override string ToString()
        {
            return base.ToString() + $"{Environment.NewLine} Expriration date: {this.ExpiryDate}"; 
        }
    }
}
