using System;

namespace StockTickerObserver.CustomObserver
{
    public class Investor : IObserver
    {
        public string Name { get; }

        public Investor(string name)
        {
            Name = name;
        }

        public void Update(string stockName, decimal price)
        {
            Console.WriteLine($"{Name} notified: {stockName} price changed to ₹{price}");
        }
    }
}