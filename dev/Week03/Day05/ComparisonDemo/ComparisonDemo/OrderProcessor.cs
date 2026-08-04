using System;

public class OrderProcessor
{
    public int OrderId { get; set; }

    public string CustomerName { get; set; }

    public void ProcessOrder()
    {
        Console.WriteLine($"Processing Order {OrderId} for {CustomerName}");
    }
}