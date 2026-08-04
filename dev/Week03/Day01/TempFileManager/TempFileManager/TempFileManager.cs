using System;
using System.IO;

namespace TempFileDemo
{
    public class TempFileManager : IDisposable
    {
        // Stores the path of the temporary file
        public string FilePath { get; }

        // Constructor
        public TempFileManager()
        {
            // Create a temporary file
            FilePath = Path.GetTempFileName();

            Console.WriteLine($"Temporary file created: {FilePath}");
        }

        // Dispose method
        public void Dispose()
        {
            // Delete the file if it exists
            if (File.Exists(FilePath))
            {
                File.Delete(FilePath);
                Console.WriteLine("Temporary file deleted.");
            }

            // Prevent the finalizer from running
            GC.SuppressFinalize(this);
        }

        // Finalizer
        ~TempFileManager()
        {
            Console.WriteLine("Finalizer executed.");

            if (File.Exists(FilePath))
            {
                File.Delete(FilePath);
            }
        }
    }
}