using System;

namespace PaymentStrategy
{
    public class BitcoinPaymentStrategy : IPaymentStrategy
    {
        private string _walletAddress;

        public BitcoinPaymentStrategy(string walletAddress)
        {
            _walletAddress = walletAddress;
        }

        public void ProcessPayment(double amount)
        {
            Console.WriteLine("Processing Bitcoin payment...");
            Console.WriteLine($"Wallet Address: {_walletAddress}");
            Console.WriteLine($"Amount: {amount}");
            Console.WriteLine("Payment processed successfully!");
        }
    }
}