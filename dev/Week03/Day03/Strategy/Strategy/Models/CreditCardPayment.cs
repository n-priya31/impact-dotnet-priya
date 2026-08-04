namespace Strategy.Models
{
    public class CreditCardPayment : IPaymentStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid ₹{amount} using Credit Card.");
        }
    }
}