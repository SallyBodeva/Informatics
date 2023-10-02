using System;
using System.Collections.Generic;
using System.Text;

namespace P10_Furniture
{
    public class Cabinet : Furniture
    {
        public int NumberOfHinges { get; set; }
        public Cabinet(double productionPrice,int numberOfHinges, string typeProduct="cabinet") : base(typeProduct, productionPrice)
        {
            this.NumberOfHinges = numberOfHinges;
        }

        public override double PriceCalculation()
        {
            double clientPrice = base.ProductionPrice * 1.15 + this.NumberOfHinges*4.5;
            return clientPrice;
        }
        public override string ToString()
        {
            return $"The cabinet costs {PriceCalculation():f2} lv.";
        }
    }
}
