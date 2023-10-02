using System;
using System.Collections.Generic;
using System.Text;

namespace P10_Furniture
{
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
            get { return typeProduct; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Value should not be null or empty");
                }
                typeProduct = value;
            }
        }
        public double ProductionPrice
        {
            get { return productionPrice; }
            set
            {
                if (value<0)
                {
                    throw new ArgumentException("Value should be over 0");
                }
                productionPrice = value;
            }
        }
        public abstract double PriceCalculation();
    }
}
