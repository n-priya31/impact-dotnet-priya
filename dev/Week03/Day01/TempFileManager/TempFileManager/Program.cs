using System;
using System.IO;
using TempFileDemo;

class Program
{
    static void Main()
    {
        string filePath;

        using (TempFileManager manager = new TempFileManager())
        {
            filePath = manager.FilePath;

            Console.WriteLine();

            Console.WriteLine("Inside using block");

            Console.WriteLine($"File Exists : {File.Exists(filePath)}");

            Console.WriteLine("Press Enter...");
            Console.ReadLine();
        }

        Console.WriteLine();

        Console.WriteLine("Outside using block");

        Console.WriteLine($"File Exists : {File.Exists(filePath)}");
    }
}