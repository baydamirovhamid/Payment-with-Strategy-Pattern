using System;

namespace PaymentStrategy
{
    public class CreditCardPaymentStrategy : IPaymentStrategy
    {
        private string _cardNumber;
        private string _expirationDate;
        private short _cvv;

        public CreditCardPaymentStrategy(string cardNumber, string expirationDate, short cvv)
        {
            _cardNumber = cardNumber;
            _expirationDate = expirationDate;
            _cvv = cvv;
        }

        public void ProcessPayment(double amount)
        {
            Console.WriteLine("Processing credit card payment...");
            Console.WriteLine($"Card Number: {_cardNumber}");
            Console.WriteLine($"Expiration Date: {_expirationDate}");
            Console.WriteLine($"CVV: {_cvv}");
            Console.WriteLine($"Amount: {amount}");
            Console.WriteLine("Payment processed successfully!");
        }
    }
}