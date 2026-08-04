using System;

namespace StockTickerObserver.EventObserver
{
    public class StockTicker
    {
        public string StockName { get; }

        private decimal _price;

        public StockTicker(string stockName)
        {
            StockName = stockName;
        }

        public event Action<string, decimal>? PriceChanged;

        public void SetPrice(decimal newPrice)
        {
            _price = newPrice;

            PriceChanged?.Invoke(StockName, _price);
        }
    }
}