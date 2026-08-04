namespace Strategy.Models
{
    public interface IPaymentStrategy
    {
        void Pay(decimal amount);
    }
}