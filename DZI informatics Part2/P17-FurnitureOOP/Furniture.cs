using System;
using System.Collections.Generic;
using System.Text;

public abstract class Furniture
{
    private string typeProduct;
    private double productionPrice;

    protected Furniture(string typeProduct, double productionPrice)
    {
        this.TypeProduct = typeProduct;
        this.ProductionPrice = productionPrice;
    }

    public string TypeProduct
    {
        get => typeProduct; 
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Invalid data...");
            }
            typeProduct = value;
        }
    }
    public double ProductionPrice
    {
        get => productionPrice; 
        private set
        {
            if (value<=0)
            {
                throw new ArgumentException("Invalid data...");
            }
            productionPrice = value;
        }
    }
    public abstract double PriceClient();
}

