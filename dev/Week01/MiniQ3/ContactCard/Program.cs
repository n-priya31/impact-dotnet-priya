using System;

namespace ContactCardProject
{
    class Program
    {
        static void Main()
        {
            ContactCard[] contacts =
            {
                new ContactCard("Priya","9876543210","priya@gmail.com"),
                new ContactCard("Rahul","9876500000","rahul@gmail.com"),
                new ContactCard("Anitha","9123456789","anitha@gmail.com"),
                new ContactCard("Kiran","9000001111","kiran@gmail.com"),
                new ContactCard("David","9888888888","david@gmail.com")
            };

            Console.Write("Enter name to search : ");

            string search = Console.ReadLine();

            bool found = false;

            foreach (ContactCard contact in contacts)
            {
                if (contact.Name.Equals(
                    search,
                    StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("\nContact Found\n");

                    contact.Display();

                    found = true;

                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("\nContact Not Found");
            }
        }
    }
}