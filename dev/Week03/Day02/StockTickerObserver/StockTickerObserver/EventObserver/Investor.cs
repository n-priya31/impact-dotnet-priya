using System;

namespace StockTickerObserver.EventObserver
{
    public class Investor
    {
        public string Name { get; }

        public Investor(string name)
        {
            Name = name;
        }

        public void ReceiveNotification(string stockName, decimal price)
        {
            Console.WriteLine($"{Name} notified: {stockName} price changed to ₹{price}");
        }
    }
}