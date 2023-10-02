using System;
using System.Collections.Generic;
using System.Text;

namespace P10_Furniture
{
    public class Table : Furniture
    {
        public Table(double productionPrice, string typeProduct="table") : base(typeProduct, productionPrice)
        {
           
        }
    
        public override double PriceCalculation()
        {
            double clientPrice = base.ProductionPrice * 1.2;
            return clientPrice;
        }
        public override string ToString()
        {
            return $"The table costs {this.PriceCalculation():f2}lv.";
        }
    }
}
