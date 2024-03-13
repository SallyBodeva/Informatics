using System.Text;

namespace P07_PaymentSystem
{
    internal class Program
    {
        static void Main()
        {
            IPayment payment;
            Console.WriteLine("Choose your payment method");
            Menu();
            Console.Write("Enter the method:");
            int cmd = int.Parse(Console.ReadLine());
         //   string cmd = Console.ReadLine();
            Console.Write("Enter the amount of money:");
            decimal amount = decimal.Parse(Console.ReadLine());
            switch (cmd)
            {
                case 0:
                    payment = new GooglePayPayment();
                    Console.WriteLine(payment.Pay(amount));
                    break;
                case 1:
                    payment = new PayPalPayment();
                    Console.WriteLine(payment.Pay(amount));
                    break;
                case 2:
                    payment = new CreditCardPayment();
                    Console.WriteLine(payment.Pay(amount));
                    break;
                case 3:
                    payment = new BitcoinPayment();
                    Console.WriteLine(payment.Pay(amount));
                    break;
                case 4:
                    payment = new ApplePayPayment();
                    Console.WriteLine(payment.Pay(amount));
                    break;
                default:
                    Console.WriteLine($"{cmd} is not currently supported as a payment method.");
                    break;
            }
        }
        public static void Menu()
        {
           
            foreach (var item in Enum.GetValues(typeof(PaymentMethod)))
            {
                Console.WriteLine($"{(int)item} {item}");
            }
        }
    }
}
