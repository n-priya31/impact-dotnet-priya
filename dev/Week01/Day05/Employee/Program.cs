using System;
using System.Net;

class Program
{
    static void Main()
    {
        Console.WriteLine(" PARTIAL CLASS DEMO ");
        Employee emp = new Employee(1, "Priya");
        emp.CreateEmployee();

        Console.WriteLine("\n RECORD DEMO ");
        Address a1 = new Address("Anna Nagar", "Chennai", "600040");
        Address a2 = a1 with { City = "Coimbatore" };

        Console.WriteLine(a1 == new Address("Anna Nagar", "Chennai", "600040")); // True
        Console.WriteLine($"Original: {a1}");
        Console.WriteLine($"Modified: {a2}");

        Console.WriteLine("\n INDEXER DEMO ");
        Playlist playlist = new Playlist();

        Console.WriteLine(playlist[0]);      // int indexer
        playlist[1] = "Shape of You";

        Console.WriteLine(playlist["Faded"]); // string indexer

        Console.WriteLine("\n ACCESS MODIFIER DEMO ");
        AccessModifierDemo demo = new AccessModifierDemo();
        demo.ShowAccess();
    }
}