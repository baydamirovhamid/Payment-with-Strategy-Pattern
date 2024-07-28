using System;

namespace PaymentStrategy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IPaymentStrategy creditCardStrategy = new CreditCardPaymentStrategy("1234-5678-9101-1213", "09/2028", 912);
            IPaymentStrategy paypalStrategy = new PayPalPaymentStrategy("baydamirovv35@gmail.com", "password123");
            IPaymentStrategy bitcoinStrategy = new BitcoinPaymentStrategy("1A1zP1eP5Qadfx2DMPTfTL5SLmv7DivfNa");

            PaymentStrategy paymentStrategy = new PaymentStrategy(creditCardStrategy);

            paymentStrategy.ProcessPayment(1500.0);

            paymentStrategy.SetPaymentStrategy(paypalStrategy);
            paymentStrategy.ProcessPayment(2500.0);

            paymentStrategy.SetPaymentStrategy(bitcoinStrategy);
            paymentStrategy.ProcessPayment(2.0);
        }
    }
}