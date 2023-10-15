using System;
using System.Collections.Generic;
using System.Text;

namespace P03_TripleNums
{
    public class Triple
    {
        public Triple(int num1, int num2, int num3)
        {
            this.Num1 = num1;
            this.Num2 = num2;
            this.Num3 = num3;
        }

        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public int Num3 { get; set; }
    }
}
