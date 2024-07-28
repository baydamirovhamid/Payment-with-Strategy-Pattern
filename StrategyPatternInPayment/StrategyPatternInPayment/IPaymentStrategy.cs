using System;

namespace PaymentStrategy
{
    public interface IPaymentStrategy
    {
        public void ProcessPayment(double amount);
    }
}