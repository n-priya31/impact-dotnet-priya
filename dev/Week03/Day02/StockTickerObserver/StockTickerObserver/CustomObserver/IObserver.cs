namespace StockTickerObserver.CustomObserver
{
    public interface IObserver
    {
        void Update(string stockName, decimal price);
    }
}