using System;

namespace PaymentStrategy
{
    public class PaymentStrategy
    {
        private IPaymentStrategy _paymentStrategy;

        public PaymentStrategy(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }

        public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }

        public void ProcessPayment(double amount)
        {
            _paymentStrategy.ProcessPayment(amount);
        }
    }
}