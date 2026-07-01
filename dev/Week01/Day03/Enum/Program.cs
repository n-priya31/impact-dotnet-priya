using System;

namespace Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // DaysOfWeek Enum

            Console.Write("Enter a number (0-6): ");

            int number = Convert.ToInt32(Console.ReadLine());

            DaysOfWeek day = (DaysOfWeek)number;

            Console.WriteLine($"Day: {day}");

            Console.WriteLine();

            // FilePermission Flags

            FilePermission permission =
                FilePermission.Read | FilePermission.Write;

            Console.WriteLine($"Combined Permission: {permission}");

            if ((permission & FilePermission.Read) == FilePermission.Read)
            {
                Console.WriteLine("Read Permission Available");
            }

            if ((permission & FilePermission.Write) == FilePermission.Write)
            {
                Console.WriteLine("Write Permission Available");
            }

            if ((permission & FilePermission.Execute) == FilePermission.Execute)
            {
                Console.WriteLine("Execute Permission Available");
            }
            else
            {
                Console.WriteLine("Execute Permission Not Available");
            }
        }
    }
}