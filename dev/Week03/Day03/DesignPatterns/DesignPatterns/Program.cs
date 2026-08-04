using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(" Adapter Pattern ");

        XmlReportAdapter adapter = new XmlReportAdapter();
        adapter.GenerateReport();

        Console.WriteLine();

        Console.WriteLine(" Facade Pattern ");

        OrderFacade facade = new OrderFacade();
        facade.PlaceOrder();

        Console.ReadKey();
    }
}