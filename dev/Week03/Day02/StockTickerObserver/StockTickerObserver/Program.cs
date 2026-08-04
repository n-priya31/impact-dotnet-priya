using System;
using StockTickerObserver.CustomObserver;

namespace StockTickerObserver
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Custom Observer \n");

            var customTicker = new StockTickerObserver.CustomObserver.StockTicker("TCS");

            var investor1 = new Investor("Priya");
            var investor2 = new Investor("Rahul");
            var investor3 = new Investor("Anita");

            customTicker.Subscribe(investor1);
            customTicker.Subscribe(investor2);
            customTicker.Subscribe(investor3);

            customTicker.SetPrice(3850);
            customTicker.SetPrice(3900);

            Console.WriteLine();

            Console.WriteLine(" C# Events n");

            var eventTicker = new StockTickerObserver.EventObserver.StockTicker("Infosys");

            var eInvestor1 = new StockTickerObserver.EventObserver.Investor("Priya");
            var eInvestor2 = new StockTickerObserver.EventObserver.Investor("Rahul");
            var eInvestor3 = new StockTickerObserver.EventObserver.Investor("Anita");

            eventTicker.PriceChanged += eInvestor1.ReceiveNotification;
            eventTicker.PriceChanged += eInvestor2.ReceiveNotification;
            eventTicker.PriceChanged += eInvestor3.ReceiveNotification;

            eventTicker.SetPrice(1500);
            eventTicker.SetPrice(1525);

            Console.ReadKey();
        }
    }
}