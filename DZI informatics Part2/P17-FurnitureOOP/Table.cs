using System;
using System.Collections.Generic;
using System.Text;

namespace P17_FurnitureOOP
{
    public class Table : Furniture
    {
        public Table(string typeProduct, double productionPrice) : base(typeProduct, productionPrice)
        {
        }

        public override double PriceClient()
        {
            return this.ProductionPrice * 1.2;
        }
        public override string ToString()
        {
            return $"The table costs <{PriceClient():f2}>lv.";
        }
    }
}
