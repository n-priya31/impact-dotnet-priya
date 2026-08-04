public class Invoice
{
    public int InvoiceId { get; set; }

    public string CustomerName { get; set; }

    public double Amount { get; set; }

    public Invoice()
    {
    }

    public Invoice(int invoiceId, string customerName, double amount)
    {
        InvoiceId = invoiceId;
        CustomerName = customerName;
        Amount = amount;
    }

    public void PrintInvoice()
    {
        Console.WriteLine("Invoice Printed");
    }

    public void CalculateTax()
    {
        Console.WriteLine("Tax Calculated");
    }
}