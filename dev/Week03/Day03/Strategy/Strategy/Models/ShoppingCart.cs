namespace Strategy.Models
{
    public class ShoppingCart
    {
        private IPaymentStrategy paymentStrategy;

        public ShoppingCart(IPaymentStrategy paymentStrategy)
        {
            this.paymentStrategy = paymentStrategy;
        }

        public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
        {
            this.paymentStrategy = paymentStrategy;
        }

        public void Checkout(decimal amount)
        {
            paymentStrategy.Pay(amount);
        }
    }
}