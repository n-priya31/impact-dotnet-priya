namespace Strategy.Models
{
    public class NetBankingPayment : IPaymentStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid ₹{amount} using Net Banking.");
        }
    }
}