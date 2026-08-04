using System;

public class OrderFacade
{
    private readonly InventoryService inventory = new InventoryService();
    private readonly PaymentService payment = new PaymentService();
    private readonly ShippingService shipping = new ShippingService();

    public void PlaceOrder()
    {
        inventory.CheckStock();
        payment.ProcessPayment();
        shipping.ShipOrder();

        Console.WriteLine("Order placed successfully.");
    }
}