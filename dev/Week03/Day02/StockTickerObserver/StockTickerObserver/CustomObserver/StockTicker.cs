using System.Collections.Generic;

namespace StockTickerObserver.CustomObserver
{
    public class StockTicker
    {
        private readonly List<IObserver> _investors = new();

        public string StockName { get; }

        private decimal _price;

        public StockTicker(string stockName)
        {
            StockName = stockName;
        }

        public void Subscribe(IObserver investor)
        {
            _investors.Add(investor);
        }

        public void Unsubscribe(IObserver investor)
        {
            _investors.Remove(investor);
        }

        public void SetPrice(decimal newPrice)
        {
            _price = newPrice;
            NotifyInvestors();
        }

        private void NotifyInvestors()
        {
            foreach (var investor in _investors)
            {
                investor.Update(StockName, _price);
            }
        }
    }
}