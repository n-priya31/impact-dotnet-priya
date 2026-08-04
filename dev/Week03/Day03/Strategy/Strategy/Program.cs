using Strategy.Models;

ShoppingCart cart = new ShoppingCart(new CreditCardPayment());

Console.WriteLine("First Payment");
cart.Checkout(1500);

Console.WriteLine();

Console.WriteLine("Changing to UPI...");
cart.SetPaymentStrategy(new UpiPayment());

cart.Checkout(1500);

Console.WriteLine();

Console.WriteLine("Changing to Net Banking...");
cart.SetPaymentStrategy(new NetBankingPayment());

cart.Checkout(1500);