using System;

namespace PaymentStrategy
{
    public class PayPalPaymentStrategy : IPaymentStrategy
    {
        private string _email;
        private string _password;

        public PayPalPaymentStrategy(string email, string password)
        {
            _email = email;
            _password = password;
        }

        public void ProcessPayment(double amount)
        {
            Console.WriteLine("Processing PayPal payment...");
            Console.WriteLine($"Email: {_email}");
            Console.WriteLine($"Password: {_password}");
            Console.WriteLine($"Amount: {amount}");
            Console.WriteLine("Payment processed successfully!");
        }
    }
}