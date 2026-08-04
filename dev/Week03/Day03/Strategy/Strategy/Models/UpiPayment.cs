namespace Strategy.Models
{
    public class UpiPayment : IPaymentStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid ₹{amount} using UPI.");
        }
    }
}