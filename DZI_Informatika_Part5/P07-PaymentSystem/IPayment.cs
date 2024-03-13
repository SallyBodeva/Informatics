using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07_PaymentSystem
{
    public  interface IPayment
    {
        public string Pay(decimal  amount);
    }
}
