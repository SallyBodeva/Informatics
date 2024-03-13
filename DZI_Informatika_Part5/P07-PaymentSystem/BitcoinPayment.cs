using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07_PaymentSystem
{
    public class BitcoinPayment : IPayment
    {
        public string Pay(decimal amount)
        {
            return $"Successfully paid {amount} to merchant using {PaymentMethod.Bitcoin}.";
        }
    }
}
