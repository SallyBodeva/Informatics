using System;
using System.Collections.Generic;
using System.Text;

public class Cabinet:Furniture
{
    public Cabinet(string typeProduct, double productionPrice,int numberOfHinges) : base(typeProduct, productionPrice)
    {
        this.NumberOfHinges = numberOfHinges;
    }

    public int NumberOfHinges { get; private set; }

    public override double PriceClient()
    {
        return (this.ProductionPrice * 1.5) + this.NumberOfHinges * 4.5;
    }
    public override string ToString()
    {
        return $"The cabinet costs <{PriceClient():f2}> lv.";
    }
}
