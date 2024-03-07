using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_Zad28_DZI_Aug2022_
{
    public  class Car
    {
        public Car(string brand, int hPower)
        {
            this.Brand = brand;
            this.HPower = hPower;
        }

        public string Brand { get; private set; }
        public int HPower { get; private set; }

        public override string ToString()
        {
            return $"{this.Brand},{this.HPower}";
        }
    }
}
